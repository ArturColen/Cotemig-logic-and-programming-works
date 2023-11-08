namespace _03_1st_stage_final_test
{
    partial class FrmQuestion03
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
            this.txtCurrentSalary = new System.Windows.Forms.TextBox();
            this.lblCurrentSalary = new System.Windows.Forms.Label();
            this.btnCalculateSalaryIncrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurrentSalary
            // 
            this.txtCurrentSalary.Location = new System.Drawing.Point(529, 96);
            this.txtCurrentSalary.Name = "txtCurrentSalary";
            this.txtCurrentSalary.Size = new System.Drawing.Size(227, 30);
            this.txtCurrentSalary.TabIndex = 13;
            // 
            // lblCurrentSalary
            // 
            this.lblCurrentSalary.AutoSize = true;
            this.lblCurrentSalary.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSalary.Location = new System.Drawing.Point(12, 94);
            this.lblCurrentSalary.Name = "lblCurrentSalary";
            this.lblCurrentSalary.Size = new System.Drawing.Size(338, 28);
            this.lblCurrentSalary.TabIndex = 12;
            this.lblCurrentSalary.Text = "Digite o valor do seu salário atual:";
            // 
            // btnCalculateSalaryIncrease
            // 
            this.btnCalculateSalaryIncrease.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculateSalaryIncrease.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSalaryIncrease.ForeColor = System.Drawing.Color.White;
            this.btnCalculateSalaryIncrease.Location = new System.Drawing.Point(17, 310);
            this.btnCalculateSalaryIncrease.Name = "btnCalculateSalaryIncrease";
            this.btnCalculateSalaryIncrease.Size = new System.Drawing.Size(126, 46);
            this.btnCalculateSalaryIncrease.TabIndex = 14;
            this.btnCalculateSalaryIncrease.Text = "Calcular";
            this.btnCalculateSalaryIncrease.UseVisualStyleBackColor = false;
            this.btnCalculateSalaryIncrease.Click += new System.EventHandler(this.btnCalculateSalaryIncrease_Click);
            // 
            // FrmQuestion03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(768, 509);
            this.Controls.Add(this.btnCalculateSalaryIncrease);
            this.Controls.Add(this.txtCurrentSalary);
            this.Controls.Add(this.lblCurrentSalary);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmQuestion03";
            this.Text = "Questão 03 - Calcular aumento salarial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentSalary;
        private System.Windows.Forms.Label lblCurrentSalary;
        private System.Windows.Forms.Button btnCalculateSalaryIncrease;
    }
}