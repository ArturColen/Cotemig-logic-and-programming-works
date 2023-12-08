namespace _04_decision_structure_exercises
{
    partial class FrmQuestion10
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 455);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(168, 116);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(175, 22);
            this.txtWeight.TabIndex = 23;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(11, 119);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(151, 16);
            this.lblWeight.TabIndex = 22;
            this.lblWeight.Text = "Digite seu peso (kg):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(168, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(175, 22);
            this.txtHeight.TabIndex = 21;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(12, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(150, 16);
            this.lblHeight.TabIndex = 20;
            this.lblHeight.Text = "Digite sua altura (m):";
            // 
            // FrmQuestion10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion10";
            this.Text = "Exercício 10 - Calcular IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
    }
}