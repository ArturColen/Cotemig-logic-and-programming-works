namespace _07_show_highest_salary
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
            this.lblFirstSalary = new System.Windows.Forms.Label();
            this.txtFirstSalary = new System.Windows.Forms.TextBox();
            this.lblSecondSalary = new System.Windows.Forms.Label();
            this.lblThirdSalary = new System.Windows.Forms.Label();
            this.txtSecondSalary = new System.Windows.Forms.TextBox();
            this.txtThirdSalary = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstSalary
            // 
            this.lblFirstSalary.AutoSize = true;
            this.lblFirstSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSalary.Location = new System.Drawing.Point(12, 74);
            this.lblFirstSalary.Name = "lblFirstSalary";
            this.lblFirstSalary.Size = new System.Drawing.Size(135, 16);
            this.lblFirstSalary.TabIndex = 0;
            this.lblFirstSalary.Text = "Digite o 1º salário:";
            // 
            // txtFirstSalary
            // 
            this.txtFirstSalary.Location = new System.Drawing.Point(153, 71);
            this.txtFirstSalary.Name = "txtFirstSalary";
            this.txtFirstSalary.Size = new System.Drawing.Size(131, 22);
            this.txtFirstSalary.TabIndex = 1;
            // 
            // lblSecondSalary
            // 
            this.lblSecondSalary.AutoSize = true;
            this.lblSecondSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondSalary.Location = new System.Drawing.Point(12, 126);
            this.lblSecondSalary.Name = "lblSecondSalary";
            this.lblSecondSalary.Size = new System.Drawing.Size(135, 16);
            this.lblSecondSalary.TabIndex = 2;
            this.lblSecondSalary.Text = "Digite o 2º salário:";
            // 
            // lblThirdSalary
            // 
            this.lblThirdSalary.AutoSize = true;
            this.lblThirdSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdSalary.Location = new System.Drawing.Point(12, 176);
            this.lblThirdSalary.Name = "lblThirdSalary";
            this.lblThirdSalary.Size = new System.Drawing.Size(135, 16);
            this.lblThirdSalary.TabIndex = 3;
            this.lblThirdSalary.Text = "Digite o 3º salário:";
            // 
            // txtSecondSalary
            // 
            this.txtSecondSalary.Location = new System.Drawing.Point(153, 123);
            this.txtSecondSalary.Name = "txtSecondSalary";
            this.txtSecondSalary.Size = new System.Drawing.Size(131, 22);
            this.txtSecondSalary.TabIndex = 4;
            // 
            // txtThirdSalary
            // 
            this.txtThirdSalary.Location = new System.Drawing.Point(153, 173);
            this.txtThirdSalary.Name = "txtThirdSalary";
            this.txtThirdSalary.Size = new System.Drawing.Size(131, 22);
            this.txtThirdSalary.TabIndex = 5;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(15, 407);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(105, 41);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtThirdSalary);
            this.Controls.Add(this.txtSecondSalary);
            this.Controls.Add(this.lblThirdSalary);
            this.Controls.Add(this.lblSecondSalary);
            this.Controls.Add(this.txtFirstSalary);
            this.Controls.Add(this.lblFirstSalary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mostrar o maior salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstSalary;
        private System.Windows.Forms.TextBox txtFirstSalary;
        private System.Windows.Forms.Label lblSecondSalary;
        private System.Windows.Forms.Label lblThirdSalary;
        private System.Windows.Forms.TextBox txtSecondSalary;
        private System.Windows.Forms.TextBox txtThirdSalary;
        private System.Windows.Forms.Button btnVerify;
    }
}

