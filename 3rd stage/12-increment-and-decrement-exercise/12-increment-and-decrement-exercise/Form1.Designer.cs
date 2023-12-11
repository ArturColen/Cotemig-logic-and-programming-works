namespace _12_increment_and_decrement_exercise
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
            this.cmbNumber1 = new System.Windows.Forms.ComboBox();
            this.cmbNumber2 = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNumber1
            // 
            this.cmbNumber1.FormattingEnabled = true;
            this.cmbNumber1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumber1.Location = new System.Drawing.Point(12, 31);
            this.cmbNumber1.Name = "cmbNumber1";
            this.cmbNumber1.Size = new System.Drawing.Size(375, 25);
            this.cmbNumber1.TabIndex = 0;
            // 
            // cmbNumber2
            // 
            this.cmbNumber2.FormattingEnabled = true;
            this.cmbNumber2.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumber2.Location = new System.Drawing.Point(449, 31);
            this.cmbNumber2.Name = "cmbNumber2";
            this.cmbNumber2.Size = new System.Drawing.Size(375, 25);
            this.cmbNumber2.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(889, 24);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(99, 37);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(12, 111);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(976, 439);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbNumber2);
            this.Controls.Add(this.cmbNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Exercício de incremento e decremento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumber1;
        private System.Windows.Forms.ComboBox cmbNumber2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtResult;
    }
}

