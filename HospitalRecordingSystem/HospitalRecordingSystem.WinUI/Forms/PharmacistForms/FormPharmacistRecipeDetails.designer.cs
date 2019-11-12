namespace HospitalAppointmentSystem.WinUI.Forms
{
    partial class FormPharmacistRecipeDetails
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
            this.lblMedicineList = new System.Windows.Forms.Label();
            this.lblPatientNameVariable = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblRecipeNumber = new System.Windows.Forms.Label();
            this.cmbRecipeNumbers = new System.Windows.Forms.ComboBox();
            this.dvgMedicineList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicineList
            // 
            this.lblMedicineList.AutoSize = true;
            this.lblMedicineList.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedicineList.ForeColor = System.Drawing.Color.LightGray;
            this.lblMedicineList.Location = new System.Drawing.Point(12, 172);
            this.lblMedicineList.Name = "lblMedicineList";
            this.lblMedicineList.Size = new System.Drawing.Size(141, 33);
            this.lblMedicineList.TabIndex = 27;
            this.lblMedicineList.Text = "İlaç Listesi";
            // 
            // lblPatientNameVariable
            // 
            this.lblPatientNameVariable.AutoSize = true;
            this.lblPatientNameVariable.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientNameVariable.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientNameVariable.Location = new System.Drawing.Point(182, 106);
            this.lblPatientNameVariable.Name = "lblPatientNameVariable";
            this.lblPatientNameVariable.Size = new System.Drawing.Size(147, 33);
            this.lblPatientNameVariable.TabIndex = 24;
            this.lblPatientNameVariable.Text = "HASTA ADI";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientName.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientName.Location = new System.Drawing.Point(12, 106);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(154, 33);
            this.lblPatientName.TabIndex = 21;
            this.lblPatientName.Text = "Hasta Adı :";
            // 
            // lblRecipeNumber
            // 
            this.lblRecipeNumber.AutoSize = true;
            this.lblRecipeNumber.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecipeNumber.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecipeNumber.Location = new System.Drawing.Point(12, 25);
            this.lblRecipeNumber.Name = "lblRecipeNumber";
            this.lblRecipeNumber.Size = new System.Drawing.Size(241, 33);
            this.lblRecipeNumber.TabIndex = 20;
            this.lblRecipeNumber.Text = "Reçete Numarası";
            // 
            // cmbRecipeNumbers
            // 
            this.cmbRecipeNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.cmbRecipeNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecipeNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRecipeNumbers.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRecipeNumbers.ForeColor = System.Drawing.Color.LightGray;
            this.cmbRecipeNumbers.FormattingEnabled = true;
            this.cmbRecipeNumbers.Location = new System.Drawing.Point(273, 25);
            this.cmbRecipeNumbers.Name = "cmbRecipeNumbers";
            this.cmbRecipeNumbers.Size = new System.Drawing.Size(198, 41);
            this.cmbRecipeNumbers.TabIndex = 19;
            this.cmbRecipeNumbers.SelectedIndexChanged += new System.EventHandler(this.cmbRecipeNumbers_SelectedIndexChanged);
            // 
            // dvgMedicineList
            // 
            this.dvgMedicineList.AllowUserToAddRows = false;
            this.dvgMedicineList.AllowUserToDeleteRows = false;
            this.dvgMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMedicineList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMedicineList.Location = new System.Drawing.Point(12, 221);
            this.dvgMedicineList.Name = "dvgMedicineList";
            this.dvgMedicineList.ReadOnly = true;
            this.dvgMedicineList.Size = new System.Drawing.Size(459, 298);
            this.dvgMedicineList.TabIndex = 28;
            // 
            // FormPharmacistRecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(490, 531);
            this.Controls.Add(this.dvgMedicineList);
            this.Controls.Add(this.lblMedicineList);
            this.Controls.Add(this.lblPatientNameVariable);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblRecipeNumber);
            this.Controls.Add(this.cmbRecipeNumbers);
            this.Name = "FormPharmacistRecipeDetails";
            this.Text = "FormPharmacistRecipeDetails";
            this.Load += new System.EventHandler(this.FormPharmacistRecipeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMedicineList;
        private System.Windows.Forms.Label lblPatientNameVariable;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblRecipeNumber;
        private System.Windows.Forms.ComboBox cmbRecipeNumbers;
        private System.Windows.Forms.DataGridView dvgMedicineList;
    }
}