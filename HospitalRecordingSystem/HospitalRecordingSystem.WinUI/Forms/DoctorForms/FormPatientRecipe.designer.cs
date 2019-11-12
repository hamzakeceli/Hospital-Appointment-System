namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    partial class FormPatientRecipe
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
            this.lblInfoMedicineName = new System.Windows.Forms.Label();
            this.cmbMedicineName = new System.Windows.Forms.ComboBox();
            this.btnMedicineAdd = new System.Windows.Forms.Button();
            this.lblRecipeNo = new System.Windows.Forms.Label();
            this.btnMedicineListSave = new System.Windows.Forms.Button();
            this.lstMedicineList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblInfoMedicineName
            // 
            this.lblInfoMedicineName.AutoSize = true;
            this.lblInfoMedicineName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInfoMedicineName.ForeColor = System.Drawing.Color.LightGray;
            this.lblInfoMedicineName.Location = new System.Drawing.Point(12, 69);
            this.lblInfoMedicineName.Name = "lblInfoMedicineName";
            this.lblInfoMedicineName.Size = new System.Drawing.Size(78, 21);
            this.lblInfoMedicineName.TabIndex = 12;
            this.lblInfoMedicineName.Text = "İlaç Adı :";
            // 
            // cmbMedicineName
            // 
            this.cmbMedicineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbMedicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedicineName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmbMedicineName.ForeColor = System.Drawing.Color.LightGray;
            this.cmbMedicineName.FormattingEnabled = true;
            this.cmbMedicineName.Location = new System.Drawing.Point(96, 66);
            this.cmbMedicineName.Name = "cmbMedicineName";
            this.cmbMedicineName.Size = new System.Drawing.Size(171, 29);
            this.cmbMedicineName.TabIndex = 11;
            // 
            // btnMedicineAdd
            // 
            this.btnMedicineAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnMedicineAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnMedicineAdd.FlatAppearance.BorderSize = 0;
            this.btnMedicineAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedicineAdd.ForeColor = System.Drawing.Color.White;
            this.btnMedicineAdd.Location = new System.Drawing.Point(285, 62);
            this.btnMedicineAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnMedicineAdd.Name = "btnMedicineAdd";
            this.btnMedicineAdd.Size = new System.Drawing.Size(129, 35);
            this.btnMedicineAdd.TabIndex = 10;
            this.btnMedicineAdd.Text = "İlaç Ekle";
            this.btnMedicineAdd.UseVisualStyleBackColor = false;
            this.btnMedicineAdd.Click += new System.EventHandler(this.btnMedicineAdd_Click);
            // 
            // lblRecipeNo
            // 
            this.lblRecipeNo.AutoSize = true;
            this.lblRecipeNo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblRecipeNo.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecipeNo.Location = new System.Drawing.Point(12, 9);
            this.lblRecipeNo.Name = "lblRecipeNo";
            this.lblRecipeNo.Size = new System.Drawing.Size(148, 21);
            this.lblRecipeNo.TabIndex = 9;
            this.lblRecipeNo.Text = "Reçete Numarası:";
            // 
            // btnMedicineListSave
            // 
            this.btnMedicineListSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnMedicineListSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMedicineListSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnMedicineListSave.FlatAppearance.BorderSize = 0;
            this.btnMedicineListSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineListSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedicineListSave.ForeColor = System.Drawing.Color.White;
            this.btnMedicineListSave.Location = new System.Drawing.Point(283, 327);
            this.btnMedicineListSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnMedicineListSave.Name = "btnMedicineListSave";
            this.btnMedicineListSave.Size = new System.Drawing.Size(129, 35);
            this.btnMedicineListSave.TabIndex = 14;
            this.btnMedicineListSave.Text = "Kaydet";
            this.btnMedicineListSave.UseVisualStyleBackColor = false;
            // 
            // lstMedicineList
            // 
            this.lstMedicineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstMedicineList.FormattingEnabled = true;
            this.lstMedicineList.ItemHeight = 20;
            this.lstMedicineList.Location = new System.Drawing.Point(96, 111);
            this.lstMedicineList.Name = "lstMedicineList";
            this.lstMedicineList.Size = new System.Drawing.Size(171, 204);
            this.lstMedicineList.TabIndex = 15;
            // 
            // FormPatientRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(417, 373);
            this.Controls.Add(this.lstMedicineList);
            this.Controls.Add(this.btnMedicineListSave);
            this.Controls.Add(this.lblInfoMedicineName);
            this.Controls.Add(this.cmbMedicineName);
            this.Controls.Add(this.btnMedicineAdd);
            this.Controls.Add(this.lblRecipeNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPatientRecipe";
            this.Load += new System.EventHandler(this.FormPatientRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfoMedicineName;
        private System.Windows.Forms.ComboBox cmbMedicineName;
        private System.Windows.Forms.Button btnMedicineAdd;
        private System.Windows.Forms.Label lblRecipeNo;
        private System.Windows.Forms.Button btnMedicineListSave;
        private System.Windows.Forms.ListBox lstMedicineList;
    }
}