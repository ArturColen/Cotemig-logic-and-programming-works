namespace _20_final_test_3rd_stage
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblCompleteMatrix = new System.Windows.Forms.Label();
            this.lblMainDiagonal = new System.Windows.Forms.Label();
            this.lblSecondaryDiagonal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(12, 57);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(89, 35);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblCompleteMatrix
            // 
            this.lblCompleteMatrix.AutoSize = true;
            this.lblCompleteMatrix.Location = new System.Drawing.Point(9, 159);
            this.lblCompleteMatrix.Name = "lblCompleteMatrix";
            this.lblCompleteMatrix.Size = new System.Drawing.Size(0, 16);
            this.lblCompleteMatrix.TabIndex = 1;
            // 
            // lblMainDiagonal
            // 
            this.lblMainDiagonal.AutoSize = true;
            this.lblMainDiagonal.Location = new System.Drawing.Point(9, 251);
            this.lblMainDiagonal.Name = "lblMainDiagonal";
            this.lblMainDiagonal.Size = new System.Drawing.Size(0, 16);
            this.lblMainDiagonal.TabIndex = 2;
            // 
            // lblSecondaryDiagonal
            // 
            this.lblSecondaryDiagonal.AutoSize = true;
            this.lblSecondaryDiagonal.Location = new System.Drawing.Point(9, 335);
            this.lblSecondaryDiagonal.Name = "lblSecondaryDiagonal";
            this.lblSecondaryDiagonal.Size = new System.Drawing.Size(0, 16);
            this.lblSecondaryDiagonal.TabIndex = 3;
            // 
            // FrmQuestion01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblSecondaryDiagonal);
            this.Controls.Add(this.lblMainDiagonal);
            this.Controls.Add(this.lblCompleteMatrix);
            this.Controls.Add(this.btnExecute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion01";
            this.Text = "Questão 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblCompleteMatrix;
        private System.Windows.Forms.Label lblMainDiagonal;
        private System.Windows.Forms.Label lblSecondaryDiagonal;
    }
}

