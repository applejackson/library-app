using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryPri
{
    public partial class AccountReader : Form
    {
        public AccountReader()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbLibraryDataSet2.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.dbLibraryDataSet2.Books);
            gridLibrary.DataSource = Manager.GetEntities().Books.Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).ToList();
            gridLibrary.AutoGenerateColumns = false;

            gridLibrary.Columns[0].HeaderText = "ID";
            gridLibrary.Columns[1].HeaderText = "ФИО автора";
            gridLibrary.Columns[2].HeaderText = "Название книги";
            gridLibrary.Columns[3].HeaderText = "Жанр";
            gridLibrary.Columns[4].HeaderText = "Издатель";
            gridLibrary.Columns[5].HeaderText = "Обложка";
            gridLibrary.Columns[6].HeaderText = "Страницы";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            takeBook form7 = new takeBook();
            form7.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterBox.Text == "Страницы")
                gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages }).OrderBy(n => n.pages).ToList();

            if (FilterBox.Text == "ID")
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

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            gridLibrary.DataSource = Manager.GetEntities().Books.Where(n => n.took == true).Select(n => new { n.booksId, n.FIO, n.namebook, n.genre, n.publisher, n.obloshka, n.pages })
               .Where(n => n.namebook.Contains(txtBoxSearch.Text) ||
               n.booksId.ToString().Contains(txtBoxSearch.Text) ||
               n.namebook.Contains(txtBoxSearch.Text) ||
               n.FIO.Contains(txtBoxSearch.Text) ||
               n.publisher.Contains(txtBoxSearch.Text) ||
               n.obloshka.Contains(txtBoxSearch.Text) ||
               n.pages.ToString().Contains(txtBoxSearch.Text)).ToList();
        }
    }
}
