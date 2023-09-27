using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryPri
{
    public partial class RegistrationBook : Form
    {
        public RegistrationBook()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                   //перенос формы
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            if (Manager.GetEntities().Author.FirstOrDefault(n => n.FIO == txtBoxFIO.Text.ToString()) == null) //поиск совпадающих элементов, проверка существования автора с такой фамилией
            {
                Manager.GetEntities().Author.Add(new Author { FIO = Convert.ToString(txtBoxFIO.Text) });
            }
            Manager.GetEntities().Books.Add(new Books { booksId = Convert.ToInt32(txtBoxID.Text), FIO = Convert.ToString(txtBoxFIO.Text), namebook = Convert.ToString(txtBoxNamebook.Text), genre = Convert.ToString(txtBoxGenre.Text), publisher = Convert.ToString(txtBoxPublisher.Text), obloshka = Convert.ToString(comboBox1.Text), pages = Convert.ToString(txtBoxPages.Text), took = true }); ;
            Manager.GetEntities().SaveChanges();
            //dbLibraryEntities.Books.Add(new Books{ booksId = Convert.ToInt32(txtBoxID.Text)});
            MessageBox.Show("Успешно зарегистрировано");
            this.Close();
        }

        private void RegistrationBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbLibraryDataSet3.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dbLibraryDataSet3.Books);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
