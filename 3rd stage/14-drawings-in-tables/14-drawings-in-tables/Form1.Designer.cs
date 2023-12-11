namespace _14_drawings_in_tables
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
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnShowHalfPyramid = new System.Windows.Forms.Button();
            this.btnShowDiagonal = new System.Windows.Forms.Button();
            this.btnShowLetterX = new System.Windows.Forms.Button();
            this.btnShowPlusSign = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.Color.White;
            this.btnShowTable.Location = new System.Drawing.Point(13, 47);
            this.btnShowTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(175, 42);
            this.btnShowTable.TabIndex = 0;
            this.btnShowTable.Text = "Mostrar tabela";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnShowHalfPyramid
            // 
            this.btnShowHalfPyramid.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowHalfPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHalfPyramid.ForeColor = System.Drawing.Color.White;
            this.btnShowHalfPyramid.Location = new System.Drawing.Point(450, 47);
            this.btnShowHalfPyramid.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowHalfPyramid.Name = "btnShowHalfPyramid";
            this.btnShowHalfPyramid.Size = new System.Drawing.Size(175, 42);
            this.btnShowHalfPyramid.TabIndex = 1;
            this.btnShowHalfPyramid.Text = "Mostrar meia pirâmide";
            this.btnShowHalfPyramid.UseVisualStyleBackColor = false;
            this.btnShowHalfPyramid.Click += new System.EventHandler(this.btnShowHalfPyramid_Click);
            // 
            // btnShowDiagonal
            // 
            this.btnShowDiagonal.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDiagonal.ForeColor = System.Drawing.Color.White;
            this.btnShowDiagonal.Location = new System.Drawing.Point(234, 47);
            this.btnShowDiagonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDiagonal.Name = "btnShowDiagonal";
            this.btnShowDiagonal.Size = new System.Drawing.Size(175, 42);
            this.btnShowDiagonal.TabIndex = 2;
            this.btnShowDiagonal.Text = "Mostrar diagonal";
            this.btnShowDiagonal.UseVisualStyleBackColor = false;
            this.btnShowDiagonal.Click += new System.EventHandler(this.btnShowDiagonal_Click);
            // 
            // btnShowLetterX
            // 
            this.btnShowLetterX.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowLetterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLetterX.ForeColor = System.Drawing.Color.White;
            this.btnShowLetterX.Location = new System.Drawing.Point(661, 47);
            this.btnShowLetterX.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowLetterX.Name = "btnShowLetterX";
            this.btnShowLetterX.Size = new System.Drawing.Size(175, 42);
            this.btnShowLetterX.TabIndex = 3;
            this.btnShowLetterX.Text = "Mostrar letra X";
            this.btnShowLetterX.UseVisualStyleBackColor = false;
            this.btnShowLetterX.Click += new System.EventHandler(this.btnShowLetterX_Click);
            // 
            // btnShowPlusSign
            // 
            this.btnShowPlusSign.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowPlusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPlusSign.ForeColor = System.Drawing.Color.White;
            this.btnShowPlusSign.Location = new System.Drawing.Point(879, 47);
            this.btnShowPlusSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPlusSign.Name = "btnShowPlusSign";
            this.btnShowPlusSign.Size = new System.Drawing.Size(175, 42);
            this.btnShowPlusSign.TabIndex = 4;
            this.btnShowPlusSign.Text = "Mostrar sinal de adição";
            this.btnShowPlusSign.UseVisualStyleBackColor = false;
            this.btnShowPlusSign.Click += new System.EventHandler(this.btnShowPlusSign_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowPlusSign);
            this.Controls.Add(this.btnShowLetterX);
            this.Controls.Add(this.btnShowDiagonal);
            this.Controls.Add(this.btnShowHalfPyramid);
            this.Controls.Add(this.btnShowTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Desenhos em tabela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnShowHalfPyramid;
        private System.Windows.Forms.Button btnShowDiagonal;
        private System.Windows.Forms.Button btnShowLetterX;
        private System.Windows.Forms.Button btnShowPlusSign;
        private System.Windows.Forms.Label lblResult;
    }
}

