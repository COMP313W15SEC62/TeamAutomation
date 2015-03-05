namespace AsmaraClinic
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtOhip = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnViewPatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ohipCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new AsmaraClinic.DataSet2();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.btnRefsresh = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtSLName = new System.Windows.Forms.TextBox();
            this.txtSFName = new System.Windows.Forms.TextBox();
            this.txtStaffID1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.asmaraClinicDataSet1 = new AsmaraClinic.AsmaraClinicDataSet();
            this.timeSlotTableAdapter1 = new AsmaraClinic.AsmaraClinicDataSetTableAdapters.TimeSlotTableAdapter();
            this.dataSet31 = new AsmaraClinic.DataSet3();
            this.dataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAllStaff = new System.Windows.Forms.Button();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmaraClinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(580, 306);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.txtStaffID);
            this.tabPage3.Controls.Add(this.txtOhip);
            this.tabPage3.Controls.Add(this.txtEmail);
            this.tabPage3.Controls.Add(this.txtPhone);
            this.tabPage3.Controls.Add(this.txtPostalCode);
            this.tabPage3.Controls.Add(this.txtProvince);
            this.tabPage3.Controls.Add(this.txtCity);
            this.tabPage3.Controls.Add(this.txtStreet);
            this.tabPage3.Controls.Add(this.txtLName);
            this.tabPage3.Controls.Add(this.txtFName);
            this.tabPage3.Controls.Add(this.txtID);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(572, 280);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "New Patient Registration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(284, 236);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(379, 172);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 22;
            // 
            // txtOhip
            // 
            this.txtOhip.Location = new System.Drawing.Point(379, 137);
            this.txtOhip.Name = "txtOhip";
            this.txtOhip.Size = new System.Drawing.Size(100, 20);
            this.txtOhip.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(379, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(379, 74);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(379, 48);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 18;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(84, 197);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 17;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(84, 166);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 16;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(84, 136);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 15;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(84, 105);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 14;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(84, 76);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "StaffID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ohip Card:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient\'s Information";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnViewPatients);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(572, 280);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "View Patients";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnViewPatients
            // 
            this.btnViewPatients.Location = new System.Drawing.Point(205, 242);
            this.btnViewPatients.Name = "btnViewPatients";
            this.btnViewPatients.Size = new System.Drawing.Size(130, 23);
            this.btnViewPatients.TabIndex = 1;
            this.btnViewPatients.Text = "View All Patients";
            this.btnViewPatients.UseVisualStyleBackColor = true;
            this.btnViewPatients.Click += new System.EventHandler(this.btnViewPatients_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ohipCardDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ohipCardDataGridViewTextBoxColumn
            // 
            this.ohipCardDataGridViewTextBoxColumn.DataPropertyName = "OhipCard";
            this.ohipCardDataGridViewTextBoxColumn.HeaderText = "OhipCard";
            this.ohipCardDataGridViewTextBoxColumn.Name = "ohipCardDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.btnRefsresh);
            this.tabPage4.Controls.Add(this.btnAddStaff);
            this.tabPage4.Controls.Add(this.txtSEmail);
            this.tabPage4.Controls.Add(this.txtSPhone);
            this.tabPage4.Controls.Add(this.txtAddress);
            this.tabPage4.Controls.Add(this.txtHireDate);
            this.tabPage4.Controls.Add(this.txtJobId);
            this.tabPage4.Controls.Add(this.txtJobTitle);
            this.tabPage4.Controls.Add(this.txtSLName);
            this.tabPage4.Controls.Add(this.txtSFName);
            this.tabPage4.Controls.Add(this.txtStaffID1);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(572, 280);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Add Staff";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(158, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(207, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "Enter New Staff Information";
            // 
            // btnRefsresh
            // 
            this.btnRefsresh.Location = new System.Drawing.Point(260, 251);
            this.btnRefsresh.Name = "btnRefsresh";
            this.btnRefsresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefsresh.TabIndex = 19;
            this.btnRefsresh.Text = "Refresh";
            this.btnRefsresh.UseVisualStyleBackColor = true;
            this.btnRefsresh.Click += new System.EventHandler(this.btnRefsresh_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(118, 251);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 18;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(355, 175);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(134, 20);
            this.txtSEmail.TabIndex = 17;
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(355, 130);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(134, 20);
            this.txtSPhone.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(355, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(134, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(355, 40);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(134, 20);
            this.txtHireDate.TabIndex = 14;
            // 
            // txtJobId
            // 
            this.txtJobId.Location = new System.Drawing.Point(79, 209);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(155, 20);
            this.txtJobId.TabIndex = 13;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(79, 167);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(155, 20);
            this.txtJobTitle.TabIndex = 12;
            // 
            // txtSLName
            // 
            this.txtSLName.Location = new System.Drawing.Point(79, 125);
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Size = new System.Drawing.Size(155, 20);
            this.txtSLName.TabIndex = 11;
            // 
            // txtSFName
            // 
            this.txtSFName.Location = new System.Drawing.Point(79, 83);
            this.txtSFName.Name = "txtSFName";
            this.txtSFName.Size = new System.Drawing.Size(155, 20);
            this.txtSFName.TabIndex = 10;
            // 
            // txtStaffID1
            // 
            this.txtStaffID1.Location = new System.Drawing.Point(79, 41);
            this.txtStaffID1.Name = "txtStaffID1";
            this.txtStaffID1.Size = new System.Drawing.Size(155, 20);
            this.txtStaffID1.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(281, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(281, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Phone:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(281, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(281, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Hire Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Job ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Job Title:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "LName:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "FName:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "StaffID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staff";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PERSONAL;Initial Catalog=AsmaraClinic;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Patient.*\r\nFROM            Patient";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatientID", System.Data.SqlDbType.Int, 0, "PatientID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NVarChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NVarChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@Street", System.Data.SqlDbType.NVarChar, 0, "Street"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Province", System.Data.SqlDbType.NVarChar, 0, "Province"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 0, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@PhoneNumber", System.Data.SqlDbType.NVarChar, 0, "PhoneNumber"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@OhipCard", System.Data.SqlDbType.NVarChar, 0, "OhipCard"),
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatientID", System.Data.SqlDbType.Int, 0, "PatientID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NVarChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NVarChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@Street", System.Data.SqlDbType.NVarChar, 0, "Street"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Province", System.Data.SqlDbType.NVarChar, 0, "Province"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 0, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@PhoneNumber", System.Data.SqlDbType.NVarChar, 0, "PhoneNumber"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@OhipCard", System.Data.SqlDbType.NVarChar, 0, "OhipCard"),
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@Original_PatientID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Street", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Street", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Province", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Province", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PostalCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PhoneNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OhipCard", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OhipCard", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_PatientID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Street", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Street", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Province", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Province", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PostalCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PhoneNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OhipCard", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OhipCard", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Patient", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PatientID", "PatientID"),
                        new System.Data.Common.DataColumnMapping("FName", "FName"),
                        new System.Data.Common.DataColumnMapping("LName", "LName"),
                        new System.Data.Common.DataColumnMapping("Street", "Street"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Province", "Province"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("OhipCard", "OhipCard"),
                        new System.Data.Common.DataColumnMapping("StaffID", "StaffID")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnAllStaff);
            this.tabPage6.Controls.Add(this.dataGridView2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(572, 280);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "View Staff";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.fNameDataGridViewTextBoxColumn1,
            this.lNameDataGridViewTextBoxColumn1,
            this.jobTitleDataGridViewTextBoxColumn,
            this.jobIDDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.staffBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(523, 161);
            this.dataGridView2.TabIndex = 0;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Staff.*\r\nFROM            Staff";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NVarChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NVarChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@JobTitle", System.Data.SqlDbType.NVarChar, 0, "JobTitle"),
            new System.Data.SqlClient.SqlParameter("@JobID", System.Data.SqlDbType.NVarChar, 0, "JobID"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.Date, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@PhoneNumber", System.Data.SqlDbType.NVarChar, 0, "PhoneNumber"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NVarChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NVarChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@JobTitle", System.Data.SqlDbType.NVarChar, 0, "JobTitle"),
            new System.Data.SqlClient.SqlParameter("@JobID", System.Data.SqlDbType.NVarChar, 0, "JobID"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.Date, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@PhoneNumber", System.Data.SqlDbType.NVarChar, 0, "PhoneNumber"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_JobTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_JobID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PhoneNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_JobTitle", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_JobID", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Address", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PhoneNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Staff", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StaffID", "StaffID"),
                        new System.Data.Common.DataColumnMapping("FName", "FName"),
                        new System.Data.Common.DataColumnMapping("LName", "LName"),
                        new System.Data.Common.DataColumnMapping("JobTitle", "JobTitle"),
                        new System.Data.Common.DataColumnMapping("JobID", "JobID"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("Email", "Email")})});
            this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // asmaraClinicDataSet1
            // 
            this.asmaraClinicDataSet1.DataSetName = "AsmaraClinicDataSet";
            this.asmaraClinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSlotTableAdapter1
            // 
            this.timeSlotTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet3";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet31BindingSource
            // 
            this.dataSet31BindingSource.DataSource = this.dataSet31;
            this.dataSet31BindingSource.Position = 0;
            // 
            // btnAllStaff
            // 
            this.btnAllStaff.Location = new System.Drawing.Point(182, 233);
            this.btnAllStaff.Name = "btnAllStaff";
            this.btnAllStaff.Size = new System.Drawing.Size(158, 23);
            this.btnAllStaff.TabIndex = 1;
            this.btnAllStaff.Text = "View All Staff";
            this.btnAllStaff.UseVisualStyleBackColor = true;
            this.btnAllStaff.Click += new System.EventHandler(this.btnAllStaff_Click);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet31BindingSource;
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            this.fNameDataGridViewTextBoxColumn1.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn1.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            // 
            // lNameDataGridViewTextBoxColumn1
            // 
            this.lNameDataGridViewTextBoxColumn1.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn1.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn1.Name = "lNameDataGridViewTextBoxColumn1";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Receptionist";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmaraClinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtOhip;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRefsresh;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtSLName;
        private System.Windows.Forms.TextBox txtSFName;
        private System.Windows.Forms.TextBox txtStaffID1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewPatients;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataSet2 dataSet21;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ohipCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private AsmaraClinicDataSetTableAdapters.TimeSlotTableAdapter timeSlotTableAdapter1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private AsmaraClinicDataSet asmaraClinicDataSet1;
        private System.Windows.Forms.Button btnAllStaff;
        private System.Windows.Forms.BindingSource dataSet31BindingSource;
        private DataSet3 dataSet31;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource staffBindingSource;
    }
}

