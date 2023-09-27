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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();



        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reader_Click(object sender, EventArgs e)
        {
            VhodUser form3 = new VhodUser();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrationUsers form2 = new RegistrationUsers();
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianAuthorization form5 = new LibrarianAuthorization();
            form5.Show();
            this.Hide();
        }
    }
}
