
namespace LibraryPri
{
    partial class LibrarianAuthorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.NoLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // NoLabel
            // 
            this.NoLabel.AutoSize = true;
            this.NoLabel.Font = new System.Drawing.Font("TT Travels Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoLabel.ForeColor = System.Drawing.Color.Red;
            this.NoLabel.Location = new System.Drawing.Point(70, 196);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(391, 29);
            this.NoLabel.TabIndex = 14;
            this.NoLabel.Text = "Данные введены неправильно";
            this.NoLabel.Visible = false;
            this.NoLabel.Click += new System.EventHandler(this.NoLabel_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(225, 110);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 27);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textBoxL
            // 
            this.textBoxL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBoxL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.Location = new System.Drawing.Point(225, 54);
            this.textBoxL.Multiline = true;
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(224, 29);
            this.textBoxL.TabIndex = 11;
            this.textBoxL.TextChanged += new System.EventHandler(this.textBoxL_TextChanged);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.buttonRegistration.Location = new System.Drawing.Point(171, 248);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(179, 35);
            this.buttonRegistration.TabIndex = 10;
            this.buttonRegistration.Text = "Войти";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // buttonBackMenu
            // 
            this.buttonBackMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBackMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackMenu.Font = new System.Drawing.Font("TT Travels Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackMenu.Location = new System.Drawing.Point(171, 305);
            this.buttonBackMenu.Name = "buttonBackMenu";
            this.buttonBackMenu.Size = new System.Drawing.Size(179, 32);
            this.buttonBackMenu.TabIndex = 16;
            this.buttonBackMenu.Text = "Назад";
            this.buttonBackMenu.UseVisualStyleBackColor = false;
            this.buttonBackMenu.Click += new System.EventHandler(this.buttonBackMenu_Click);
            // 
            // LibrarianAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.buttonBackMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarianAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Librarian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackMenu;
    }
}