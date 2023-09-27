
namespace LibraryPri
{
    partial class RegistrationBook
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.txtBoxNamebook = new System.Windows.Forms.TextBox();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.txtBoxPages = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnRegistr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbLibraryDataSet3 = new LibraryPri.dbLibraryDataSet3();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibraryPri.dbLibraryDataSet3TableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО автора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Жанр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Издатель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Обложка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Страницы";
            // 
            // txtBoxID
            // 
            this.txtBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxID.Location = new System.Drawing.Point(265, 48);
            this.txtBoxID.Multiline = true;
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(224, 31);
            this.txtBoxID.TabIndex = 10;
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxFIO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFIO.Location = new System.Drawing.Point(265, 117);
            this.txtBoxFIO.Multiline = true;
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(224, 31);
            this.txtBoxFIO.TabIndex = 11;
            // 
            // txtBoxNamebook
            // 
            this.txtBoxNamebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxNamebook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxNamebook.Location = new System.Drawing.Point(265, 197);
            this.txtBoxNamebook.Multiline = true;
            this.txtBoxNamebook.Name = "txtBoxNamebook";
            this.txtBoxNamebook.Size = new System.Drawing.Size(224, 31);
            this.txtBoxNamebook.TabIndex = 12;
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxGenre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxGenre.Location = new System.Drawing.Point(265, 272);
            this.txtBoxGenre.Multiline = true;
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(224, 31);
            this.txtBoxGenre.TabIndex = 13;
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxPublisher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPublisher.Location = new System.Drawing.Point(265, 340);
            this.txtBoxPublisher.Multiline = true;
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(224, 31);
            this.txtBoxPublisher.TabIndex = 14;
            // 
            // txtBoxPages
            // 
            this.txtBoxPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxPages.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPages.Location = new System.Drawing.Point(265, 489);
            this.txtBoxPages.Multiline = true;
            this.txtBoxPages.Name = "txtBoxPages";
            this.txtBoxPages.Size = new System.Drawing.Size(224, 31);
            this.txtBoxPages.TabIndex = 16;
            this.txtBoxPages.TextChanged += new System.EventHandler(this.txtBoxPages_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(484, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegistr
            // 
            this.btnRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistr.FlatAppearance.BorderSize = 0;
            this.btnRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistr.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.btnRegistr.Location = new System.Drawing.Point(114, 560);
            this.btnRegistr.Name = "btnRegistr";
            this.btnRegistr.Size = new System.Drawing.Size(273, 35);
            this.btnRegistr.TabIndex = 18;
            this.btnRegistr.Text = "Добавить";
            this.btnRegistr.UseVisualStyleBackColor = false;
            this.btnRegistr.Click += new System.EventHandler(this.btnRegistr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Твердая глянцевая",
            "Мягкая глянцевая",
            "Твердая бумажная",
            "Мягкая бумажная",
            "Картон",
            "Суперобложка"});
            this.comboBox1.Location = new System.Drawing.Point(265, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 30);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dbLibraryDataSet3
            // 
            this.dbLibraryDataSet3.DataSetName = "dbLibraryDataSet3";
            this.dbLibraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dbLibraryDataSet3;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // RegistrationBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(523, 633);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRegistr);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBoxPages);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.txtBoxGenre);
            this.Controls.Add(this.txtBoxNamebook);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationBook";
            this.Load += new System.EventHandler(this.RegistrationBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.TextBox txtBoxNamebook;
        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.TextBox txtBoxPages;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.ComboBox comboBox1;
        private dbLibraryDataSet3 dbLibraryDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private dbLibraryDataSet3TableAdapters.BooksTableAdapter booksTableAdapter;
    }
}