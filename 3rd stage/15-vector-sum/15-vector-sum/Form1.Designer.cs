namespace _15_vector_sum
{
    partial class Form1
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
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.txtTotalSum = new System.Windows.Forms.TextBox();
            this.lblSumEvenNumbers = new System.Windows.Forms.Label();
            this.lblSumOddNumbers = new System.Windows.Forms.Label();
            this.txtSumEvenNumbers = new System.Windows.Forms.TextBox();
            this.txtSumOddNumbers = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSum.Location = new System.Drawing.Point(12, 63);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(254, 16);
            this.lblTotalSum.TabIndex = 0;
            this.lblTotalSum.Text = "Soma de todos os valores do vetor:";
            // 
            // txtTotalSum
            // 
            this.txtTotalSum.Enabled = false;
            this.txtTotalSum.Location = new System.Drawing.Point(272, 60);
            this.txtTotalSum.Name = "txtTotalSum";
            this.txtTotalSum.Size = new System.Drawing.Size(100, 22);
            this.txtTotalSum.TabIndex = 1;
            // 
            // lblSumEvenNumbers
            // 
            this.lblSumEvenNumbers.AutoSize = true;
            this.lblSumEvenNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumEvenNumbers.Location = new System.Drawing.Point(12, 111);
            this.lblSumEvenNumbers.Name = "lblSumEvenNumbers";
            this.lblSumEvenNumbers.Size = new System.Drawing.Size(188, 16);
            this.lblSumEvenNumbers.TabIndex = 2;
            this.lblSumEvenNumbers.Text = "Soma dos números pares:";
            // 
            // lblSumOddNumbers
            // 
            this.lblSumOddNumbers.AutoSize = true;
            this.lblSumOddNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOddNumbers.Location = new System.Drawing.Point(12, 157);
            this.lblSumOddNumbers.Name = "lblSumOddNumbers";
            this.lblSumOddNumbers.Size = new System.Drawing.Size(204, 16);
            this.lblSumOddNumbers.TabIndex = 3;
            this.lblSumOddNumbers.Text = "Soma dos números ímpares:";
            // 
            // txtSumEvenNumbers
            // 
            this.txtSumEvenNumbers.Enabled = false;
            this.txtSumEvenNumbers.Location = new System.Drawing.Point(206, 108);
            this.txtSumEvenNumbers.Name = "txtSumEvenNumbers";
            this.txtSumEvenNumbers.Size = new System.Drawing.Size(100, 22);
            this.txtSumEvenNumbers.TabIndex = 4;
            // 
            // txtSumOddNumbers
            // 
            this.txtSumOddNumbers.Enabled = false;
            this.txtSumOddNumbers.Location = new System.Drawing.Point(222, 154);
            this.txtSumOddNumbers.Name = "txtSumOddNumbers";
            this.txtSumOddNumbers.Size = new System.Drawing.Size(100, 22);
            this.txtSumOddNumbers.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 452);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 34);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSumOddNumbers);
            this.Controls.Add(this.txtSumEvenNumbers);
            this.Controls.Add(this.lblSumOddNumbers);
            this.Controls.Add(this.lblSumEvenNumbers);
            this.Controls.Add(this.txtTotalSum);
            this.Controls.Add(this.lblTotalSum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exercício - Soma de vetores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.TextBox txtTotalSum;
        private System.Windows.Forms.Label lblSumEvenNumbers;
        private System.Windows.Forms.Label lblSumOddNumbers;
        private System.Windows.Forms.TextBox txtSumEvenNumbers;
        private System.Windows.Forms.TextBox txtSumOddNumbers;
        private System.Windows.Forms.Button btnCalculate;
    }
}

