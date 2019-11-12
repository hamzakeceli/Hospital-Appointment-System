namespace HospitalRecordingSystem.WinUI.Forms.PatientForms
{
    partial class FormPatientPanel
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
            this.pnlGetAnAppointment = new System.Windows.Forms.Panel();
            this.btnDoctorsPolyclinicQuery = new System.Windows.Forms.Button();
            this.btnGetDoctorSession = new System.Windows.Forms.Button();
            this.dgvDoctorList = new System.Windows.Forms.DataGridView();
            this.pnlAnAppointmentInfos = new System.Windows.Forms.Panel();
            this.lblAppointmentPatientSession = new System.Windows.Forms.Label();
            this.lblAppointmentInfoSession = new System.Windows.Forms.Label();
            this.lblAppointmentPatientDate = new System.Windows.Forms.Label();
            this.lblAppointmentPatientDoctorName = new System.Windows.Forms.Label();
            this.lblAppointmentPatientPolyclinicName = new System.Windows.Forms.Label();
            this.lblAppointmentPatientDepartmentName = new System.Windows.Forms.Label();
            this.lblAppointmentPatientHospitalName = new System.Windows.Forms.Label();
            this.lblAppointmentPatientName = new System.Windows.Forms.Label();
            this.btnComplateAppointment = new System.Windows.Forms.Button();
            this.lblAppointmentInfoDate = new System.Windows.Forms.Label();
            this.lblAppointmentInfoDoctorName = new System.Windows.Forms.Label();
            this.lblAppointmentInfoPolyclinicName = new System.Windows.Forms.Label();
            this.lblAppointmentInfoDepartmentName = new System.Windows.Forms.Label();
            this.lblAppointmentInfoHospitalName = new System.Windows.Forms.Label();
            this.lblAppointmentInfoName = new System.Windows.Forms.Label();
            this.btnDoctorsDepartmanQuery = new System.Windows.Forms.Button();
            this.lblAppointmentPolyclinicName = new System.Windows.Forms.Label();
            this.cmbAppointmentPolyclinicName = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDepartmentName = new System.Windows.Forms.Label();
            this.cmbAppointmentDepartmentName = new System.Windows.Forms.ComboBox();
            this.lblAppointmentHospitalName = new System.Windows.Forms.Label();
            this.cmbAppointmentHospitalName = new System.Windows.Forms.ComboBox();
            this.btnAllAppointments = new System.Windows.Forms.Button();
            this.btnGetAnAppointment = new System.Windows.Forms.Button();
            this.lblPatientNameAndSurname = new System.Windows.Forms.Label();
            this.pnlAppointmentList = new System.Windows.Forms.Panel();
            this.dgvGetAllAppointments = new System.Windows.Forms.DataGridView();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.pnlGetAnAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).BeginInit();
            this.pnlAnAppointmentInfos.SuspendLayout();
            this.pnlAppointmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGetAnAppointment
            // 
            this.pnlGetAnAppointment.Controls.Add(this.btnDoctorsPolyclinicQuery);
            this.pnlGetAnAppointment.Controls.Add(this.btnGetDoctorSession);
            this.pnlGetAnAppointment.Controls.Add(this.dgvDoctorList);
            this.pnlGetAnAppointment.Controls.Add(this.pnlAnAppointmentInfos);
            this.pnlGetAnAppointment.Controls.Add(this.btnDoctorsDepartmanQuery);
            this.pnlGetAnAppointment.Controls.Add(this.lblAppointmentPolyclinicName);
            this.pnlGetAnAppointment.Controls.Add(this.cmbAppointmentPolyclinicName);
            this.pnlGetAnAppointment.Controls.Add(this.lblAppointmentDepartmentName);
            this.pnlGetAnAppointment.Controls.Add(this.cmbAppointmentDepartmentName);
            this.pnlGetAnAppointment.Controls.Add(this.lblAppointmentHospitalName);
            this.pnlGetAnAppointment.Controls.Add(this.cmbAppointmentHospitalName);
            this.pnlGetAnAppointment.Location = new System.Drawing.Point(12, 122);
            this.pnlGetAnAppointment.Name = "pnlGetAnAppointment";
            this.pnlGetAnAppointment.Size = new System.Drawing.Size(993, 556);
            this.pnlGetAnAppointment.TabIndex = 17;
            // 
            // btnDoctorsPolyclinicQuery
            // 
            this.btnDoctorsPolyclinicQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnDoctorsPolyclinicQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDoctorsPolyclinicQuery.FlatAppearance.BorderSize = 0;
            this.btnDoctorsPolyclinicQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorsPolyclinicQuery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctorsPolyclinicQuery.ForeColor = System.Drawing.Color.White;
            this.btnDoctorsPolyclinicQuery.Location = new System.Drawing.Point(16, 230);
            this.btnDoctorsPolyclinicQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoctorsPolyclinicQuery.Name = "btnDoctorsPolyclinicQuery";
            this.btnDoctorsPolyclinicQuery.Size = new System.Drawing.Size(230, 34);
            this.btnDoctorsPolyclinicQuery.TabIndex = 16;
            this.btnDoctorsPolyclinicQuery.Text = "Polikinliğe Göre Sorgula";
            this.btnDoctorsPolyclinicQuery.UseVisualStyleBackColor = false;
            this.btnDoctorsPolyclinicQuery.Click += new System.EventHandler(this.btnDoctorsPolyclinicQuery_Click);
            // 
            // btnGetDoctorSession
            // 
            this.btnGetDoctorSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnGetDoctorSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnGetDoctorSession.FlatAppearance.BorderSize = 0;
            this.btnGetDoctorSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDoctorSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetDoctorSession.ForeColor = System.Drawing.Color.White;
            this.btnGetDoctorSession.Location = new System.Drawing.Point(830, 463);
            this.btnGetDoctorSession.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetDoctorSession.Name = "btnGetDoctorSession";
            this.btnGetDoctorSession.Size = new System.Drawing.Size(147, 38);
            this.btnGetDoctorSession.TabIndex = 15;
            this.btnGetDoctorSession.Text = "Seansları Göster";
            this.btnGetDoctorSession.UseVisualStyleBackColor = false;
            this.btnGetDoctorSession.Click += new System.EventHandler(this.BtnGetDoctorSession_Click);
            // 
            // dgvDoctorList
            // 
            this.dgvDoctorList.AllowUserToAddRows = false;
            this.dgvDoctorList.AllowUserToDeleteRows = false;
            this.dgvDoctorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorList.Location = new System.Drawing.Point(302, 30);
            this.dgvDoctorList.Name = "dgvDoctorList";
            this.dgvDoctorList.ReadOnly = true;
            this.dgvDoctorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDoctorList.Size = new System.Drawing.Size(675, 419);
            this.dgvDoctorList.TabIndex = 14;
            // 
            // pnlAnAppointmentInfos
            // 
            this.pnlAnAppointmentInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientSession);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoSession);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientDate);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientDoctorName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientPolyclinicName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientDepartmentName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientHospitalName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentPatientName);
            this.pnlAnAppointmentInfos.Controls.Add(this.btnComplateAppointment);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoDate);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoDoctorName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoPolyclinicName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoDepartmentName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoHospitalName);
            this.pnlAnAppointmentInfos.Controls.Add(this.lblAppointmentInfoName);
            this.pnlAnAppointmentInfos.Location = new System.Drawing.Point(16, 288);
            this.pnlAnAppointmentInfos.Name = "pnlAnAppointmentInfos";
            this.pnlAnAppointmentInfos.Size = new System.Drawing.Size(251, 256);
            this.pnlAnAppointmentInfos.TabIndex = 7;
            // 
            // lblAppointmentPatientSession
            // 
            this.lblAppointmentPatientSession.AutoSize = true;
            this.lblAppointmentPatientSession.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientSession.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientSession.Location = new System.Drawing.Point(113, 186);
            this.lblAppointmentPatientSession.Name = "lblAppointmentPatientSession";
            this.lblAppointmentPatientSession.Size = new System.Drawing.Size(37, 17);
            this.lblAppointmentPatientSession.TabIndex = 26;
            this.lblAppointmentPatientSession.Text = "Saat";
            // 
            // lblAppointmentInfoSession
            // 
            this.lblAppointmentInfoSession.AutoSize = true;
            this.lblAppointmentInfoSession.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoSession.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoSession.Location = new System.Drawing.Point(2, 186);
            this.lblAppointmentInfoSession.Name = "lblAppointmentInfoSession";
            this.lblAppointmentInfoSession.Size = new System.Drawing.Size(45, 17);
            this.lblAppointmentInfoSession.TabIndex = 26;
            this.lblAppointmentInfoSession.Text = "Saat :";
            // 
            // lblAppointmentPatientDate
            // 
            this.lblAppointmentPatientDate.AutoSize = true;
            this.lblAppointmentPatientDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientDate.Location = new System.Drawing.Point(113, 163);
            this.lblAppointmentPatientDate.Name = "lblAppointmentPatientDate";
            this.lblAppointmentPatientDate.Size = new System.Drawing.Size(37, 17);
            this.lblAppointmentPatientDate.TabIndex = 25;
            this.lblAppointmentPatientDate.Text = "Tarih";
            // 
            // lblAppointmentPatientDoctorName
            // 
            this.lblAppointmentPatientDoctorName.AutoSize = true;
            this.lblAppointmentPatientDoctorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientDoctorName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientDoctorName.Location = new System.Drawing.Point(113, 133);
            this.lblAppointmentPatientDoctorName.Name = "lblAppointmentPatientDoctorName";
            this.lblAppointmentPatientDoctorName.Size = new System.Drawing.Size(77, 17);
            this.lblAppointmentPatientDoctorName.TabIndex = 24;
            this.lblAppointmentPatientDoctorName.Text = "Doktor Adı";
            // 
            // lblAppointmentPatientPolyclinicName
            // 
            this.lblAppointmentPatientPolyclinicName.AutoSize = true;
            this.lblAppointmentPatientPolyclinicName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientPolyclinicName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientPolyclinicName.Location = new System.Drawing.Point(113, 103);
            this.lblAppointmentPatientPolyclinicName.Name = "lblAppointmentPatientPolyclinicName";
            this.lblAppointmentPatientPolyclinicName.Size = new System.Drawing.Size(87, 17);
            this.lblAppointmentPatientPolyclinicName.TabIndex = 23;
            this.lblAppointmentPatientPolyclinicName.Text = "Poliklinik Adı";
            // 
            // lblAppointmentPatientDepartmentName
            // 
            this.lblAppointmentPatientDepartmentName.AutoSize = true;
            this.lblAppointmentPatientDepartmentName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientDepartmentName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientDepartmentName.Location = new System.Drawing.Point(113, 73);
            this.lblAppointmentPatientDepartmentName.Name = "lblAppointmentPatientDepartmentName";
            this.lblAppointmentPatientDepartmentName.Size = new System.Drawing.Size(108, 17);
            this.lblAppointmentPatientDepartmentName.TabIndex = 22;
            this.lblAppointmentPatientDepartmentName.Text = "Departman Adı";
            // 
            // lblAppointmentPatientHospitalName
            // 
            this.lblAppointmentPatientHospitalName.AutoSize = true;
            this.lblAppointmentPatientHospitalName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientHospitalName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientHospitalName.Location = new System.Drawing.Point(113, 46);
            this.lblAppointmentPatientHospitalName.Name = "lblAppointmentPatientHospitalName";
            this.lblAppointmentPatientHospitalName.Size = new System.Drawing.Size(86, 17);
            this.lblAppointmentPatientHospitalName.TabIndex = 21;
            this.lblAppointmentPatientHospitalName.Text = "Hastane Adı";
            // 
            // lblAppointmentPatientName
            // 
            this.lblAppointmentPatientName.AutoSize = true;
            this.lblAppointmentPatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPatientName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPatientName.Location = new System.Drawing.Point(113, 17);
            this.lblAppointmentPatientName.Name = "lblAppointmentPatientName";
            this.lblAppointmentPatientName.Size = new System.Drawing.Size(116, 17);
            this.lblAppointmentPatientName.TabIndex = 20;
            this.lblAppointmentPatientName.Text = "Hasta Adı Soyadı";
            // 
            // btnComplateAppointment
            // 
            this.btnComplateAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnComplateAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnComplateAppointment.FlatAppearance.BorderSize = 0;
            this.btnComplateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplateAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComplateAppointment.ForeColor = System.Drawing.Color.White;
            this.btnComplateAppointment.Location = new System.Drawing.Point(-1, 218);
            this.btnComplateAppointment.Margin = new System.Windows.Forms.Padding(5);
            this.btnComplateAppointment.Name = "btnComplateAppointment";
            this.btnComplateAppointment.Size = new System.Drawing.Size(251, 37);
            this.btnComplateAppointment.TabIndex = 14;
            this.btnComplateAppointment.Text = "Randevuyu Tamamla";
            this.btnComplateAppointment.UseVisualStyleBackColor = false;
            this.btnComplateAppointment.Click += new System.EventHandler(this.btnComplateAppointment_Click);
            // 
            // lblAppointmentInfoDate
            // 
            this.lblAppointmentInfoDate.AutoSize = true;
            this.lblAppointmentInfoDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoDate.Location = new System.Drawing.Point(3, 163);
            this.lblAppointmentInfoDate.Name = "lblAppointmentInfoDate";
            this.lblAppointmentInfoDate.Size = new System.Drawing.Size(45, 17);
            this.lblAppointmentInfoDate.TabIndex = 19;
            this.lblAppointmentInfoDate.Text = "Tarih :";
            // 
            // lblAppointmentInfoDoctorName
            // 
            this.lblAppointmentInfoDoctorName.AutoSize = true;
            this.lblAppointmentInfoDoctorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoDoctorName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoDoctorName.Location = new System.Drawing.Point(3, 133);
            this.lblAppointmentInfoDoctorName.Name = "lblAppointmentInfoDoctorName";
            this.lblAppointmentInfoDoctorName.Size = new System.Drawing.Size(60, 17);
            this.lblAppointmentInfoDoctorName.TabIndex = 18;
            this.lblAppointmentInfoDoctorName.Text = "Doktor :";
            // 
            // lblAppointmentInfoPolyclinicName
            // 
            this.lblAppointmentInfoPolyclinicName.AutoSize = true;
            this.lblAppointmentInfoPolyclinicName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoPolyclinicName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoPolyclinicName.Location = new System.Drawing.Point(3, 103);
            this.lblAppointmentInfoPolyclinicName.Name = "lblAppointmentInfoPolyclinicName";
            this.lblAppointmentInfoPolyclinicName.Size = new System.Drawing.Size(70, 17);
            this.lblAppointmentInfoPolyclinicName.TabIndex = 17;
            this.lblAppointmentInfoPolyclinicName.Text = "Poliklinik :";
            // 
            // lblAppointmentInfoDepartmentName
            // 
            this.lblAppointmentInfoDepartmentName.AutoSize = true;
            this.lblAppointmentInfoDepartmentName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoDepartmentName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoDepartmentName.Location = new System.Drawing.Point(3, 73);
            this.lblAppointmentInfoDepartmentName.Name = "lblAppointmentInfoDepartmentName";
            this.lblAppointmentInfoDepartmentName.Size = new System.Drawing.Size(91, 17);
            this.lblAppointmentInfoDepartmentName.TabIndex = 16;
            this.lblAppointmentInfoDepartmentName.Text = "Departman :";
            // 
            // lblAppointmentInfoHospitalName
            // 
            this.lblAppointmentInfoHospitalName.AutoSize = true;
            this.lblAppointmentInfoHospitalName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoHospitalName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoHospitalName.Location = new System.Drawing.Point(2, 46);
            this.lblAppointmentInfoHospitalName.Name = "lblAppointmentInfoHospitalName";
            this.lblAppointmentInfoHospitalName.Size = new System.Drawing.Size(69, 17);
            this.lblAppointmentInfoHospitalName.TabIndex = 15;
            this.lblAppointmentInfoHospitalName.Text = "Hastane :";
            // 
            // lblAppointmentInfoName
            // 
            this.lblAppointmentInfoName.AutoSize = true;
            this.lblAppointmentInfoName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentInfoName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentInfoName.Location = new System.Drawing.Point(3, 17);
            this.lblAppointmentInfoName.Name = "lblAppointmentInfoName";
            this.lblAppointmentInfoName.Size = new System.Drawing.Size(53, 17);
            this.lblAppointmentInfoName.TabIndex = 14;
            this.lblAppointmentInfoName.Text = "Hasta :";
            // 
            // btnDoctorsDepartmanQuery
            // 
            this.btnDoctorsDepartmanQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnDoctorsDepartmanQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDoctorsDepartmanQuery.FlatAppearance.BorderSize = 0;
            this.btnDoctorsDepartmanQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorsDepartmanQuery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctorsDepartmanQuery.ForeColor = System.Drawing.Color.White;
            this.btnDoctorsDepartmanQuery.Location = new System.Drawing.Point(16, 124);
            this.btnDoctorsDepartmanQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoctorsDepartmanQuery.Name = "btnDoctorsDepartmanQuery";
            this.btnDoctorsDepartmanQuery.Size = new System.Drawing.Size(230, 34);
            this.btnDoctorsDepartmanQuery.TabIndex = 13;
            this.btnDoctorsDepartmanQuery.Text = "Departmana Göre Sorgula";
            this.btnDoctorsDepartmanQuery.UseVisualStyleBackColor = false;
            this.btnDoctorsDepartmanQuery.Click += new System.EventHandler(this.btnDoctorsDepartmantQuery_Click);
            // 
            // lblAppointmentPolyclinicName
            // 
            this.lblAppointmentPolyclinicName.AutoSize = true;
            this.lblAppointmentPolyclinicName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentPolyclinicName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentPolyclinicName.Location = new System.Drawing.Point(13, 172);
            this.lblAppointmentPolyclinicName.Name = "lblAppointmentPolyclinicName";
            this.lblAppointmentPolyclinicName.Size = new System.Drawing.Size(62, 17);
            this.lblAppointmentPolyclinicName.TabIndex = 12;
            this.lblAppointmentPolyclinicName.Text = "Poliklinik";
            // 
            // cmbAppointmentPolyclinicName
            // 
            this.cmbAppointmentPolyclinicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbAppointmentPolyclinicName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentPolyclinicName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppointmentPolyclinicName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAppointmentPolyclinicName.ForeColor = System.Drawing.Color.LightGray;
            this.cmbAppointmentPolyclinicName.FormattingEnabled = true;
            this.cmbAppointmentPolyclinicName.Location = new System.Drawing.Point(16, 192);
            this.cmbAppointmentPolyclinicName.Name = "cmbAppointmentPolyclinicName";
            this.cmbAppointmentPolyclinicName.Size = new System.Drawing.Size(230, 30);
            this.cmbAppointmentPolyclinicName.TabIndex = 11;
            // 
            // lblAppointmentDepartmentName
            // 
            this.lblAppointmentDepartmentName.AutoSize = true;
            this.lblAppointmentDepartmentName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentDepartmentName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentDepartmentName.Location = new System.Drawing.Point(13, 66);
            this.lblAppointmentDepartmentName.Name = "lblAppointmentDepartmentName";
            this.lblAppointmentDepartmentName.Size = new System.Drawing.Size(83, 17);
            this.lblAppointmentDepartmentName.TabIndex = 10;
            this.lblAppointmentDepartmentName.Text = "Departman";
            // 
            // cmbAppointmentDepartmentName
            // 
            this.cmbAppointmentDepartmentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbAppointmentDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentDepartmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppointmentDepartmentName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAppointmentDepartmentName.ForeColor = System.Drawing.Color.LightGray;
            this.cmbAppointmentDepartmentName.FormattingEnabled = true;
            this.cmbAppointmentDepartmentName.Location = new System.Drawing.Point(16, 86);
            this.cmbAppointmentDepartmentName.Name = "cmbAppointmentDepartmentName";
            this.cmbAppointmentDepartmentName.Size = new System.Drawing.Size(230, 30);
            this.cmbAppointmentDepartmentName.TabIndex = 9;
            this.cmbAppointmentDepartmentName.SelectedIndexChanged += new System.EventHandler(this.cmbAppointmentDepartmentName_SelectedIndexChanged);
            // 
            // lblAppointmentHospitalName
            // 
            this.lblAppointmentHospitalName.AutoSize = true;
            this.lblAppointmentHospitalName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppointmentHospitalName.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentHospitalName.Location = new System.Drawing.Point(13, 10);
            this.lblAppointmentHospitalName.Name = "lblAppointmentHospitalName";
            this.lblAppointmentHospitalName.Size = new System.Drawing.Size(61, 17);
            this.lblAppointmentHospitalName.TabIndex = 8;
            this.lblAppointmentHospitalName.Text = "Hastane";
            // 
            // cmbAppointmentHospitalName
            // 
            this.cmbAppointmentHospitalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbAppointmentHospitalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentHospitalName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAppointmentHospitalName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAppointmentHospitalName.ForeColor = System.Drawing.Color.LightGray;
            this.cmbAppointmentHospitalName.FormattingEnabled = true;
            this.cmbAppointmentHospitalName.Location = new System.Drawing.Point(16, 30);
            this.cmbAppointmentHospitalName.Name = "cmbAppointmentHospitalName";
            this.cmbAppointmentHospitalName.Size = new System.Drawing.Size(230, 30);
            this.cmbAppointmentHospitalName.TabIndex = 7;
            // 
            // btnAllAppointments
            // 
            this.btnAllAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnAllAppointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAllAppointments.FlatAppearance.BorderSize = 0;
            this.btnAllAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllAppointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAllAppointments.Location = new System.Drawing.Point(168, 62);
            this.btnAllAppointments.Margin = new System.Windows.Forms.Padding(5);
            this.btnAllAppointments.Name = "btnAllAppointments";
            this.btnAllAppointments.Size = new System.Drawing.Size(148, 52);
            this.btnAllAppointments.TabIndex = 16;
            this.btnAllAppointments.Text = "Randevularım";
            this.btnAllAppointments.UseVisualStyleBackColor = false;
            this.btnAllAppointments.Click += new System.EventHandler(this.BtnAllAppointments_Click);
            // 
            // btnGetAnAppointment
            // 
            this.btnGetAnAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnGetAnAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnGetAnAppointment.FlatAppearance.BorderSize = 0;
            this.btnGetAnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAnAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetAnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnGetAnAppointment.Location = new System.Drawing.Point(14, 62);
            this.btnGetAnAppointment.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetAnAppointment.Name = "btnGetAnAppointment";
            this.btnGetAnAppointment.Size = new System.Drawing.Size(148, 52);
            this.btnGetAnAppointment.TabIndex = 15;
            this.btnGetAnAppointment.Text = "Randevu Al";
            this.btnGetAnAppointment.UseVisualStyleBackColor = false;
            this.btnGetAnAppointment.Click += new System.EventHandler(this.BtnGetAnAppointment_Click);
            // 
            // lblPatientNameAndSurname
            // 
            this.lblPatientNameAndSurname.AutoSize = true;
            this.lblPatientNameAndSurname.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblPatientNameAndSurname.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientNameAndSurname.Location = new System.Drawing.Point(12, 9);
            this.lblPatientNameAndSurname.Name = "lblPatientNameAndSurname";
            this.lblPatientNameAndSurname.Size = new System.Drawing.Size(328, 33);
            this.lblPatientNameAndSurname.TabIndex = 14;
            this.lblPatientNameAndSurname.Text = "Hoşgeldiniz Canan GÖK";
            // 
            // pnlAppointmentList
            // 
            this.pnlAppointmentList.Controls.Add(this.btnDeleteAppointment);
            this.pnlAppointmentList.Controls.Add(this.dgvGetAllAppointments);
            this.pnlAppointmentList.Location = new System.Drawing.Point(12, 122);
            this.pnlAppointmentList.Name = "pnlAppointmentList";
            this.pnlAppointmentList.Size = new System.Drawing.Size(993, 556);
            this.pnlAppointmentList.TabIndex = 18;
            // 
            // dgvGetAllAppointments
            // 
            this.dgvGetAllAppointments.AllowUserToAddRows = false;
            this.dgvGetAllAppointments.AllowUserToDeleteRows = false;
            this.dgvGetAllAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetAllAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetAllAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllAppointments.Location = new System.Drawing.Point(0, 0);
            this.dgvGetAllAppointments.Name = "dgvGetAllAppointments";
            this.dgvGetAllAppointments.ReadOnly = true;
            this.dgvGetAllAppointments.Size = new System.Drawing.Size(912, 389);
            this.dgvGetAllAppointments.TabIndex = 0;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnDeleteAppointment.FlatAppearance.BorderSize = 0;
            this.btnDeleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAppointment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(764, 402);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(148, 52);
            this.btnDeleteAppointment.TabIndex = 19;
            this.btnDeleteAppointment.Text = "Randevu Sil";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // FormPatientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1011, 690);
            this.Controls.Add(this.pnlAppointmentList);
            this.Controls.Add(this.pnlGetAnAppointment);
            this.Controls.Add(this.btnAllAppointments);
            this.Controls.Add(this.btnGetAnAppointment);
            this.Controls.Add(this.lblPatientNameAndSurname);
            this.Name = "FormPatientPanel";
            this.Text = "FormPatientPanel";
            this.Load += new System.EventHandler(this.FormPatientPanel_Load);
            this.pnlGetAnAppointment.ResumeLayout(false);
            this.pnlGetAnAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorList)).EndInit();
            this.pnlAnAppointmentInfos.ResumeLayout(false);
            this.pnlAnAppointmentInfos.PerformLayout();
            this.pnlAppointmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGetAnAppointment;
        private System.Windows.Forms.Button btnGetDoctorSession;
        private System.Windows.Forms.DataGridView dgvDoctorList;
        private System.Windows.Forms.Panel pnlAnAppointmentInfos;
        private System.Windows.Forms.Label lblAppointmentPatientDate;
        private System.Windows.Forms.Label lblAppointmentPatientDoctorName;
        private System.Windows.Forms.Label lblAppointmentPatientPolyclinicName;
        private System.Windows.Forms.Label lblAppointmentPatientDepartmentName;
        private System.Windows.Forms.Label lblAppointmentPatientHospitalName;
        private System.Windows.Forms.Label lblAppointmentPatientName;
        private System.Windows.Forms.Button btnComplateAppointment;
        private System.Windows.Forms.Label lblAppointmentInfoDate;
        private System.Windows.Forms.Label lblAppointmentInfoDoctorName;
        private System.Windows.Forms.Label lblAppointmentInfoPolyclinicName;
        private System.Windows.Forms.Label lblAppointmentInfoDepartmentName;
        private System.Windows.Forms.Label lblAppointmentInfoHospitalName;
        private System.Windows.Forms.Label lblAppointmentInfoName;
        private System.Windows.Forms.Button btnDoctorsDepartmanQuery;
        private System.Windows.Forms.Label lblAppointmentPolyclinicName;
        private System.Windows.Forms.ComboBox cmbAppointmentPolyclinicName;
        private System.Windows.Forms.Label lblAppointmentDepartmentName;
        private System.Windows.Forms.ComboBox cmbAppointmentDepartmentName;
        private System.Windows.Forms.Label lblAppointmentHospitalName;
        private System.Windows.Forms.ComboBox cmbAppointmentHospitalName;
        private System.Windows.Forms.Button btnAllAppointments;
        private System.Windows.Forms.Button btnGetAnAppointment;
        private System.Windows.Forms.Label lblPatientNameAndSurname;
        private System.Windows.Forms.Label lblAppointmentPatientSession;
        private System.Windows.Forms.Label lblAppointmentInfoSession;
        private System.Windows.Forms.Button btnDoctorsPolyclinicQuery;
        private System.Windows.Forms.Panel pnlAppointmentList;
        private System.Windows.Forms.DataGridView dgvGetAllAppointments;
        private System.Windows.Forms.Button btnDeleteAppointment;
    }
}