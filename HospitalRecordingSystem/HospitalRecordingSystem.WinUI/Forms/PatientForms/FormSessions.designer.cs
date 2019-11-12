namespace HospitalRecordingSystem.WinUI.Forms.PatientForms
{
    partial class FormSessions
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
            this.pnlSessionList = new System.Windows.Forms.Panel();
            this.btnSelectSession = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // pnlSessionList
            // 
            this.pnlSessionList.Location = new System.Drawing.Point(289, 18);
            this.pnlSessionList.Name = "pnlSessionList";
            this.pnlSessionList.Size = new System.Drawing.Size(352, 317);
            this.pnlSessionList.TabIndex = 1;
            // 
            // btnSelectSession
            // 
            this.btnSelectSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSelectSession.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnSelectSession.FlatAppearance.BorderSize = 0;
            this.btnSelectSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSession.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectSession.ForeColor = System.Drawing.Color.White;
            this.btnSelectSession.Location = new System.Drawing.Point(512, 344);
            this.btnSelectSession.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectSession.Name = "btnSelectSession";
            this.btnSelectSession.Size = new System.Drawing.Size(124, 40);
            this.btnSelectSession.TabIndex = 16;
            this.btnSelectSession.Text = "Tamam";
            this.btnSelectSession.UseVisualStyleBackColor = false;
            this.btnSelectSession.Click += new System.EventHandler(this.btnSelectSession_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.Color.Black;
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.MinDate = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 17;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.monthCalendar.TitleForeColor = System.Drawing.Color.Black;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // FormSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(650, 392);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnSelectSession);
            this.Controls.Add(this.pnlSessionList);
            this.Name = "FormSessions";
            this.Text = "FormSessions";
            this.Load += new System.EventHandler(this.FormSessions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSessionList;
        private System.Windows.Forms.Button btnSelectSession;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}