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

namespace LibraryPri
{
    public partial class VhodUser : Form
    {
        public VhodUser()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                   //перенос формы
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            var telephoneUser = textBoxTelephone.Text;
            var pasUser = textBoxPassword.Text;

            var user = Manager.GetEntities().bilet.FirstOrDefault(n => n.numberTelephone == telephoneUser && n.passwords == pasUser);
            if (user != null)
            {
                AccountReader form4 = new AccountReader();
                form4.Show();
                this.Hide();
            }
            else
            {
                NoLabel.Visible = true;
            }

            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    DataTable table = new DataTable();

            //    string querystring = $"select biletId, name, surname, patronymic, numberTelephone, passwords from bilet where numberTelephone='{telephoneUser}' and passwords= '{pasUser}' ";
            //    SqlCommand command = new SqlCommand(querystring, database.getConnection());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationUsers form2 = new RegistrationUsers();
            form2.Show();
            this.Hide();
        }

        private void Vhod_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
        }


        private void NoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
