
namespace LibraryPri
{
    partial class LibrarianAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianAccount));
            this.dbLibraryDataSet = new LibraryPri.dbLibraryDataSet();
            this.gridAccount = new System.Windows.Forms.DataGridView();
            this.biletIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLibraryDataSet1 = new LibraryPri.dbLibraryDataSet1();
            this.biletTableAdapter = new LibraryPri.dbLibraryDataSet1TableAdapters.biletTableAdapter();
            this.brnAccount = new System.Windows.Forms.Button();
            this.libraryBooks = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.gridLibrary = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLibraryDataSet3 = new LibraryPri.dbLibraryDataSet3();
            this.booksTableAdapter = new LibraryPri.dbLibraryDataSet3TableAdapters.BooksTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.lblWelcome3 = new System.Windows.Forms.Label();
            this.btnGiveBook = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.btnAddBooks = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btndeleteBooks = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnListBooks = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnListAccount = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtBoxSerachAccount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet3)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbLibraryDataSet
            // 
            this.dbLibraryDataSet.DataSetName = "dbLibraryDataSet";
            this.dbLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridAccount
            // 
            this.gridAccount.AllowUserToAddRows = false;
            this.gridAccount.AllowUserToDeleteRows = false;
            this.gridAccount.AllowUserToResizeColumns = false;
            this.gridAccount.AllowUserToResizeRows = false;
            this.gridAccount.AutoGenerateColumns = false;
            this.gridAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.gridAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAccount.ColumnHeadersHeight = 60;
            this.gridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.biletIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.numberTelephoneDataGridViewTextBoxColumn,
            this.passwordsDataGridViewTextBoxColumn});
            this.gridAccount.DataSource = this.biletBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAccount.EnableHeadersVisualStyles = false;
            this.gridAccount.Location = new System.Drawing.Point(363, 95);
            this.gridAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAccount.RowHeadersVisible = false;
            this.gridAccount.RowHeadersWidth = 51;
            this.gridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccount.Size = new System.Drawing.Size(1304, 767);
            this.gridAccount.TabIndex = 1;
            this.gridAccount.Visible = false;
            this.gridAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccount_CellContentClick);
            // 
            // biletIdDataGridViewTextBoxColumn
            // 
            this.biletIdDataGridViewTextBoxColumn.DataPropertyName = "biletId";
            this.biletIdDataGridViewTextBoxColumn.HeaderText = "biletId";
            this.biletIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biletIdDataGridViewTextBoxColumn.Name = "biletIdDataGridViewTextBoxColumn";
            this.biletIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberTelephoneDataGridViewTextBoxColumn
            // 
            this.numberTelephoneDataGridViewTextBoxColumn.DataPropertyName = "numberTelephone";
            this.numberTelephoneDataGridViewTextBoxColumn.HeaderText = "numberTelephone";
            this.numberTelephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberTelephoneDataGridViewTextBoxColumn.Name = "numberTelephoneDataGridViewTextBoxColumn";
            this.numberTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordsDataGridViewTextBoxColumn
            // 
            this.passwordsDataGridViewTextBoxColumn.DataPropertyName = "passwords";
            this.passwordsDataGridViewTextBoxColumn.HeaderText = "passwords";
            this.passwordsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordsDataGridViewTextBoxColumn.Name = "passwordsDataGridViewTextBoxColumn";
            this.passwordsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biletBindingSource
            // 
            this.biletBindingSource.DataMember = "bilet";
            this.biletBindingSource.DataSource = this.dbLibraryDataSet1;
            // 
            // dbLibraryDataSet1
            // 
            this.dbLibraryDataSet1.DataSetName = "dbLibraryDataSet1";
            this.dbLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletTableAdapter
            // 
            this.biletTableAdapter.ClearBeforeFill = true;
            // 
            // brnAccount
            // 
            this.brnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.brnAccount.FlatAppearance.BorderSize = 0;
            this.brnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAccount.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.brnAccount.Location = new System.Drawing.Point(16, 108);
            this.brnAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnAccount.Name = "brnAccount";
            this.brnAccount.Size = new System.Drawing.Size(301, 79);
            this.brnAccount.TabIndex = 11;
            this.brnAccount.Text = "Посмотреть список аккаунтов";
            this.brnAccount.UseVisualStyleBackColor = false;
            this.brnAccount.Visible = false;
            this.brnAccount.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // libraryBooks
            // 
            this.libraryBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.libraryBooks.FlatAppearance.BorderSize = 0;
            this.libraryBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryBooks.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.libraryBooks.Location = new System.Drawing.Point(23, 251);
            this.libraryBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libraryBooks.Name = "libraryBooks";
            this.libraryBooks.Size = new System.Drawing.Size(295, 80);
            this.libraryBooks.TabIndex = 12;
            this.libraryBooks.Text = "Посмотреть список книг";
            this.libraryBooks.UseVisualStyleBackColor = false;
            this.libraryBooks.Visible = false;
            this.libraryBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.btnAddBook.Location = new System.Drawing.Point(28, 544);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(301, 76);
            this.btnAddBook.TabIndex = 13;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // gridLibrary
            // 
            this.gridLibrary.AllowDrop = true;
            this.gridLibrary.AllowUserToOrderColumns = true;
            this.gridLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLibrary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.gridLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLibrary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridLibrary.ColumnHeadersHeight = 60;
            this.gridLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLibrary.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridLibrary.EnableHeadersVisualStyles = false;
            this.gridLibrary.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.gridLibrary.Location = new System.Drawing.Point(325, 95);
            this.gridLibrary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridLibrary.MultiSelect = false;
            this.gridLibrary.Name = "gridLibrary";
            this.gridLibrary.ReadOnly = true;
            this.gridLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLibrary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridLibrary.RowHeadersVisible = false;
            this.gridLibrary.RowHeadersWidth = 51;
            this.gridLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLibrary.Size = new System.Drawing.Size(1309, 789);
            this.gridLibrary.TabIndex = 14;
            this.gridLibrary.Visible = false;
            this.gridLibrary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLibrary_CellContentClick);
            this.gridLibrary.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLibrary_ColumnHeaderMouseClick);
            this.gridLibrary.SelectionChanged += new System.EventHandler(this.gridLibrary_SelectionChanged);
            this.gridLibrary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridLibrary_MouseMove);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dbLibraryDataSet3;
            // 
            // dbLibraryDataSet3
            // 
            this.dbLibraryDataSet3.DataSetName = "dbLibraryDataSet3";
            this.dbLibraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.btnBack.Location = new System.Drawing.Point(55, 791);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(239, 57);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.button1.Location = new System.Drawing.Point(23, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("TT Travels DemiBold", 50F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(411, 159);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(334, 101);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Добро";
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.Font = new System.Drawing.Font("TT Travels DemiBold", 50F, System.Drawing.FontStyle.Bold);
            this.lblWelcome2.ForeColor = System.Drawing.Color.White;
            this.lblWelcome2.Location = new System.Drawing.Point(524, 357);
            this.lblWelcome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(579, 101);
            this.lblWelcome2.TabIndex = 23;
            this.lblWelcome2.Text = "пожаловать";
            // 
            // lblWelcome3
            // 
            this.lblWelcome3.AutoSize = true;
            this.lblWelcome3.Font = new System.Drawing.Font("TT Travels DemiBold", 50F, System.Drawing.FontStyle.Bold);
            this.lblWelcome3.ForeColor = System.Drawing.Color.White;
            this.lblWelcome3.Location = new System.Drawing.Point(869, 567);
            this.lblWelcome3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome3.Name = "lblWelcome3";
            this.lblWelcome3.Size = new System.Drawing.Size(627, 101);
            this.lblWelcome3.TabIndex = 24;
            this.lblWelcome3.Text = "в программу ";
            // 
            // btnGiveBook
            // 
            this.btnGiveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGiveBook.FlatAppearance.BorderSize = 0;
            this.btnGiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveBook.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.btnGiveBook.Location = new System.Drawing.Point(28, 676);
            this.btnGiveBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiveBook.Name = "btnGiveBook";
            this.btnGiveBook.Size = new System.Drawing.Size(301, 76);
            this.btnGiveBook.TabIndex = 26;
            this.btnGiveBook.Text = "Выдача и сдача книг";
            this.btnGiveBook.UseVisualStyleBackColor = false;
            this.btnGiveBook.Visible = false;
            this.btnGiveBook.Click += new System.EventHandler(this.btnGiveBook_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSearch.Location = new System.Drawing.Point(689, 60);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(297, 30);
            this.txtBoxSearch.TabIndex = 21;
            this.txtBoxSearch.Visible = false;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FilterBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Items.AddRange(new object[] {
            "ID",
            "ФИО автора",
            "Название книги",
            "Жанр",
            "Издатель",
            "Обложка",
            "Страницы"});
            this.FilterBox.Location = new System.Drawing.Point(363, 60);
            this.FilterBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(297, 38);
            this.FilterBox.TabIndex = 20;
            this.FilterBox.Visible = false;
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.ActiveImage = null;
            this.btnAddBooks.AllowAnimations = true;
            this.btnAddBooks.AllowBuffering = false;
            this.btnAddBooks.AllowToggling = false;
            this.btnAddBooks.AllowZooming = true;
            this.btnAddBooks.AllowZoomingOnFocus = false;
            this.btnAddBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBooks.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.ErrorImage")));
            this.btnAddBooks.FadeWhenInactive = false;
            this.btnAddBooks.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.Image")));
            this.btnAddBooks.ImageActive = null;
            this.btnAddBooks.ImageLocation = null;
            this.btnAddBooks.ImageMargin = 10;
            this.btnAddBooks.ImageSize = new System.Drawing.Size(110, 101);
            this.btnAddBooks.ImageZoomSize = new System.Drawing.Size(120, 111);
            this.btnAddBooks.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddBooks.InitialImage")));
            this.btnAddBooks.Location = new System.Drawing.Point(107, 521);
            this.btnAddBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Rotation = 0;
            this.btnAddBooks.ShowActiveImage = true;
            this.btnAddBooks.ShowCursorChanges = true;
            this.btnAddBooks.ShowImageBorders = true;
            this.btnAddBooks.ShowSizeMarkers = false;
            this.btnAddBooks.Size = new System.Drawing.Size(120, 111);
            this.btnAddBooks.TabIndex = 21;
            this.btnAddBooks.ToolTipText = "";
            this.btnAddBooks.WaitOnLoad = false;
            this.btnAddBooks.Zoom = 10;
            this.btnAddBooks.ZoomSpeed = 10;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btndeleteBooks
            // 
            this.btndeleteBooks.ActiveImage = null;
            this.btndeleteBooks.AllowAnimations = true;
            this.btndeleteBooks.AllowBuffering = false;
            this.btndeleteBooks.AllowToggling = false;
            this.btndeleteBooks.AllowZooming = true;
            this.btndeleteBooks.AllowZoomingOnFocus = false;
            this.btndeleteBooks.BackColor = System.Drawing.Color.Transparent;
            this.btndeleteBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndeleteBooks.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btndeleteBooks.ErrorImage")));
            this.btndeleteBooks.FadeWhenInactive = false;
            this.btndeleteBooks.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btndeleteBooks.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteBooks.Image")));
            this.btndeleteBooks.ImageActive = null;
            this.btndeleteBooks.ImageLocation = null;
            this.btndeleteBooks.ImageMargin = 10;
            this.btndeleteBooks.ImageSize = new System.Drawing.Size(110, 101);
            this.btndeleteBooks.ImageZoomSize = new System.Drawing.Size(120, 111);
            this.btndeleteBooks.InitialImage = ((System.Drawing.Image)(resources.GetObject("btndeleteBooks.InitialImage")));
            this.btndeleteBooks.Location = new System.Drawing.Point(107, 375);
            this.btndeleteBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndeleteBooks.Name = "btndeleteBooks";
            this.btndeleteBooks.Rotation = 0;
            this.btndeleteBooks.ShowActiveImage = true;
            this.btndeleteBooks.ShowCursorChanges = true;
            this.btndeleteBooks.ShowImageBorders = true;
            this.btndeleteBooks.ShowSizeMarkers = false;
            this.btndeleteBooks.Size = new System.Drawing.Size(120, 111);
            this.btndeleteBooks.TabIndex = 20;
            this.btndeleteBooks.ToolTipText = "";
            this.btndeleteBooks.WaitOnLoad = false;
            this.btndeleteBooks.Zoom = 10;
            this.btndeleteBooks.ZoomSpeed = 10;
            this.btndeleteBooks.Click += new System.EventHandler(this.btndeleteBooks_Click);
            // 
            // btnListBooks
            // 
            this.btnListBooks.ActiveImage = null;
            this.btnListBooks.AllowAnimations = true;
            this.btnListBooks.AllowBuffering = false;
            this.btnListBooks.AllowToggling = false;
            this.btnListBooks.AllowZooming = true;
            this.btnListBooks.AllowZoomingOnFocus = false;
            this.btnListBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnListBooks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListBooks.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnListBooks.ErrorImage")));
            this.btnListBooks.FadeWhenInactive = false;
            this.btnListBooks.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnListBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnListBooks.Image")));
            this.btnListBooks.ImageActive = null;
            this.btnListBooks.ImageLocation = null;
            this.btnListBooks.ImageMargin = 10;
            this.btnListBooks.ImageSize = new System.Drawing.Size(110, 101);
            this.btnListBooks.ImageZoomSize = new System.Drawing.Size(120, 111);
            this.btnListBooks.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnListBooks.InitialImage")));
            this.btnListBooks.Location = new System.Drawing.Point(107, 233);
            this.btnListBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListBooks.Name = "btnListBooks";
            this.btnListBooks.Rotation = 0;
            this.btnListBooks.ShowActiveImage = true;
            this.btnListBooks.ShowCursorChanges = true;
            this.btnListBooks.ShowImageBorders = true;
            this.btnListBooks.ShowSizeMarkers = false;
            this.btnListBooks.Size = new System.Drawing.Size(120, 111);
            this.btnListBooks.TabIndex = 19;
            this.btnListBooks.ToolTipText = "";
            this.btnListBooks.WaitOnLoad = false;
            this.btnListBooks.Zoom = 10;
            this.btnListBooks.ZoomSpeed = 10;
            this.btnListBooks.Click += new System.EventHandler(this.btnListBooks_Click);
            // 
            // btnListAccount
            // 
            this.btnListAccount.ActiveImage = null;
            this.btnListAccount.AllowAnimations = true;
            this.btnListAccount.AllowBuffering = false;
            this.btnListAccount.AllowToggling = false;
            this.btnListAccount.AllowZooming = true;
            this.btnListAccount.AllowZoomingOnFocus = false;
            this.btnListAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnListAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListAccount.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnListAccount.ErrorImage")));
            this.btnListAccount.FadeWhenInactive = false;
            this.btnListAccount.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnListAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnListAccount.Image")));
            this.btnListAccount.ImageActive = null;
            this.btnListAccount.ImageLocation = null;
            this.btnListAccount.ImageMargin = 10;
            this.btnListAccount.ImageSize = new System.Drawing.Size(110, 101);
            this.btnListAccount.ImageZoomSize = new System.Drawing.Size(120, 111);
            this.btnListAccount.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnListAccount.InitialImage")));
            this.btnListAccount.Location = new System.Drawing.Point(107, 82);
            this.btnListAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListAccount.Name = "btnListAccount";
            this.btnListAccount.Rotation = 0;
            this.btnListAccount.ShowActiveImage = true;
            this.btnListAccount.ShowCursorChanges = true;
            this.btnListAccount.ShowImageBorders = true;
            this.btnListAccount.ShowSizeMarkers = false;
            this.btnListAccount.Size = new System.Drawing.Size(120, 111);
            this.btnListAccount.TabIndex = 18;
            this.btnListAccount.ToolTipText = "";
            this.btnListAccount.WaitOnLoad = false;
            this.btnListAccount.Zoom = 10;
            this.btnListAccount.ZoomSpeed = 10;
            this.btnListAccount.Click += new System.EventHandler(this.btnListAccount_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1765, 53);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1692, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Библиотекарь";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(110, 101);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(120, 111);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(107, 657);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(120, 111);
            this.bunifuImageButton1.TabIndex = 27;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtBoxSerachAccount
            // 
            this.txtBoxSerachAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBoxSerachAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSerachAccount.Location = new System.Drawing.Point(363, 66);
            this.txtBoxSerachAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSerachAccount.Multiline = true;
            this.txtBoxSerachAccount.Name = "txtBoxSerachAccount";
            this.txtBoxSerachAccount.Size = new System.Drawing.Size(297, 30);
            this.txtBoxSerachAccount.TabIndex = 28;
            this.txtBoxSerachAccount.Visible = false;
            this.txtBoxSerachAccount.TextChanged += new System.EventHandler(this.txtBoxSerachAccount_TextChanged);
            // 
            // LibrarianAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1765, 922);
            this.Controls.Add(this.txtBoxSerachAccount);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnGiveBook);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.lblWelcome3);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAddBooks);
            this.Controls.Add(this.btndeleteBooks);
            this.Controls.Add(this.btnListBooks);
            this.Controls.Add(this.btnListAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridLibrary);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.libraryBooks);
            this.Controls.Add(this.brnAccount);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.gridAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibrarianAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.LibrarianWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet3)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbLibraryDataSet dbLibraryDataSet;
        private System.Windows.Forms.DataGridView gridAccount;
        private dbLibraryDataSet1 dbLibraryDataSet1;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private dbLibraryDataSet1TableAdapters.biletTableAdapter biletTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn biletIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordsDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Button brnAccount;
        private System.Windows.Forms.Button libraryBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView gridLibrary;
        private dbLibraryDataSet3 dbLibraryDataSet3;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private dbLibraryDataSet3TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private Bunifu.UI.WinForms.BunifuImageButton btnListAccount;
        private Bunifu.UI.WinForms.BunifuImageButton btnListBooks;
        private Bunifu.UI.WinForms.BunifuImageButton btndeleteBooks;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddBooks;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label lblWelcome3;
        private System.Windows.Forms.Button btnGiveBook;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox txtBoxSerachAccount;
    }
}