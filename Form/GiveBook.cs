using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryPri
{
    public partial class GiveBook : Form
    {
        private bool btn = false;
        public GiveBook()
        {
            InitializeComponent();
        }

        private void GiveBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbLibraryDataSet1.bilet". При необходимости она может быть перемещена или удалена.
            gridLibrary.DataSource = Manager.GetEntities().Books.Where(n=> n.took==true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList();
            gridAccount.DataSource = Manager.GetEntities().bilet.Select(n => new { n.biletId, n.name, n.surname, n.patronymic, n.passwords, n.numberTelephone }).ToList();
            dataGridSdanBook.DataSource= Manager.GetEntities().manInfo.Select(n => new {n.booksId,n.Books.namebook, n.Books.genre ,n.biletId, n.bilet.name, n.bilet.surname, n.bilet.patronymic, n.bilet.numberTelephone, n.dateTook}).ToList();
            dataGridSdanBook.AutoGenerateColumns = false;
            //gridAccount.DataSource = Manager.GetEntities().manInfo.Select(n => new { n.booksId, n.dateTook, bilet.id }).ToList();
            //gridAccount.Columns[0].HeaderText = "ID";
            //gridAccount.Columns[1].HeaderText = "Имя";
            //gridAccount.Columns[2].HeaderText = "Фамилия";
            //gridAccount.Columns[3].HeaderText = "Отчество";
            //gridAccount.Columns[4].HeaderText = "Номер телефона";
            //gridAccount.Columns[5].HeaderText = "Пароль";






        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Выбрать пользователя?", "Выдача книги", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                var cells = gridAccount.SelectedRows[0].Cells[0].Value.ToString(); //ячейка текущей выделенной строки
                                                                                   //Manager.GetEntities().bilet.Remove(Manager.GetEntities().bilet.FirstOrDefault(q => q.biletId.ToString() == cells)); //проверка booksid равен, соответсвует параметрам

                Manager.GetEntities().manInfo.Add(new manInfo
                {
                    biletId = Convert.ToInt32(cells),
                    dateTook = DateTime.Today,
                    
                }) ;
                Manager.GetEntities().SaveChanges();





                gridAccount.DataSource = Manager.GetEntities().bilet.Select(n => new { n.biletId, n.name, n.surname, n.patronymic, n.passwords, n.numberTelephone }).ToList(); ;
                //gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                MessageBox.Show("Пользователь выбран");
                button1.Visible = false;
                gridAccount.Visible = false;
                button2Book.Visible = true;
                gridLibrary.Visible = true;
                dataGridSdanBook.Visible = false;



            }




        }



        private void gridLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2Book_Click(object sender, EventArgs e) //взял книгу
        {
            var lastManInfo = Manager.GetEntities().manInfo.ToList().Last();
            var a = MessageBox.Show("Выбрать книгу?", "Выдача книги", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                var cells = gridLibrary.SelectedRows[0].Cells[0].Value.ToString(); //ячейка текущей выделенной строки
                                                                                   //Manager.GetEntities().bilet.Remove(Manager.GetEntities().bilet.FirstOrDefault(q => q.biletId.ToString() == cells)); //проверка booksid равен, соответсвует параметрам
                var intCells = Convert.ToInt32(cells);
                var Books = Manager.GetEntities().Books.FirstOrDefault(n => n.booksId == intCells);
                Books.took = false;
                
                lastManInfo.booksId = Convert.ToInt32(cells);
                Manager.GetEntities().SaveChanges();

                gridAccount.DataSource = Manager.GetEntities().bilet.Select(n => new { n.biletId, n.name, n.surname, n.patronymic, n.passwords, n.numberTelephone }).ToList(); ;
                //gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                MessageBox.Show("Книга выбрана");
                gridLibrary.Visible = false;
                button2Book.Visible = false;

                nachaloSdBtn.Visible = true;
                GaveBookBtn.Visible = true;
                sdanBookBtn.Visible = true;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridSdanBook.Visible = true;
            buttonExport.Visible = true;
        }

        private void dataGridSdanBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridSdanBook.Visible = true;
        }

        private void nachaloSdBtn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            gridAccount.Visible = true;
            nachaloSdBtn.Visible = false;
            GaveBookBtn.Visible = false;
            sdanBookBtn.Visible = false;
            dataGridSdanBook.Visible = false;


        }

        private void GaveBookBtn_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            dataGridSdanBook.Visible = true;
            sdanBookBtn.Visible = false;
            nachaloSdBtn.Visible = false;
            GaveBookBtn.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e) //отдал книгу
        {
            var a = MessageBox.Show("Сдать книгу?", "Сдача книги", MessageBoxButtons.YesNo);
            try
            {
                if (a == DialogResult.Yes)
                {
                    var cells = dataGridSdanBook.SelectedRows[0].Cells[0].Value.ToString(); //ячейка текущей выделенной строки
                    Manager.GetEntities().manInfo.Remove(Manager.GetEntities().manInfo.FirstOrDefault(n => n.booksId.ToString() == cells)); //проверка booksid равен, соответсвует параметрам


                    Manager.GetEntities().SaveChanges();
                    dataGridSdanBook.DataSource = Manager.GetEntities().manInfo.Select(n => new { n.booksId, n.Books.namebook, n.Books.genre, n.biletId, n.bilet.name, n.bilet.surname, n.bilet.patronymic, n.bilet.numberTelephone, n.dateTook, n.dateGave }).ToList();
                    //gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                    MessageBox.Show("Книга сдана");
                }
            }
            catch
            {
                MessageBox.Show("Отменено");
            }
            button1.Visible = false;
                gridAccount.Visible = false;
                button2Book.Visible = true;
                gridLibrary.Visible = true;
                dataGridSdanBook.Visible = false;



            }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridSdanBook.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridSdanBook.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = dataGridSdanBook.Columns[j].HeaderText.ToString();
                    wsh.Cells[i + 2, j + 1] = dataGridSdanBook[j, i].Value.ToString();

                }
            }
            exApp.Visible = true;
        }
    }
    }
    



//Форма выбора пользователя
//Делаешь нажатие на пользователя в гриде
//Запоминаешь его ID в Manager.userId
//Показываешь грид с книгами
//Делаешь проверку значение Manager.userId на -1 
//Если оно = - 1 то тогда ничего не делаем
//Если оно >=0 то тогда выводим сообщение в котором спрашиваем хотим ли мы дать юзеру книгу
//Если он ответит да, тто мы Добавляем книгу в таблицу а затем Manager.UserId меняем на -1
//Если ответ нет то //Если оно = - 1 то тогда ничего не делаем
//Если оно >=0 то тогда выводим сообщение в котором спрашиваем хотим ли мы дать юзеру книгу