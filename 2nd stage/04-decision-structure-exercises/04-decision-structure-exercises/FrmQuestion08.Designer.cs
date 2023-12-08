namespace _04_decision_structure_exercises
{
    partial class FrmQuestion08
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
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(171, 69);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(175, 22);
            this.txtGender.TabIndex = 24;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 72);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(153, 16);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Digite seu sexo (m/f):";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 452);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(95, 41);
            this.btnVerify.TabIndex = 22;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // FrmQuestion08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnVerify);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion08";
            this.Text = "Exercício 08 - Verificar o sexo para programa de mulheres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnVerify;
    }
}