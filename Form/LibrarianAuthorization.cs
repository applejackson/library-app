﻿using System;
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
    public partial class LibrarianAuthorization : Form
    {
        public LibrarianAuthorization()
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
            if (textBoxL.Text == "admin" && textBoxPassword.Text == "admin")
            {
                LibrarianAccount form6 = new LibrarianAccount();
                form6.Show();
                this.Hide();
            }
            
            else
            {
                NoLabel.Visible = true;
            }
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
        }

        private void NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
