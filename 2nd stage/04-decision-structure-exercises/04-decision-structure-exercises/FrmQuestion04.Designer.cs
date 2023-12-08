namespace _04_decision_structure_exercises
{
    partial class FrmQuestion04
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
            this.txtQuantityApples = new System.Windows.Forms.TextBox();
            this.lblQuantityApples = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 359);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtQuantityApples
            // 
            this.txtQuantityApples.Location = new System.Drawing.Point(319, 53);
            this.txtQuantityApples.Name = "txtQuantityApples";
            this.txtQuantityApples.Size = new System.Drawing.Size(175, 22);
            this.txtQuantityApples.TabIndex = 9;
            // 
            // lblQuantityApples
            // 
            this.lblQuantityApples.AutoSize = true;
            this.lblQuantityApples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityApples.Location = new System.Drawing.Point(12, 56);
            this.lblQuantityApples.Name = "lblQuantityApples";
            this.lblQuantityApples.Size = new System.Drawing.Size(301, 16);
            this.lblQuantityApples.TabIndex = 8;
            this.lblQuantityApples.Text = "Digite a quantidade de maçãs compradas:";
            // 
            // FrmQuestion04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtQuantityApples);
            this.Controls.Add(this.lblQuantityApples);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuestion04";
            this.Text = "Exercício 04 - Calcular preço das maçãs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtQuantityApples;
        private System.Windows.Forms.Label lblQuantityApples;
    }
}