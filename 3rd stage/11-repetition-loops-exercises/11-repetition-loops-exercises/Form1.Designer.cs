namespace _11_repetition_loops_exercises
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
            this.txtDoWhile = new System.Windows.Forms.TextBox();
            this.txtWhile = new System.Windows.Forms.TextBox();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDoWhile
            // 
            this.txtDoWhile.Location = new System.Drawing.Point(12, 367);
            this.txtDoWhile.Multiline = true;
            this.txtDoWhile.Name = "txtDoWhile";
            this.txtDoWhile.Size = new System.Drawing.Size(776, 94);
            this.txtDoWhile.TabIndex = 7;
            this.txtDoWhile.Text = "Do While - ";
            // 
            // txtWhile
            // 
            this.txtWhile.Location = new System.Drawing.Point(12, 238);
            this.txtWhile.Multiline = true;
            this.txtWhile.Name = "txtWhile";
            this.txtWhile.Size = new System.Drawing.Size(776, 94);
            this.txtWhile.TabIndex = 6;
            this.txtWhile.Text = "While - ";
            // 
            // txtFor
            // 
            this.txtFor.Location = new System.Drawing.Point(12, 110);
            this.txtFor.Multiline = true;
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(776, 94);
            this.txtFor.TabIndex = 5;
            this.txtFor.Text = "For - ";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExecute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(346, 30);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(80, 39);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.txtDoWhile);
            this.Controls.Add(this.txtWhile);
            this.Controls.Add(this.txtFor);
            this.Controls.Add(this.btnExecute);
            this.Name = "Form1";
            this.Text = "Exercício de laços de repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoWhile;
        private System.Windows.Forms.TextBox txtWhile;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.Button btnExecute;
    }
}

