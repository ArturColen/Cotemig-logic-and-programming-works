namespace _04_decision_structure_exercises
{
    partial class FrmQuestion01
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
            this.lblValue1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(12, 60);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(122, 16);
            this.lblValue1.TabIndex = 0;
            this.lblValue1.Text = "Digite o 1º valor:";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(140, 57);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(175, 22);
            this.txtValue1.TabIndex = 1;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(140, 125);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(175, 22);
            this.txtValue2.TabIndex = 3;
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(12, 128);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(122, 16);
            this.lblValue2.TabIndex = 2;
            this.lblValue2.Text = "Digite o 2º valor:";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 433);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(95, 41);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // FrmQuestion01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblValue1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion01";
            this.Text = "Exercício 01 - Verificar valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Button btnVerify;
    }
}

