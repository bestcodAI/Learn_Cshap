namespace Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmSex = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictur = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmAddress = new System.Windows.Forms.ComboBox();
            this.txtpob = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db_studentsDataSet = new Student_Form.db_studentsDataSet();
            this.tbstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbstudentsTableAdapter = new Student_Form.db_studentsDataSetTableAdapters.tbstudentsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentpobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbstudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 91);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1105, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmSex
            // 
            this.cmSex.AllowDrop = true;
            this.cmSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmSex.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmSex.FormattingEnabled = true;
            this.cmSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmSex.Location = new System.Drawing.Point(46, 299);
            this.cmSex.Name = "cmSex";
            this.cmSex.Size = new System.Drawing.Size(447, 35);
            this.cmSex.TabIndex = 35;
            this.cmSex.UseWaitCursor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.AllowDrop = true;
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(46, 388);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(447, 34);
            this.txtPhone.TabIndex = 34;
            this.txtPhone.UseWaitCursor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.AllowDrop = true;
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(46, 214);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(447, 34);
            this.txtLastName.TabIndex = 33;
            this.txtLastName.UseWaitCursor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(46, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(447, 34);
            this.txtFirstName.TabIndex = 32;
            this.txtFirstName.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sex";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            this.label2.UseWaitCursor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnUpload.Location = new System.Drawing.Point(920, 365);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(147, 46);
            this.btnUpload.TabIndex = 50;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.UseWaitCursor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictur
            // 
            this.pictur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictur.Location = new System.Drawing.Point(624, 388);
            this.pictur.Name = "pictur";
            this.pictur.Size = new System.Drawing.Size(249, 190);
            this.pictur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictur.TabIndex = 49;
            this.pictur.TabStop = false;
            this.pictur.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Photo";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(610, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Place of birth";
            this.label8.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Date of birth";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(610, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Address";
            this.label7.UseWaitCursor = true;
            // 
            // cmAddress
            // 
            this.cmAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmAddress.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmAddress.FormattingEnabled = true;
            this.cmAddress.Items.AddRange(new object[] {
            "Banteay Meanchey",
            "Battambang",
            "Kampong Cham",
            "Kampong Chhnang",
            "Kampong Speu",
            "Kampong Thom",
            "Kampot",
            "Kandal",
            "Kep",
            "Koh Kong",
            "Kratié",
            "Mondulkiri",
            "Oddar Meanchey",
            "Pailin",
            "Phnom Penh Capital",
            "Preah Vihear",
            "Pursat",
            "Prey Veng",
            "Ratanakiri",
            "Siem Reap",
            "Preah Sihanouk",
            "Stueng Treng",
            "Svay Rieng",
            "Takéo",
            "Tboung Khmum"});
            this.cmAddress.Location = new System.Drawing.Point(610, 128);
            this.cmAddress.Name = "cmAddress";
            this.cmAddress.Size = new System.Drawing.Size(447, 35);
            this.cmAddress.TabIndex = 44;
            this.cmAddress.UseWaitCursor = true;
            // 
            // txtpob
            // 
            this.txtpob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpob.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpob.Location = new System.Drawing.Point(610, 214);
            this.txtpob.Multiline = true;
            this.txtpob.Name = "txtpob";
            this.txtpob.Size = new System.Drawing.Size(447, 96);
            this.txtpob.TabIndex = 43;
            this.txtpob.UseWaitCursor = true;
            // 
            // dob
            // 
            this.dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dob.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dob.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(46, 467);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(447, 34);
            this.dob.TabIndex = 42;
            this.dob.UseWaitCursor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(38, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 46);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(173, 520);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 46);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(306, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(441, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 54;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.Location = new System.Drawing.Point(920, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 46);
            this.button3.TabIndex = 55;
            this.button3.Text = "Views";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentfirstnameDataGridViewTextBoxColumn,
            this.studentlastnameDataGridViewTextBoxColumn,
            this.studentsexDataGridViewTextBoxColumn,
            this.studentdobDataGridViewTextBoxColumn,
            this.studentphoneDataGridViewTextBoxColumn,
            this.studentaddressDataGridViewTextBoxColumn,
            this.studentpobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbstudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 614);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 170);
            this.dataGridView1.TabIndex = 56;
            // 
            // db_studentsDataSet
            // 
            this.db_studentsDataSet.DataSetName = "db_studentsDataSet";
            this.db_studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbstudentsBindingSource
            // 
            this.tbstudentsBindingSource.DataMember = "tbstudents";
            this.tbstudentsBindingSource.DataSource = this.db_studentsDataSet;
            // 
            // tbstudentsTableAdapter
            // 
            this.tbstudentsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentfirstnameDataGridViewTextBoxColumn
            // 
            this.studentfirstnameDataGridViewTextBoxColumn.DataPropertyName = "student_firstname";
            this.studentfirstnameDataGridViewTextBoxColumn.HeaderText = "student_firstname";
            this.studentfirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentfirstnameDataGridViewTextBoxColumn.Name = "studentfirstnameDataGridViewTextBoxColumn";
            this.studentfirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentlastnameDataGridViewTextBoxColumn
            // 
            this.studentlastnameDataGridViewTextBoxColumn.DataPropertyName = "student_lastname";
            this.studentlastnameDataGridViewTextBoxColumn.HeaderText = "student_lastname";
            this.studentlastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentlastnameDataGridViewTextBoxColumn.Name = "studentlastnameDataGridViewTextBoxColumn";
            this.studentlastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsexDataGridViewTextBoxColumn
            // 
            this.studentsexDataGridViewTextBoxColumn.DataPropertyName = "student_sex";
            this.studentsexDataGridViewTextBoxColumn.HeaderText = "student_sex";
            this.studentsexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentsexDataGridViewTextBoxColumn.Name = "studentsexDataGridViewTextBoxColumn";
            this.studentsexDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentdobDataGridViewTextBoxColumn
            // 
            this.studentdobDataGridViewTextBoxColumn.DataPropertyName = "student_dob";
            this.studentdobDataGridViewTextBoxColumn.HeaderText = "student_dob";
            this.studentdobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentdobDataGridViewTextBoxColumn.Name = "studentdobDataGridViewTextBoxColumn";
            this.studentdobDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentphoneDataGridViewTextBoxColumn
            // 
            this.studentphoneDataGridViewTextBoxColumn.DataPropertyName = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.HeaderText = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentphoneDataGridViewTextBoxColumn.Name = "studentphoneDataGridViewTextBoxColumn";
            this.studentphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentaddressDataGridViewTextBoxColumn
            // 
            this.studentaddressDataGridViewTextBoxColumn.DataPropertyName = "student_address";
            this.studentaddressDataGridViewTextBoxColumn.HeaderText = "student_address";
            this.studentaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentaddressDataGridViewTextBoxColumn.Name = "studentaddressDataGridViewTextBoxColumn";
            this.studentaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentpobDataGridViewTextBoxColumn
            // 
            this.studentpobDataGridViewTextBoxColumn.DataPropertyName = "student_pob";
            this.studentpobDataGridViewTextBoxColumn.HeaderText = "student_pob";
            this.studentpobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentpobDataGridViewTextBoxColumn.Name = "studentpobDataGridViewTextBoxColumn";
            this.studentpobDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 796);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmAddress);
            this.Controls.Add(this.txtpob);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.cmSex);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbstudentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmAddress;
        private System.Windows.Forms.TextBox txtpob;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_studentsDataSet db_studentsDataSet;
        private System.Windows.Forms.BindingSource tbstudentsBindingSource;
        private db_studentsDataSetTableAdapters.tbstudentsTableAdapter tbstudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentpobDataGridViewTextBoxColumn;
    }
}

