using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace LibraryPri
{
    public partial class LibrarianAccount : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public LibrarianAccount()
        {
            InitializeComponent();
            gridAccount.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 16);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                   //перенос формы
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

        private void LibrarianWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbLibraryDataSet3.Books". При необходимости она может быть перемещена или удалена.
            //this.booksTableAdapter.Fill(this.dbLibraryDataSet3.Books);
            gridLibrary.DataSource = Manager.GetEntities().Books.Select(n=> new {n.booksId, n.FIO, n.namebook, n.genre,n.publisher,n.obloshka,n.pages}).ToList();
            gridLibrary.AutoGenerateColumns = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbLibraryDataSet1.bilet". При необходимости она может быть перемещена или удалена.
            this.biletTableAdapter.Fill(this.dbLibraryDataSet1.bilet);

            gridLibrary.Columns[0].HeaderText = "ID";
            gridLibrary.Columns[1].HeaderText = "ФИО автора";
            gridLibrary.Columns[2].HeaderText = "Название книги";
            gridLibrary.Columns[3].HeaderText = "Жанр";
            gridLibrary.Columns[4].HeaderText = "Издатель";
            gridLibrary.Columns[5].HeaderText = "Обложка";
            gridLibrary.Columns[6].HeaderText = "Страницы";

            gridAccount.Columns[0].HeaderText = "ID";
            gridAccount.Columns[1].HeaderText = "Имя";
            gridAccount.Columns[2].HeaderText = "Фамилия";
            gridAccount.Columns[3].HeaderText = "Отчество";
            gridAccount.Columns[4].HeaderText = "Номер телефона";
            gridAccount.Columns[5].HeaderText = "Пароль";


            ToolTip t = new ToolTip();
            t.SetToolTip(btnListAccount, "Аккаунты пользователей");

            ToolTip с = new ToolTip();
            с.SetToolTip(btnListBooks, "Книги");

            ToolTip a = new ToolTip();
            a.SetToolTip(btndeleteBooks, "Удаление книги");

            ToolTip b = new ToolTip();
            b.SetToolTip(btnAddBooks, "Добавить книгу");

            ToolTip h = new ToolTip();
            h.SetToolTip(bunifuImageButton1, "Выдать/сдать книгу");







        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            gridAccount.Visible = true;
            gridLibrary.Visible = false;
            FilterBox.Visible = false;
            txtBoxSearch.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            gridLibrary.Visible = true;
                gridAccount.Visible = false;
            FilterBox.Visible = true;
            txtBoxSearch.Visible = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            RegistrationBook form7 = new RegistrationBook();
            form7.Show();
        }

        private void gridLibrary_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(gridLibrary.SelectedRows[0].Cells[0].Value.ToString());
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Удалить элемент?", "Удаление книги", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                var cells = gridLibrary.SelectedRows[0].Cells[0].Value.ToString();
                Manager.GetEntities().Books.Remove(Manager.GetEntities().Books.FirstOrDefault(q => q.booksId.ToString() == cells));
                Manager.GetEntities().SaveChanges();
                gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                MessageBox.Show("Удаление завершено");
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }

        }

        private void gridLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.gridLibrary.Sort(this.gridLibrary.Columns[], ListSortDirection.Ascending);
        }

        private void gridLibrary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e) //фильтрация в боксе
        {
            if(FilterBox.Text == "Страницы")
            gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n=> new {n.booksId, n.FIO, n.namebook, n.genre,n.publisher,n.obloshka,n.pages}).OrderBy(n=> n.pages).ToList();
            
            if(FilterBox.Text == "ID")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.booksId).ToList();

            if (FilterBox.Text == "ФИО автора")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.FIO).ToList();

            if (FilterBox.Text == "Жанр")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.genre).ToList();

            if (FilterBox.Text == "Издатель")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.publisher).ToList();

            if (FilterBox.Text == "Обложка")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.namebook).ToList();

            if (FilterBox.Text == "Название книги")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.namebook).ToList();

        }

        private void Search(DataGridView gridLibrary)
        {
            //gridLibrary.Rows.Clear();
            //string searchString = $"select *from dbLibrary where concat (booksid, FIO, namebook, genre, publisher, obloshka, pages) like '%"+txtBoxSearch.Text+"%'";

            //SqlCommand com = new SqlCommand(searchString, dbLibra.getConnection());

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            gridLibrary.DataSource = Manager.GetEntities().Books.Where(n=>n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages })
                .Where(n => n.namebook.Contains(txtBoxSearch.Text)||
                n.booksId.ToString().Contains(txtBoxSearch.Text)||
                n.namebook.Contains(txtBoxSearch.Text)||
                n.FIO.Contains(txtBoxSearch.Text)||
                n.publisher.Contains(txtBoxSearch.Text)||
                n.obloshka.Contains(txtBoxSearch.Text) ||
                n.pages.ToString().Contains(txtBoxSearch.Text)).ToList();

        }

        private void gridLibrary_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnListAccount_Click(object sender, EventArgs e)
        {
           
            gridAccount.Visible = true;
            gridLibrary.Visible = false;
            FilterBox.Visible = false;
            txtBoxSearch.Visible = false;
            lblWelcome.Visible = false;
            lblWelcome2.Visible = false;
            lblWelcome3.Visible = false;
            txtBoxSerachAccount.Visible = true;



        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
           
            gridLibrary.Visible = true;
            gridAccount.Visible = false;
            FilterBox.Visible = true;
            txtBoxSearch.Visible = true;

            lblWelcome.Visible = false;
            lblWelcome2.Visible = false;
            lblWelcome3.Visible = false;
            txtBoxSerachAccount.Visible = false;
        }

        private void btndeleteBooks_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Удалить элемент?", "Удаление", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                var cells = gridLibrary.SelectedRows[0].Cells[0].Value.ToString(); //ячейка текущей выделенной строки
                Manager.GetEntities().manInfo.Remove(Manager.GetEntities().manInfo.FirstOrDefault(q => q.booksId.ToString() == cells)); //проверка booksid равен, соответсвует параметрам
                var intCells = Convert.ToInt32(cells);
                var Books = Manager.GetEntities().Books.FirstOrDefault(n => n.booksId == intCells);
                Books.took = true;
                Manager.GetEntities().SaveChanges();
                gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                //gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList(); ;
                MessageBox.Show("Удаление завершено");
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }


        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            RegistrationBook form7 = new RegistrationBook();
            form7.Show();
            lblWelcome.Visible = false;
            lblWelcome2.Visible = false;
            lblWelcome3.Visible = false;
            txtBoxSerachAccount.Visible = false;

        }

        private void btnGiveBook_Click(object sender, EventArgs e)
        {
           GiveBook form9 = new GiveBook();
           form9.Show();
          
           /* var a = Manager.GetEntities().Books.FirstOrDefault(q => q.booksId.ToString() == "4343");
            a.took = false;
            Manager.GetEntities().manInfo.Add( new manInfo
            {
                biletId = 123,
                booksId = 123,
                dateGave = DateTime.Now,
                dateTook = null
            });
            Manager.GetEntities().SaveChanges();*/
        }

        private void gridAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            GiveBook form9 = new GiveBook();
            form9.Show();
        }

        private void txtBoxSerachAccount_TextChanged(object sender, EventArgs e)
        {
            gridAccount.DataSource = Manager.GetEntities().bilet.Select(n => new { n.biletId, n.name, n.surname, n.patronymic, n.numberTelephone, n.passwords })
                .Where(n => n.name.Contains(txtBoxSerachAccount.Text) ||
                n.biletId.ToString().Contains(txtBoxSerachAccount.Text) ||
                n.surname.Contains(txtBoxSerachAccount.Text) ||
                n.patronymic.Contains(txtBoxSerachAccount.Text) ||
                n.numberTelephone.Contains(txtBoxSerachAccount.Text) ||
                n.passwords.Contains(txtBoxSerachAccount.Text)).ToList();
        }
    }
}



