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
    public partial class RegistrationUsers : Form
    {
        public RegistrationUsers()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                   //перенос формы
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.GetEntities().bilet.Add(new bilet
            {
                name = textBoxName.Text,
                surname = textBoxUsname.Text,
                patronymic = textBoxOthcestvo.Text,
                numberTelephone = textBoxTelephone.Text,
                passwords = textBoxPassword.Text
            });
            Manager.GetEntities().SaveChanges();
            MessageBox.Show("Ваш читательский билет зарегистрирован", "Все прошло успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxPassword.MaxLength = 10;
            textBoxTelephone.MaxLength = 12;
        }
    }
}
