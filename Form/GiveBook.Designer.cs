
namespace LibraryPri
{
    partial class GiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLibraryDataSet1 = new LibraryPri.dbLibraryDataSet1();
            this.biletTableAdapter = new LibraryPri.dbLibraryDataSet1TableAdapters.biletTableAdapter();
            this.dbLibraryDataSet2 = new LibraryPri.dbLibraryDataSet2();
            this.dbLibraryDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new LibraryPri.dbLibraryDataSet1TableAdapters.TableAdapterManager();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.GaveBookBtn = new System.Windows.Forms.Button();
            this.nachaloSdBtn = new System.Windows.Forms.Button();
            this.sdanBookBtn = new System.Windows.Forms.Button();
            this.button2Book = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Label();
            this.gridLibrary = new System.Windows.Forms.DataGridView();
            this.gridAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSdanBook = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2BindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSdanBook)).BeginInit();
            this.SuspendLayout();
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
            // dbLibraryDataSet2
            // 
            this.dbLibraryDataSet2.DataSetName = "dbLibraryDataSet2";
            this.dbLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbLibraryDataSet2BindingSource
            // 
            this.dbLibraryDataSet2BindingSource.DataSource = this.dbLibraryDataSet2;
            this.dbLibraryDataSet2BindingSource.Position = 0;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.biletTableAdapter = this.biletTableAdapter;
            this.tableAdapterManager1.UpdateOrder = LibraryPri.dbLibraryDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.button2);
            this.bunifuGradientPanel1.Controls.Add(this.GaveBookBtn);
            this.bunifuGradientPanel1.Controls.Add(this.nachaloSdBtn);
            this.bunifuGradientPanel1.Controls.Add(this.sdanBookBtn);
            this.bunifuGradientPanel1.Controls.Add(this.button2Book);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(328, 805);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.button2.Location = new System.Drawing.Point(16, 587);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 79);
            this.button2.TabIndex = 18;
            this.button2.Text = "Выбрать пользователя";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // GaveBookBtn
            // 
            this.GaveBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GaveBookBtn.FlatAppearance.BorderSize = 0;
            this.GaveBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GaveBookBtn.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.GaveBookBtn.Location = new System.Drawing.Point(16, 326);
            this.GaveBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GaveBookBtn.Name = "GaveBookBtn";
            this.GaveBookBtn.Size = new System.Drawing.Size(300, 79);
            this.GaveBookBtn.TabIndex = 17;
            this.GaveBookBtn.Text = "Сдача книги";
            this.GaveBookBtn.UseVisualStyleBackColor = false;
            this.GaveBookBtn.Click += new System.EventHandler(this.GaveBookBtn_Click);
            // 
            // nachaloSdBtn
            // 
            this.nachaloSdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nachaloSdBtn.FlatAppearance.BorderSize = 0;
            this.nachaloSdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nachaloSdBtn.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.nachaloSdBtn.Location = new System.Drawing.Point(16, 213);
            this.nachaloSdBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nachaloSdBtn.Name = "nachaloSdBtn";
            this.nachaloSdBtn.Size = new System.Drawing.Size(300, 79);
            this.nachaloSdBtn.TabIndex = 16;
            this.nachaloSdBtn.Text = "Выдача книги";
            this.nachaloSdBtn.UseVisualStyleBackColor = false;
            this.nachaloSdBtn.Click += new System.EventHandler(this.nachaloSdBtn_Click);
            // 
            // sdanBookBtn
            // 
            this.sdanBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdanBookBtn.FlatAppearance.BorderSize = 0;
            this.sdanBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdanBookBtn.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.sdanBookBtn.Location = new System.Drawing.Point(16, 447);
            this.sdanBookBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sdanBookBtn.Name = "sdanBookBtn";
            this.sdanBookBtn.Size = new System.Drawing.Size(300, 79);
            this.sdanBookBtn.TabIndex = 15;
            this.sdanBookBtn.Text = "Увидеть выданные книги";
            this.sdanBookBtn.UseVisualStyleBackColor = false;
            this.sdanBookBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2Book
            // 
            this.button2Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2Book.FlatAppearance.BorderSize = 0;
            this.button2Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Book.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.button2Book.Location = new System.Drawing.Point(16, 114);
            this.button2Book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2Book.Name = "button2Book";
            this.button2Book.Size = new System.Drawing.Size(300, 79);
            this.button2Book.TabIndex = 14;
            this.button2Book.Text = "Выбрать книгу";
            this.button2Book.UseVisualStyleBackColor = false;
            this.button2Book.Visible = false;
            this.button2Book.Click += new System.EventHandler(this.button2Book_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 79);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выбрать пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1819, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLibrary.ColumnHeadersHeight = 60;
            this.gridLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLibrary.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLibrary.EnableHeadersVisualStyles = false;
            this.gridLibrary.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.gridLibrary.Location = new System.Drawing.Point(363, 15);
            this.gridLibrary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridLibrary.MultiSelect = false;
            this.gridLibrary.Name = "gridLibrary";
            this.gridLibrary.ReadOnly = true;
            this.gridLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLibrary.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLibrary.RowHeadersVisible = false;
            this.gridLibrary.RowHeadersWidth = 51;
            this.gridLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLibrary.Size = new System.Drawing.Size(1093, 636);
            this.gridLibrary.TabIndex = 15;
            this.gridLibrary.Visible = false;
            this.gridLibrary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLibrary_CellContentClick);
            // 
            // gridAccount
            // 
            this.gridAccount.AllowUserToAddRows = false;
            this.gridAccount.AllowUserToDeleteRows = false;
            this.gridAccount.AllowUserToResizeColumns = false;
            this.gridAccount.AllowUserToResizeRows = false;
            this.gridAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.gridAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAccount.ColumnHeadersHeight = 60;
            this.gridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAccount.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridAccount.EnableHeadersVisualStyles = false;
            this.gridAccount.Location = new System.Drawing.Point(375, 33);
            this.gridAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAccount.RowHeadersVisible = false;
            this.gridAccount.RowHeadersWidth = 51;
            this.gridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccount.Size = new System.Drawing.Size(1081, 702);
            this.gridAccount.TabIndex = 16;
            this.gridAccount.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("TT Travels DemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1464, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridSdanBook
            // 
            this.dataGridSdanBook.AllowUserToAddRows = false;
            this.dataGridSdanBook.AllowUserToDeleteRows = false;
            this.dataGridSdanBook.AllowUserToResizeColumns = false;
            this.dataGridSdanBook.AllowUserToResizeRows = false;
            this.dataGridSdanBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSdanBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridSdanBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dataGridSdanBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSdanBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSdanBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridSdanBook.ColumnHeadersHeight = 60;
            this.dataGridSdanBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSdanBook.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridSdanBook.EnableHeadersVisualStyles = false;
            this.dataGridSdanBook.Location = new System.Drawing.Point(363, 33);
            this.dataGridSdanBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridSdanBook.Name = "dataGridSdanBook";
            this.dataGridSdanBook.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSdanBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridSdanBook.RowHeadersVisible = false;
            this.dataGridSdanBook.RowHeadersWidth = 51;
            this.dataGridSdanBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSdanBook.Size = new System.Drawing.Size(1092, 702);
            this.dataGridSdanBook.TabIndex = 18;
            this.dataGridSdanBook.Visible = false;
            this.dataGridSdanBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSdanBook_CellContentClick);
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("TT Travels Regular", 16F);
            this.buttonExport.Location = new System.Drawing.Point(375, 753);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(184, 39);
            this.buttonExport.TabIndex = 19;
            this.buttonExport.Text = "Экспорт";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1497, 805);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridSdanBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAccount);
            this.Controls.Add(this.gridLibrary);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GiveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiveBook";
            this.Load += new System.EventHandler(this.GiveBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2BindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSdanBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbLibraryDataSet1 dbLibraryDataSet1;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private dbLibraryDataSet1TableAdapters.biletTableAdapter biletTableAdapter;
        private dbLibraryDataSet2 dbLibraryDataSet2;
        private System.Windows.Forms.BindingSource dbLibraryDataSet2BindingSource;
        private dbLibraryDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridLibrary;
        private System.Windows.Forms.Button button2Book;
        private System.Windows.Forms.DataGridView gridAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sdanBookBtn;
        private System.Windows.Forms.DataGridView dataGridSdanBook;
        private System.Windows.Forms.Button GaveBookBtn;
        private System.Windows.Forms.Button nachaloSdBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonExport;
    }
}