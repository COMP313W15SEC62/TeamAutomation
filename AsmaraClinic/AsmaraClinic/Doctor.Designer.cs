namespace AsmaraClinic
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewMySchedule = new System.Windows.Forms.Button();
            this.dgrSchedule = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSlotDetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet121BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet121 = new AsmaraClinic.DataSet12();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.dgrAppointment = new System.Windows.Forms.DataGridView();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new AsmaraClinic.DataSet9();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet121BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSlotDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSlotDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.asmaraClinicDataSet1 = new AsmaraClinic.AsmaraClinicDataSet();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmaraClinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.Controls.Add(this.cmdID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnViewMySchedule);
            this.tabPage1.Controls.Add(this.dgrSchedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule";
            // 
            // cmdID
            // 
            this.cmdID.FormattingEnabled = true;
            this.cmdID.Location = new System.Drawing.Point(31, 143);
            this.cmdID.Name = "cmdID";
            this.cmdID.Size = new System.Drawing.Size(132, 21);
            this.cmdID.TabIndex = 3;
            this.cmdID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Schedule";
            // 
            // btnViewMySchedule
            // 
            this.btnViewMySchedule.Location = new System.Drawing.Point(22, 62);
            this.btnViewMySchedule.Name = "btnViewMySchedule";
            this.btnViewMySchedule.Size = new System.Drawing.Size(141, 23);
            this.btnViewMySchedule.TabIndex = 1;
            this.btnViewMySchedule.Text = "View Schedule";
            this.btnViewMySchedule.UseVisualStyleBackColor = true;
            this.btnViewMySchedule.Click += new System.EventHandler(this.btnViewMySchedule_Click);
            // 
            // dgrSchedule
            // 
            this.dgrSchedule.AutoGenerateColumns = false;
            this.dgrSchedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dgrSchedule.DataSource = this.timeSlotDetailBindingSource2;
            this.dgrSchedule.Location = new System.Drawing.Point(251, 41);
            this.dgrSchedule.Name = "dgrSchedule";
            this.dgrSchedule.Size = new System.Drawing.Size(244, 219);
            this.dgrSchedule.TabIndex = 0;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // timeSlotDetailBindingSource2
            // 
            this.timeSlotDetailBindingSource2.DataMember = "TimeSlotDetail";
            this.timeSlotDetailBindingSource2.DataSource = this.dataSet121BindingSource1;
            // 
            // dataSet121BindingSource1
            // 
            this.dataSet121BindingSource1.DataSource = this.dataSet121;
            this.dataSet121BindingSource1.Position = 0;
            // 
            // dataSet121
            // 
            this.dataSet121.DataSetName = "DataSet12";
            this.dataSet121.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage2.Controls.Add(this.cmbStaff);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAppointment);
            this.tabPage2.Controls.Add(this.dgrAppointment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patients Appointment";
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(8, 79);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(127, 21);
            this.cmbStaff.TabIndex = 3;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "My Appointment";
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(6, 23);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(129, 23);
            this.btnAppointment.TabIndex = 1;
            this.btnAppointment.Text = "View Appointments";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // dgrAppointment
            // 
            this.dgrAppointment.AutoGenerateColumns = false;
            this.dgrAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrAppointment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgrAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn1,
            this.dateTimeDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn});
            this.dgrAppointment.DataSource = this.appointmentBindingSource1;
            this.dgrAppointment.Location = new System.Drawing.Point(141, 23);
            this.dgrAppointment.Name = "dgrAppointment";
            this.dgrAppointment.Size = new System.Drawing.Size(587, 237);
            this.dgrAppointment.TabIndex = 0;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            // 
            // dateTimeDataGridViewTextBoxColumn1
            // 
            this.dateTimeDataGridViewTextBoxColumn1.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn1.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn1.Name = "dateTimeDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // appointmentBindingSource1
            // 
            this.appointmentBindingSource1.DataMember = "Appointment";
            this.appointmentBindingSource1.DataSource = this.dataSet9BindingSource1;
            // 
            // dataSet9BindingSource1
            // 
            this.dataSet9BindingSource1.DataSource = this.dataSet9;
            this.dataSet9BindingSource1.Position = 0;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        StaffID, DateTime\r\nFROM            TimeSlotDetail";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PERSONAL;Initial Catalog=AsmaraClinic;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [TimeSlotDetail] ([StaffID], [DateTime]) VALUES (@StaffID, @DateTime)" +
    ";\r\nSELECT StaffID, DateTime FROM TimeSlotDetail WHERE (DateTime = @DateTime) AND" +
    " (StaffID = @StaffID)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@DateTime", System.Data.SqlDbType.DateTime, 0, "DateTime")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@DateTime", System.Data.SqlDbType.DateTime, 0, "DateTime"),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateTime", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [TimeSlotDetail] WHERE (([StaffID] = @Original_StaffID) AND ([DateTim" +
    "e] = @Original_DateTime))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateTime", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TimeSlotDetail", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StaffID", "StaffID"),
                        new System.Data.Common.DataColumnMapping("DateTime", "DateTime")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet121BindingSource
            // 
            this.dataSet121BindingSource.DataSource = this.dataSet121;
            this.dataSet121BindingSource.Position = 0;
            // 
            // timeSlotDetailBindingSource
            // 
            this.timeSlotDetailBindingSource.DataMember = "TimeSlotDetail";
            this.timeSlotDetailBindingSource.DataSource = this.dataSet121BindingSource;
            // 
            // timeSlotDetailBindingSource1
            // 
            this.timeSlotDetailBindingSource1.DataMember = "TimeSlotDetail";
            this.timeSlotDetailBindingSource1.DataSource = this.dataSet121BindingSource;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Blue;
            this.lblUser.Location = new System.Drawing.Point(558, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        AppointmentID, PatientID, StaffID, DateTime, Status\r\nFROM          " +
    "  Appointment";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatientID", System.Data.SqlDbType.Int, 0, "PatientID"),
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@DateTime", System.Data.SqlDbType.DateTime, 0, "DateTime"),
            new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.VarChar, 0, "Status")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatientID", System.Data.SqlDbType.Int, 0, "PatientID"),
            new System.Data.SqlClient.SqlParameter("@StaffID", System.Data.SqlDbType.Int, 0, "StaffID"),
            new System.Data.SqlClient.SqlParameter("@DateTime", System.Data.SqlDbType.DateTime, 0, "DateTime"),
            new System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.VarChar, 0, "Status"),
            new System.Data.SqlClient.SqlParameter("@Original_AppointmentID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AppointmentID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PatientID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@AppointmentID", System.Data.SqlDbType.Int, 4, "AppointmentID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_AppointmentID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AppointmentID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PatientID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_StaffID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StaffID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateTime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Status", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Status", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Appointment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AppointmentID", "AppointmentID"),
                        new System.Data.Common.DataColumnMapping("PatientID", "PatientID"),
                        new System.Data.Common.DataColumnMapping("StaffID", "StaffID"),
                        new System.Data.Common.DataColumnMapping("DateTime", "DateTime"),
                        new System.Data.Common.DataColumnMapping("Status", "Status")})});
            this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // asmaraClinicDataSet1
            // 
            this.asmaraClinicDataSet1.DataSetName = "AsmaraClinicDataSet";
            this.asmaraClinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTime
            // 
            this.dateTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.lblDateTime.Location = new System.Drawing.Point(547, 331);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(82, 17);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Date Time";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = this.dataSet9BindingSource;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 357);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Doctor";
            this.Text = "Asmara Clinic Doctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet121BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSlotDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asmaraClinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnViewMySchedule;
        private System.Windows.Forms.DataGridView dgrSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timeSlotDetailBindingSource2;
        private System.Windows.Forms.BindingSource dataSet121BindingSource1;
        private DataSet12 dataSet121;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.BindingSource dataSet121BindingSource;
        private System.Windows.Forms.BindingSource timeSlotDetailBindingSource;
        private System.Windows.Forms.BindingSource timeSlotDetailBindingSource1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdID;
        private System.Windows.Forms.DataGridView dgrAppointment;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingSource dataSet9BindingSource;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private AsmaraClinicDataSet asmaraClinicDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource1;
        private System.Windows.Forms.BindingSource dataSet9BindingSource1;
        private DataSet9 dataSet9;
        private System.Windows.Forms.Timer dateTime;
        private System.Windows.Forms.Label lblDateTime;
    }
}