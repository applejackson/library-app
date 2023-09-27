
namespace LibraryPri
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ReaderBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ReaderBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 589);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonReg
            // 
            this.buttonReg.CausesValidation = false;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("TT Travels Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(-5, 409);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(376, 94);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TT Travels Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-5, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "Войти как библиотекарь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReaderBtn
            // 
            this.ReaderBtn.CausesValidation = false;
            this.ReaderBtn.FlatAppearance.BorderSize = 0;
            this.ReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderBtn.Font = new System.Drawing.Font("TT Travels Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderBtn.ForeColor = System.Drawing.Color.White;
            this.ReaderBtn.Location = new System.Drawing.Point(-5, 69);
            this.ReaderBtn.Name = "ReaderBtn";
            this.ReaderBtn.Size = new System.Drawing.Size(376, 93);
            this.ReaderBtn.TabIndex = 0;
            this.ReaderBtn.Text = "Войти как \r\nчитатель";
            this.ReaderBtn.UseVisualStyleBackColor = true;
            this.ReaderBtn.Click += new System.EventHandler(this.Reader_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(67, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 487);
            this.panel2.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.ActiveImage = null;
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowBuffering = false;
            this.btnExit.AllowToggling = false;
            this.btnExit.AllowZooming = true;
            this.btnExit.AllowZoomingOnFocus = false;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImage")));
            this.btnExit.FadeWhenInactive = false;
            this.btnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.ImageLocation = null;
            this.btnExit.ImageMargin = 30;
            this.btnExit.ImageSize = new System.Drawing.Size(27, 23);
            this.btnExit.ImageZoomSize = new System.Drawing.Size(57, 53);
            this.btnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExit.InitialImage")));
            this.btnExit.Location = new System.Drawing.Point(766, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0;
            this.btnExit.ShowActiveImage = true;
            this.btnExit.ShowCursorChanges = true;
            this.btnExit.ShowImageBorders = true;
            this.btnExit.ShowSizeMarkers = false;
            this.btnExit.Size = new System.Drawing.Size(57, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.ToolTipText = "";
            this.btnExit.WaitOnLoad = false;
            this.btnExit.Zoom = 30;
            this.btnExit.ZoomSpeed = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryPri.Properties.Resources.library;
            this.pictureBox1.Location = new System.Drawing.Point(377, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 589);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("TT Travels Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(91, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(198, 32);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "BoikoLibrary";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 589);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ReaderBtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnExit;
        private System.Windows.Forms.Label lblWelcome;
    }
}

