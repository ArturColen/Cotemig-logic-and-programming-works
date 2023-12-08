namespace _04_decision_structure_exercises
{
    partial class FrmQuestion06
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtNumberSides = new System.Windows.Forms.TextBox();
            this.lblNumberSides = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 393);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(95, 41);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtNumberSides
            // 
            this.txtNumberSides.Location = new System.Drawing.Point(343, 87);
            this.txtNumberSides.Name = "txtNumberSides";
            this.txtNumberSides.Size = new System.Drawing.Size(175, 22);
            this.txtNumberSides.TabIndex = 12;
            // 
            // lblNumberSides
            // 
            this.lblNumberSides.AutoSize = true;
            this.lblNumberSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSides.Location = new System.Drawing.Point(12, 90);
            this.lblNumberSides.Name = "lblNumberSides";
            this.lblNumberSides.Size = new System.Drawing.Size(325, 16);
            this.lblNumberSides.TabIndex = 11;
            this.lblNumberSides.Text = "Digite o número de lados do polígono regular:";
            // 
            // FrmQuestion06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtNumberSides);
            this.Controls.Add(this.lblNumberSides);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion06";
            this.Text = "Exercício 06 - Verificar nome do polígono regular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtNumberSides;
        private System.Windows.Forms.Label lblNumberSides;
    }
}