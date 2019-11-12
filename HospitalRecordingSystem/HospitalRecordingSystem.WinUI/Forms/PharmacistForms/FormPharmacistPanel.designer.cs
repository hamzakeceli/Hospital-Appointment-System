namespace HospitalRecordingSystem.WinUI.Forms
{
    partial class FormPharmacistPanel
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
            this.btnRecipeNumberQuery = new System.Windows.Forms.Button();
            this.txtRecipeNumber = new System.Windows.Forms.TextBox();
            this.lblRecipeNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecipeNumberQuery
            // 
            this.btnRecipeNumberQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRecipeNumberQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnRecipeNumberQuery.FlatAppearance.BorderSize = 0;
            this.btnRecipeNumberQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipeNumberQuery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecipeNumberQuery.ForeColor = System.Drawing.Color.White;
            this.btnRecipeNumberQuery.Location = new System.Drawing.Point(53, 166);
            this.btnRecipeNumberQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnRecipeNumberQuery.Name = "btnRecipeNumberQuery";
            this.btnRecipeNumberQuery.Size = new System.Drawing.Size(306, 52);
            this.btnRecipeNumberQuery.TabIndex = 14;
            this.btnRecipeNumberQuery.Text = "SORGULA";
            this.btnRecipeNumberQuery.UseVisualStyleBackColor = false;
            this.btnRecipeNumberQuery.Click += new System.EventHandler(this.btnRecipeNumberQuery_Click);
            // 
            // txtRecipeNumber
            // 
            this.txtRecipeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtRecipeNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecipeNumber.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecipeNumber.ForeColor = System.Drawing.Color.LightGray;
            this.txtRecipeNumber.Location = new System.Drawing.Point(34, 97);
            this.txtRecipeNumber.Name = "txtRecipeNumber";
            this.txtRecipeNumber.Size = new System.Drawing.Size(360, 41);
            this.txtRecipeNumber.TabIndex = 13;
            // 
            // lblRecipeNumber
            // 
            this.lblRecipeNumber.AutoSize = true;
            this.lblRecipeNumber.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecipeNumber.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecipeNumber.Location = new System.Drawing.Point(92, 42);
            this.lblRecipeNumber.Name = "lblRecipeNumber";
            this.lblRecipeNumber.Size = new System.Drawing.Size(248, 33);
            this.lblRecipeNumber.TabIndex = 12;
            this.lblRecipeNumber.Text = "Reçete Numarası ";
            // 
            // FormPharmacistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(428, 260);
            this.Controls.Add(this.btnRecipeNumberQuery);
            this.Controls.Add(this.txtRecipeNumber);
            this.Controls.Add(this.lblRecipeNumber);
            this.Name = "FormPharmacistPanel";
            this.Text = "FormPharmacistPanel";
            this.Load += new System.EventHandler(this.FormPharmacistPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecipeNumberQuery;
        private System.Windows.Forms.TextBox txtRecipeNumber;
        private System.Windows.Forms.Label lblRecipeNumber;
    }
}