namespace _04_decision_structure_exercises
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 377);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(95, 41);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(234, 62);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(175, 22);
            this.txtBirthYear.TabIndex = 6;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(12, 65);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(216, 16);
            this.lblBirthYear.TabIndex = 5;
            this.lblBirthYear.Text = "Digite seu ano de nascimento:";
            // 
            // FrmQuestion02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.lblBirthYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion02";
            this.Text = "Exercício 02 - Verificar se pode votar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Label lblBirthYear;
    }
}