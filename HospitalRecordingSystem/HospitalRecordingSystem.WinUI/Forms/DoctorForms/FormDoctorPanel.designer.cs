namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    partial class FormDoctorPanel
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
            this.btnTodaysAppointments = new System.Windows.Forms.Button();
            this.btnCompletedAppointments = new System.Windows.Forms.Button();
            this.pnlCompletedAppointments = new System.Windows.Forms.Panel();
            this.dvgCompletedAppointments = new System.Windows.Forms.DataGridView();
            this.pnlTodaysAppointments = new System.Windows.Forms.Panel();
            this.pnlPatientStatus = new System.Windows.Forms.Panel();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.btnTestRequest = new System.Windows.Forms.Button();
            this.btnRecipeCreate = new System.Windows.Forms.Button();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.lblInfoDiagnosis = new System.Windows.Forms.Label();
            this.cmbExaminationStatus = new System.Windows.Forms.ComboBox();
            this.lblInfoExaminationStatus = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblInfoPatientName = new System.Windows.Forms.Label();
            this.pnlSessionList = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlCompletedAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompletedAppointments)).BeginInit();
            this.pnlTodaysAppointments.SuspendLayout();
            this.pnlPatientStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTodaysAppointments
            // 
            this.btnTodaysAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnTodaysAppointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnTodaysAppointments.FlatAppearance.BorderSize = 0;
            this.btnTodaysAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodaysAppointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTodaysAppointments.ForeColor = System.Drawing.Color.White;
            this.btnTodaysAppointments.Location = new System.Drawing.Point(802, 14);
            this.btnTodaysAppointments.Margin = new System.Windows.Forms.Padding(5);
            this.btnTodaysAppointments.Name = "btnTodaysAppointments";
            this.btnTodaysAppointments.Size = new System.Drawing.Size(148, 52);
            this.btnTodaysAppointments.TabIndex = 3;
            this.btnTodaysAppointments.Text = "Günün Muayeneleri";
            this.btnTodaysAppointments.UseVisualStyleBackColor = false;
            this.btnTodaysAppointments.Click += new System.EventHandler(this.btnTodaysAppointments_Click);
            // 
            // btnCompletedAppointments
            // 
            this.btnCompletedAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnCompletedAppointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnCompletedAppointments.FlatAppearance.BorderSize = 0;
            this.btnCompletedAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletedAppointments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompletedAppointments.ForeColor = System.Drawing.Color.White;
            this.btnCompletedAppointments.Location = new System.Drawing.Point(957, 14);
            this.btnCompletedAppointments.Margin = new System.Windows.Forms.Padding(5);
            this.btnCompletedAppointments.Name = "btnCompletedAppointments";
            this.btnCompletedAppointments.Size = new System.Drawing.Size(148, 52);
            this.btnCompletedAppointments.TabIndex = 2;
            this.btnCompletedAppointments.Text = "Tamamlanmış Muayeneler";
            this.btnCompletedAppointments.UseVisualStyleBackColor = false;
            this.btnCompletedAppointments.Click += new System.EventHandler(this.btnCompletedAppointments_Click);
            // 
            // pnlCompletedAppointments
            // 
            this.pnlCompletedAppointments.Controls.Add(this.dvgCompletedAppointments);
            this.pnlCompletedAppointments.Location = new System.Drawing.Point(14, 88);
            this.pnlCompletedAppointments.Name = "pnlCompletedAppointments";
            this.pnlCompletedAppointments.Size = new System.Drawing.Size(1094, 538);
            this.pnlCompletedAppointments.TabIndex = 4;
            this.pnlCompletedAppointments.Visible = false;
            // 
            // dvgCompletedAppointments
            // 
            this.dvgCompletedAppointments.AllowUserToAddRows = false;
            this.dvgCompletedAppointments.AllowUserToDeleteRows = false;
            this.dvgCompletedAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCompletedAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgCompletedAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompletedAppointments.Location = new System.Drawing.Point(0, 0);
            this.dvgCompletedAppointments.Name = "dvgCompletedAppointments";
            this.dvgCompletedAppointments.ReadOnly = true;
            this.dvgCompletedAppointments.Size = new System.Drawing.Size(1094, 538);
            this.dvgCompletedAppointments.TabIndex = 0;
            // 
            // pnlTodaysAppointments
            // 
            this.pnlTodaysAppointments.Controls.Add(this.pnlPatientStatus);
            this.pnlTodaysAppointments.Controls.Add(this.pnlSessionList);
            this.pnlTodaysAppointments.Location = new System.Drawing.Point(14, 88);
            this.pnlTodaysAppointments.Name = "pnlTodaysAppointments";
            this.pnlTodaysAppointments.Size = new System.Drawing.Size(1094, 538);
            this.pnlTodaysAppointments.TabIndex = 5;
            // 
            // pnlPatientStatus
            // 
            this.pnlPatientStatus.Controls.Add(this.btnSaveAppointment);
            this.pnlPatientStatus.Controls.Add(this.btnTestRequest);
            this.pnlPatientStatus.Controls.Add(this.btnRecipeCreate);
            this.pnlPatientStatus.Controls.Add(this.cmbDiagnosis);
            this.pnlPatientStatus.Controls.Add(this.lblInfoDiagnosis);
            this.pnlPatientStatus.Controls.Add(this.cmbExaminationStatus);
            this.pnlPatientStatus.Controls.Add(this.lblInfoExaminationStatus);
            this.pnlPatientStatus.Controls.Add(this.lblPatientName);
            this.pnlPatientStatus.Controls.Add(this.lblInfoPatientName);
            this.pnlPatientStatus.Location = new System.Drawing.Point(15, 358);
            this.pnlPatientStatus.Name = "pnlPatientStatus";
            this.pnlPatientStatus.Size = new System.Drawing.Size(1069, 177);
            this.pnlPatientStatus.TabIndex = 1;
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSaveAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSaveAppointment.FlatAppearance.BorderSize = 0;
            this.btnSaveAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.Location = new System.Drawing.Point(894, 100);
            this.btnSaveAppointment.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(148, 52);
            this.btnSaveAppointment.TabIndex = 9;
            this.btnSaveAppointment.Text = "Kaydet";
            this.btnSaveAppointment.UseVisualStyleBackColor = false;
            this.btnSaveAppointment.Click += new System.EventHandler(this.BtnSaveAppointment_Click);
            // 
            // btnTestRequest
            // 
            this.btnTestRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnTestRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnTestRequest.FlatAppearance.BorderSize = 0;
            this.btnTestRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestRequest.ForeColor = System.Drawing.Color.White;
            this.btnTestRequest.Location = new System.Drawing.Point(19, 100);
            this.btnTestRequest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTestRequest.Name = "btnTestRequest";
            this.btnTestRequest.Size = new System.Drawing.Size(148, 52);
            this.btnTestRequest.TabIndex = 9;
            this.btnTestRequest.Text = "Tahlil İste";
            this.btnTestRequest.UseVisualStyleBackColor = false;
            this.btnTestRequest.Click += new System.EventHandler(this.btnTestRequest_Click);
            // 
            // btnRecipeCreate
            // 
            this.btnRecipeCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRecipeCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnRecipeCreate.FlatAppearance.BorderSize = 0;
            this.btnRecipeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipeCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecipeCreate.ForeColor = System.Drawing.Color.White;
            this.btnRecipeCreate.Location = new System.Drawing.Point(454, 100);
            this.btnRecipeCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnRecipeCreate.Name = "btnRecipeCreate";
            this.btnRecipeCreate.Size = new System.Drawing.Size(148, 52);
            this.btnRecipeCreate.TabIndex = 8;
            this.btnRecipeCreate.Text = "Reçete Oluştur";
            this.btnRecipeCreate.UseVisualStyleBackColor = false;
            this.btnRecipeCreate.Click += new System.EventHandler(this.btnRecipeCreate_Click);
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbDiagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDiagnosis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbDiagnosis.ForeColor = System.Drawing.Color.LightGray;
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Location = new System.Drawing.Point(848, 17);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(194, 29);
            this.cmbDiagnosis.TabIndex = 7;
            // 
            // lblInfoDiagnosis
            // 
            this.lblInfoDiagnosis.AutoSize = true;
            this.lblInfoDiagnosis.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInfoDiagnosis.ForeColor = System.Drawing.Color.LightGray;
            this.lblInfoDiagnosis.Location = new System.Drawing.Point(781, 20);
            this.lblInfoDiagnosis.Name = "lblInfoDiagnosis";
            this.lblInfoDiagnosis.Size = new System.Drawing.Size(61, 21);
            this.lblInfoDiagnosis.TabIndex = 6;
            this.lblInfoDiagnosis.Text = "Teşhis :";
            // 
            // cmbExaminationStatus
            // 
            this.cmbExaminationStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbExaminationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExaminationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExaminationStatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbExaminationStatus.ForeColor = System.Drawing.Color.LightGray;
            this.cmbExaminationStatus.FormattingEnabled = true;
            this.cmbExaminationStatus.Location = new System.Drawing.Point(531, 17);
            this.cmbExaminationStatus.Name = "cmbExaminationStatus";
            this.cmbExaminationStatus.Size = new System.Drawing.Size(194, 29);
            this.cmbExaminationStatus.TabIndex = 5;
            // 
            // lblInfoExaminationStatus
            // 
            this.lblInfoExaminationStatus.AutoSize = true;
            this.lblInfoExaminationStatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInfoExaminationStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblInfoExaminationStatus.Location = new System.Drawing.Point(367, 20);
            this.lblInfoExaminationStatus.Name = "lblInfoExaminationStatus";
            this.lblInfoExaminationStatus.Size = new System.Drawing.Size(158, 21);
            this.lblInfoExaminationStatus.TabIndex = 4;
            this.lblInfoExaminationStatus.Text = "Muayene Durumu :";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPatientName.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientName.Location = new System.Drawing.Point(116, 20);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(188, 21);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Mehmet YALÇINKAYA";
            // 
            // lblInfoPatientName
            // 
            this.lblInfoPatientName.AutoSize = true;
            this.lblInfoPatientName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInfoPatientName.ForeColor = System.Drawing.Color.LightGray;
            this.lblInfoPatientName.Location = new System.Drawing.Point(15, 20);
            this.lblInfoPatientName.Name = "lblInfoPatientName";
            this.lblInfoPatientName.Size = new System.Drawing.Size(95, 21);
            this.lblInfoPatientName.TabIndex = 2;
            this.lblInfoPatientName.Text = "Hasta Adı :";
            // 
            // pnlSessionList
            // 
            this.pnlSessionList.Location = new System.Drawing.Point(280, 19);
            this.pnlSessionList.Name = "pnlSessionList";
            this.pnlSessionList.Size = new System.Drawing.Size(490, 333);
            this.pnlSessionList.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(12, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(146, 29);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Hoşgeldiniz ";
            // 
            // FormDoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1119, 638);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlTodaysAppointments);
            this.Controls.Add(this.pnlCompletedAppointments);
            this.Controls.Add(this.btnTodaysAppointments);
            this.Controls.Add(this.btnCompletedAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDoctorPanel";
            this.Load += new System.EventHandler(this.FormDoctorPanel_Load);
            this.pnlCompletedAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompletedAppointments)).EndInit();
            this.pnlTodaysAppointments.ResumeLayout(false);
            this.pnlPatientStatus.ResumeLayout(false);
            this.pnlPatientStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodaysAppointments;
        private System.Windows.Forms.Button btnCompletedAppointments;
        private System.Windows.Forms.Panel pnlCompletedAppointments;
        private System.Windows.Forms.Panel pnlTodaysAppointments;
        private System.Windows.Forms.Panel pnlSessionList;
        private System.Windows.Forms.Panel pnlPatientStatus;
        private System.Windows.Forms.Label lblInfoPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblInfoExaminationStatus;
        private System.Windows.Forms.ComboBox cmbExaminationStatus;
        private System.Windows.Forms.Label lblInfoDiagnosis;
        private System.Windows.Forms.DataGridView dvgCompletedAppointments;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.Button btnTestRequest;
        private System.Windows.Forms.Button btnRecipeCreate;
        private System.Windows.Forms.Button btnSaveAppointment;
        private System.Windows.Forms.Label lblWelcome;
    }
}