namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    partial class FormPatientTest
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
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            this.pnlSessionList = new System.Windows.Forms.Panel();
            this.mtcSessions = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSaveAppointment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSaveAppointment.FlatAppearance.BorderSize = 0;
            this.btnSaveAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAppointment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSaveAppointment.Location = new System.Drawing.Point(479, 276);
            this.btnSaveAppointment.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(120, 39);
            this.btnSaveAppointment.TabIndex = 21;
            this.btnSaveAppointment.Text = "Kaydet";
            this.btnSaveAppointment.UseVisualStyleBackColor = false;
            this.btnSaveAppointment.Click += new System.EventHandler(this.btnSaveAppointment_Click);
            // 
            // pnlSessionList
            // 
            this.pnlSessionList.Location = new System.Drawing.Point(276, 40);
            this.pnlSessionList.Name = "pnlSessionList";
            this.pnlSessionList.Size = new System.Drawing.Size(351, 215);
            this.pnlSessionList.TabIndex = 22;
            // 
            // mtcSessions
            // 
            this.mtcSessions.BackColor = System.Drawing.Color.White;
            this.mtcSessions.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mtcSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtcSessions.ForeColor = System.Drawing.Color.Black;
            this.mtcSessions.Location = new System.Drawing.Point(18, 18);
            this.mtcSessions.MinDate = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.mtcSessions.Name = "mtcSessions";
            this.mtcSessions.TabIndex = 23;
            this.mtcSessions.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.mtcSessions.TitleForeColor = System.Drawing.Color.Black;
            this.mtcSessions.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mtcSessions_DateChanged_1);
            // 
            // FormPatientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(639, 329);
            this.Controls.Add(this.mtcSessions);
            this.Controls.Add(this.pnlSessionList);
            this.Controls.Add(this.btnSaveAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPatientTest";
            this.Load += new System.EventHandler(this.FormPatientTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAppointment;
        private System.Windows.Forms.Panel pnlSessionList;
        private System.Windows.Forms.MonthCalendar mtcSessions;
    }
}