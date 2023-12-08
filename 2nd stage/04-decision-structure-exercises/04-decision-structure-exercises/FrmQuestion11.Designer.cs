namespace _04_decision_structure_exercises
{
    partial class FrmQuestion11
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
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblCodification1 = new System.Windows.Forms.Label();
            this.lblCodification2 = new System.Windows.Forms.Label();
            this.lblCodification3 = new System.Windows.Forms.Label();
            this.lblCodification4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 463);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(451, 117);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(175, 22);
            this.txtPaymentMethod.TabIndex = 28;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(12, 120);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(433, 16);
            this.lblPaymentMethod.TabIndex = 27;
            this.lblPaymentMethod.Text = "Digite a forma de pagamento (a partir da codificação abaixo):";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(451, 58);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(175, 22);
            this.txtProductPrice.TabIndex = 26;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(22, 61);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(188, 16);
            this.lblProductPrice.TabIndex = 25;
            this.lblProductPrice.Text = "Digite o preço do produto:";
            // 
            // lblCodification1
            // 
            this.lblCodification1.AutoSize = true;
            this.lblCodification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodification1.Location = new System.Drawing.Point(12, 177);
            this.lblCodification1.Name = "lblCodification1";
            this.lblCodification1.Size = new System.Drawing.Size(240, 16);
            this.lblCodification1.TabIndex = 30;
            this.lblCodification1.Text = "1 - À vista em dinheiro ou cheque;";
            // 
            // lblCodification2
            // 
            this.lblCodification2.AutoSize = true;
            this.lblCodification2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodification2.Location = new System.Drawing.Point(12, 230);
            this.lblCodification2.Name = "lblCodification2";
            this.lblCodification2.Size = new System.Drawing.Size(222, 16);
            this.lblCodification2.TabIndex = 31;
            this.lblCodification2.Text = "2 - À vista no cartão de crédito;";
            // 
            // lblCodification3
            // 
            this.lblCodification3.AutoSize = true;
            this.lblCodification3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodification3.Location = new System.Drawing.Point(12, 281);
            this.lblCodification3.Name = "lblCodification3";
            this.lblCodification3.Size = new System.Drawing.Size(208, 16);
            this.lblCodification3.TabIndex = 32;
            this.lblCodification3.Text = "3 - Em duas vezes sem juros;";
            // 
            // lblCodification4
            // 
            this.lblCodification4.AutoSize = true;
            this.lblCodification4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodification4.Location = new System.Drawing.Point(11, 331);
            this.lblCodification4.Name = "lblCodification4";
            this.lblCodification4.Size = new System.Drawing.Size(208, 16);
            this.lblCodification4.TabIndex = 33;
            this.lblCodification4.Text = "4 - Em duas vezes com juros.";
            // 
            // FrmQuestion11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCodification4);
            this.Controls.Add(this.lblCodification3);
            this.Controls.Add(this.lblCodification2);
            this.Controls.Add(this.lblCodification1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion11";
            this.Text = "Exercício 11 = Calcular valor a ser pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblCodification1;
        private System.Windows.Forms.Label lblCodification2;
        private System.Windows.Forms.Label lblCodification3;
        private System.Windows.Forms.Label lblCodification4;
    }
}