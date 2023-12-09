namespace _09_final_test_2nd_stage
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
            this.lblWarning1 = new System.Windows.Forms.Label();
            this.lblWarning2 = new System.Windows.Forms.Label();
            this.cmbSequence = new System.Windows.Forms.ComboBox();
            this.btnShowNumbers = new System.Windows.Forms.Button();
            this.lblShowNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarning1
            // 
            this.lblWarning1.AutoSize = true;
            this.lblWarning1.Location = new System.Drawing.Point(402, 43);
            this.lblWarning1.Name = "lblWarning1";
            this.lblWarning1.Size = new System.Drawing.Size(282, 16);
            this.lblWarning1.TabIndex = 0;
            this.lblWarning1.Text = "Os números de 1 a 100 serão exibidos abaixo:";
            // 
            // lblWarning2
            // 
            this.lblWarning2.AutoSize = true;
            this.lblWarning2.Location = new System.Drawing.Point(178, 84);
            this.lblWarning2.Name = "lblWarning2";
            this.lblWarning2.Size = new System.Drawing.Size(683, 16);
            this.lblWarning2.TabIndex = 1;
            this.lblWarning2.Text = "Selecione abaixo se  a sequência de números a aparecer será distribuída de 5 em 5" +
    ", de 10 em 10 ou de 20 em 20.";
            // 
            // cmbSequence
            // 
            this.cmbSequence.FormattingEnabled = true;
            this.cmbSequence.Items.AddRange(new object[] {
            "",
            "5",
            "10",
            "20"});
            this.cmbSequence.Location = new System.Drawing.Point(475, 133);
            this.cmbSequence.Name = "cmbSequence";
            this.cmbSequence.Size = new System.Drawing.Size(121, 24);
            this.cmbSequence.TabIndex = 2;
            // 
            // btnShowNumbers
            // 
            this.btnShowNumbers.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNumbers.ForeColor = System.Drawing.Color.White;
            this.btnShowNumbers.Location = new System.Drawing.Point(490, 184);
            this.btnShowNumbers.Name = "btnShowNumbers";
            this.btnShowNumbers.Size = new System.Drawing.Size(90, 38);
            this.btnShowNumbers.TabIndex = 12;
            this.btnShowNumbers.Text = "Mostrar";
            this.btnShowNumbers.UseVisualStyleBackColor = false;
            this.btnShowNumbers.Click += new System.EventHandler(this.btnShowNumbers_Click);
            // 
            // lblShowNumbers
            // 
            this.lblShowNumbers.AutoSize = true;
            this.lblShowNumbers.Location = new System.Drawing.Point(402, 264);
            this.lblShowNumbers.Name = "lblShowNumbers";
            this.lblShowNumbers.Size = new System.Drawing.Size(0, 16);
            this.lblShowNumbers.TabIndex = 13;
            // 
            // FrmQuestion02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 610);
            this.Controls.Add(this.lblShowNumbers);
            this.Controls.Add(this.btnShowNumbers);
            this.Controls.Add(this.cmbSequence);
            this.Controls.Add(this.lblWarning2);
            this.Controls.Add(this.lblWarning1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion02";
            this.Text = "Exibir números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarning1;
        private System.Windows.Forms.Label lblWarning2;
        private System.Windows.Forms.ComboBox cmbSequence;
        private System.Windows.Forms.Button btnShowNumbers;
        private System.Windows.Forms.Label lblShowNumbers;
    }
}