namespace _03_1st_stage_final_test
{
    partial class FrmQuestion02
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
            this.lblInstallmentValue = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblDaysOverdue = new System.Windows.Forms.Label();
            this.btnCalculateInstallmentAmount = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtInstallmentValue = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtDaysOverdue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstallmentValue
            // 
            this.lblInstallmentValue.AutoSize = true;
            this.lblInstallmentValue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallmentValue.Location = new System.Drawing.Point(12, 67);
            this.lblInstallmentValue.Name = "lblInstallmentValue";
            this.lblInstallmentValue.Size = new System.Drawing.Size(193, 28);
            this.lblInstallmentValue.TabIndex = 1;
            this.lblInstallmentValue.Text = "Valor da prestação:";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(12, 133);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(67, 28);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Juros:";
            // 
            // lblDaysOverdue
            // 
            this.lblDaysOverdue.AutoSize = true;
            this.lblDaysOverdue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOverdue.Location = new System.Drawing.Point(12, 205);
            this.lblDaysOverdue.Name = "lblDaysOverdue";
            this.lblDaysOverdue.Size = new System.Drawing.Size(158, 28);
            this.lblDaysOverdue.TabIndex = 3;
            this.lblDaysOverdue.Text = "Dias em atraso:";
            // 
            // btnCalculateInstallmentAmount
            // 
            this.btnCalculateInstallmentAmount.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculateInstallmentAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateInstallmentAmount.ForeColor = System.Drawing.Color.White;
            this.btnCalculateInstallmentAmount.Location = new System.Drawing.Point(12, 329);
            this.btnCalculateInstallmentAmount.Name = "btnCalculateInstallmentAmount";
            this.btnCalculateInstallmentAmount.Size = new System.Drawing.Size(126, 46);
            this.btnCalculateInstallmentAmount.TabIndex = 9;
            this.btnCalculateInstallmentAmount.Text = "Calcular";
            this.btnCalculateInstallmentAmount.UseVisualStyleBackColor = false;
            this.btnCalculateInstallmentAmount.Click += new System.EventHandler(this.btnCalculateInstallmentAmount_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 435);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 10;
            // 
            // txtInstallmentValue
            // 
            this.txtInstallmentValue.Location = new System.Drawing.Point(553, 69);
            this.txtInstallmentValue.Name = "txtInstallmentValue";
            this.txtInstallmentValue.Size = new System.Drawing.Size(227, 30);
            this.txtInstallmentValue.TabIndex = 11;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(553, 135);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(227, 30);
            this.txtInterest.TabIndex = 12;
            // 
            // txtDaysOverdue
            // 
            this.txtDaysOverdue.Location = new System.Drawing.Point(553, 207);
            this.txtDaysOverdue.Name = "txtDaysOverdue";
            this.txtDaysOverdue.Size = new System.Drawing.Size(227, 30);
            this.txtDaysOverdue.TabIndex = 13;
            // 
            // FrmQuestion02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(792, 515);
            this.Controls.Add(this.txtDaysOverdue);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtInstallmentValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateInstallmentAmount);
            this.Controls.Add(this.lblDaysOverdue);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblInstallmentValue);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuestion02";
            this.Text = "Questão 02 - Calculadora de prestações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstallmentValue;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblDaysOverdue;
        private System.Windows.Forms.Button btnCalculateInstallmentAmount;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInstallmentValue;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtDaysOverdue;
    }
}