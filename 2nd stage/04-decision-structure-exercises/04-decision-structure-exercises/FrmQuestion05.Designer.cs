namespace _04_decision_structure_exercises
{
    partial class FrmQuestion05
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtSnackPrice = new System.Windows.Forms.TextBox();
            this.lblSnackPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 427);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(228, 120);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(175, 22);
            this.txtAmountPaid.TabIndex = 13;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(12, 123);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(195, 16);
            this.lblAmountPaid.TabIndex = 12;
            this.lblAmountPaid.Text = "Digite o valor que foi pago:";
            // 
            // txtSnackPrice
            // 
            this.txtSnackPrice.Location = new System.Drawing.Point(228, 49);
            this.txtSnackPrice.Name = "txtSnackPrice";
            this.txtSnackPrice.Size = new System.Drawing.Size(175, 22);
            this.txtSnackPrice.TabIndex = 11;
            // 
            // lblSnackPrice
            // 
            this.lblSnackPrice.AutoSize = true;
            this.lblSnackPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackPrice.Location = new System.Drawing.Point(12, 52);
            this.lblSnackPrice.Name = "lblSnackPrice";
            this.lblSnackPrice.Size = new System.Drawing.Size(210, 16);
            this.lblSnackPrice.TabIndex = 10;
            this.lblSnackPrice.Text = "Digite o valor total do lanche:";
            // 
            // FrmQuestion05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtSnackPrice);
            this.Controls.Add(this.lblSnackPrice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion05";
            this.Text = "Exercício 05 - Calcular a necessidade de troco em compra de lanches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtSnackPrice;
        private System.Windows.Forms.Label lblSnackPrice;
    }
}