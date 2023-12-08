namespace _04_decision_structure_exercises
{
    partial class FrmQuestion09
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(122, 62);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(175, 22);
            this.txtValue.TabIndex = 27;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(12, 65);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(104, 16);
            this.lblValue.TabIndex = 26;
            this.lblValue.Text = "Digite o valor:";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 444);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(95, 41);
            this.btnVerify.TabIndex = 25;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // FrmQuestion09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnVerify);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion09";
            this.RightToLeftLayout = true;
            this.Text = "Verificar se o valor é positivo ou negativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnVerify;
    }
}