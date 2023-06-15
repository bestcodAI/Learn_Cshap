namespace ContactPhone
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comPlace = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalDollar = new System.Windows.Forms.TextBox();
            this.txtTotalKhmer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDollar = new System.Windows.Forms.TextBox();
            this.txtKhmer = new System.Windows.Forms.TextBox();
            this.db_databaseDataSet1 = new ContactPhone.db_databaseDataSet1();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataTableAdapter = new ContactPhone.db_databaseDataSet1TableAdapters.userDataTableAdapter();
            this.db_databaseDataSet = new ContactPhone.db_databaseDataSet();
            this.dbdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_databaseDataSet2 = new ContactPhone.db_databaseDataSet2();
            this.userDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDataTableAdapter1 = new ContactPhone.db_databaseDataSet2TableAdapters.userDataTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khmerMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1163, 42);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 41);
            this.txtName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Moul", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(537, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "💏ប្រព័ន្ធគ្រប់គ្រងចំណងដៃ អាពាហ៍ពិពាហ៍💏";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1480, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comPlace);
            this.panel2.Controls.Add(this.dateTime);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtTotalDollar);
            this.panel2.Controls.Add(this.txtTotalKhmer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDollar);
            this.panel2.Controls.Add(this.txtKhmer);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(-1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1551, 675);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 41);
            this.label9.TabIndex = 19;
            this.label9.Text = "ស្វែងរក";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(159, 32);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 41);
            this.txtSearch.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1016, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 41);
            this.label8.TabIndex = 17;
            this.label8.Text = "សរុប ដុល្លា";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1015, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "សរុប រៀល";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1015, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "ថ្ងៃ​ ខែ ឆ្នាំ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1015, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "ទីកន្លែង";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comPlace
            // 
            this.comPlace.Font = new System.Drawing.Font("Kh Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPlace.FormattingEnabled = true;
            this.comPlace.Items.AddRange(new object[] {
            "Svayrieng",
            "Prey veng",
            "Kompong speu",
            "Kompot"});
            this.comPlace.Location = new System.Drawing.Point(1163, 227);
            this.comPlace.Name = "comPlace";
            this.comPlace.Size = new System.Drawing.Size(348, 39);
            this.comPlace.TabIndex = 13;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "";
            this.dateTime.Font = new System.Drawing.Font("Kh Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(1163, 285);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(348, 39);
            this.dateTime.TabIndex = 12;
            this.dateTime.Value = new System.DateTime(2023, 6, 13, 1, 43, 25, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Kh Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(1410, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 51);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEdit.Font = new System.Drawing.Font("Kh Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(1284, 389);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 51);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "កែ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Kh Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(1163, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalDollar
            // 
            this.txtTotalDollar.Location = new System.Drawing.Point(1163, 540);
            this.txtTotalDollar.Multiline = true;
            this.txtTotalDollar.Name = "txtTotalDollar";
            this.txtTotalDollar.Size = new System.Drawing.Size(348, 41);
            this.txtTotalDollar.TabIndex = 8;
            // 
            // txtTotalKhmer
            // 
            this.txtTotalKhmer.Location = new System.Drawing.Point(1163, 466);
            this.txtTotalKhmer.Multiline = true;
            this.txtTotalKhmer.Name = "txtTotalKhmer";
            this.txtTotalKhmer.Size = new System.Drawing.Size(348, 41);
            this.txtTotalKhmer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1015, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "លុយ ដុល្លា";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "លុយ ខ្មែរ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kh Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1058, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "ឈ្មោះ";
            // 
            // txtDollar
            // 
            this.txtDollar.Location = new System.Drawing.Point(1163, 166);
            this.txtDollar.Multiline = true;
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(348, 41);
            this.txtDollar.TabIndex = 3;
            // 
            // txtKhmer
            // 
            this.txtKhmer.Location = new System.Drawing.Point(1163, 105);
            this.txtKhmer.Multiline = true;
            this.txtKhmer.Name = "txtKhmer";
            this.txtKhmer.Size = new System.Drawing.Size(348, 41);
            this.txtKhmer.TabIndex = 2;
            // 
            // db_databaseDataSet1
            // 
            this.db_databaseDataSet1.DataSetName = "db_databaseDataSet1";
            this.db_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "userData";
            this.userDataBindingSource.DataSource = this.db_databaseDataSet1;
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
            // 
            // db_databaseDataSet
            // 
            this.db_databaseDataSet.DataSetName = "db_databaseDataSet";
            this.db_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbdatabaseDataSetBindingSource
            // 
            this.dbdatabaseDataSetBindingSource.DataSource = this.db_databaseDataSet;
            this.dbdatabaseDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.khmerMoneyDataGridViewTextBoxColumn,
            this.dollarMoneyDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(44, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(918, 454);
            this.dataGridView1.TabIndex = 20;
            // 
            // db_databaseDataSet2
            // 
            this.db_databaseDataSet2.DataSetName = "db_databaseDataSet2";
            this.db_databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataBindingSource1
            // 
            this.userDataBindingSource1.DataMember = "userData";
            this.userDataBindingSource1.DataSource = this.db_databaseDataSet2;
            // 
            // userDataTableAdapter1
            // 
            this.userDataTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // khmerMoneyDataGridViewTextBoxColumn
            // 
            this.khmerMoneyDataGridViewTextBoxColumn.DataPropertyName = "KhmerMoney";
            this.khmerMoneyDataGridViewTextBoxColumn.HeaderText = "KhmerMoney";
            this.khmerMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khmerMoneyDataGridViewTextBoxColumn.Name = "khmerMoneyDataGridViewTextBoxColumn";
            // 
            // dollarMoneyDataGridViewTextBoxColumn
            // 
            this.dollarMoneyDataGridViewTextBoxColumn.DataPropertyName = "DollarMoney";
            this.dollarMoneyDataGridViewTextBoxColumn.HeaderText = "DollarMoney";
            this.dollarMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dollarMoneyDataGridViewTextBoxColumn.Name = "dollarMoneyDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDollar;
        private System.Windows.Forms.TextBox txtKhmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalKhmer;
        private System.Windows.Forms.TextBox txtTotalDollar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comPlace;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private db_databaseDataSet1 db_databaseDataSet1;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private db_databaseDataSet1TableAdapters.userDataTableAdapter userDataTableAdapter;
        private System.Windows.Forms.BindingSource dbdatabaseDataSetBindingSource;
        private db_databaseDataSet db_databaseDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_databaseDataSet2 db_databaseDataSet2;
        private System.Windows.Forms.BindingSource userDataBindingSource1;
        private db_databaseDataSet2TableAdapters.userDataTableAdapter userDataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khmerMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}

