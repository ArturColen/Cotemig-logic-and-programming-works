namespace _16_vector_analysis
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAverageValue = new System.Windows.Forms.Button();
            this.btnQuantityZeros = new System.Windows.Forms.Button();
            this.btnLowestValue = new System.Windows.Forms.Button();
            this.btnHighestValue = new System.Windows.Forms.Button();
            this.btnFillVector = new System.Windows.Forms.Button();
            this.btnCreateVector = new System.Windows.Forms.Button();
            this.txtVectorSize = new System.Windows.Forms.TextBox();
            this.lblVectorSize = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lstElements = new System.Windows.Forms.ListBox();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Khaki;
            this.pnlButtons.Controls.Add(this.btnAverageValue);
            this.pnlButtons.Controls.Add(this.btnQuantityZeros);
            this.pnlButtons.Controls.Add(this.btnLowestValue);
            this.pnlButtons.Controls.Add(this.btnHighestValue);
            this.pnlButtons.Controls.Add(this.btnFillVector);
            this.pnlButtons.Controls.Add(this.btnCreateVector);
            this.pnlButtons.Location = new System.Drawing.Point(12, 173);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(557, 385);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnAverageValue
            // 
            this.btnAverageValue.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAverageValue.Enabled = false;
            this.btnAverageValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageValue.ForeColor = System.Drawing.Color.White;
            this.btnAverageValue.Location = new System.Drawing.Point(7, 320);
            this.btnAverageValue.Name = "btnAverageValue";
            this.btnAverageValue.Size = new System.Drawing.Size(544, 53);
            this.btnAverageValue.TabIndex = 5;
            this.btnAverageValue.Text = "Média";
            this.btnAverageValue.UseVisualStyleBackColor = false;
            this.btnAverageValue.Click += new System.EventHandler(this.btnAverageValue_Click);
            // 
            // btnQuantityZeros
            // 
            this.btnQuantityZeros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQuantityZeros.Enabled = false;
            this.btnQuantityZeros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityZeros.ForeColor = System.Drawing.Color.White;
            this.btnQuantityZeros.Location = new System.Drawing.Point(7, 261);
            this.btnQuantityZeros.Name = "btnQuantityZeros";
            this.btnQuantityZeros.Size = new System.Drawing.Size(544, 53);
            this.btnQuantityZeros.TabIndex = 4;
            this.btnQuantityZeros.Text = "Quantidade de zeros";
            this.btnQuantityZeros.UseVisualStyleBackColor = false;
            this.btnQuantityZeros.Click += new System.EventHandler(this.btnQuantityZeros_Click);
            // 
            // btnLowestValue
            // 
            this.btnLowestValue.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLowestValue.Enabled = false;
            this.btnLowestValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowestValue.ForeColor = System.Drawing.Color.White;
            this.btnLowestValue.Location = new System.Drawing.Point(7, 202);
            this.btnLowestValue.Name = "btnLowestValue";
            this.btnLowestValue.Size = new System.Drawing.Size(544, 53);
            this.btnLowestValue.TabIndex = 3;
            this.btnLowestValue.Text = "Menor valor";
            this.btnLowestValue.UseVisualStyleBackColor = false;
            this.btnLowestValue.Click += new System.EventHandler(this.btnLowestValue_Click);
            // 
            // btnHighestValue
            // 
            this.btnHighestValue.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHighestValue.Enabled = false;
            this.btnHighestValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestValue.ForeColor = System.Drawing.Color.White;
            this.btnHighestValue.Location = new System.Drawing.Point(7, 143);
            this.btnHighestValue.Name = "btnHighestValue";
            this.btnHighestValue.Size = new System.Drawing.Size(544, 53);
            this.btnHighestValue.TabIndex = 2;
            this.btnHighestValue.Text = "Maior valor";
            this.btnHighestValue.UseVisualStyleBackColor = false;
            this.btnHighestValue.Click += new System.EventHandler(this.btnHighestValue_Click);
            // 
            // btnFillVector
            // 
            this.btnFillVector.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFillVector.Enabled = false;
            this.btnFillVector.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillVector.ForeColor = System.Drawing.Color.White;
            this.btnFillVector.Location = new System.Drawing.Point(7, 75);
            this.btnFillVector.Name = "btnFillVector";
            this.btnFillVector.Size = new System.Drawing.Size(544, 53);
            this.btnFillVector.TabIndex = 1;
            this.btnFillVector.Text = "Preencher o valor";
            this.btnFillVector.UseVisualStyleBackColor = false;
            this.btnFillVector.Click += new System.EventHandler(this.btnFillVector_Click);
            // 
            // btnCreateVector
            // 
            this.btnCreateVector.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateVector.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateVector.ForeColor = System.Drawing.Color.White;
            this.btnCreateVector.Location = new System.Drawing.Point(7, 16);
            this.btnCreateVector.Name = "btnCreateVector";
            this.btnCreateVector.Size = new System.Drawing.Size(544, 53);
            this.btnCreateVector.TabIndex = 0;
            this.btnCreateVector.Text = "Criar o vetor";
            this.btnCreateVector.UseVisualStyleBackColor = false;
            this.btnCreateVector.Click += new System.EventHandler(this.btnCreateVector_Click);
            // 
            // txtVectorSize
            // 
            this.txtVectorSize.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVectorSize.Location = new System.Drawing.Point(12, 42);
            this.txtVectorSize.Multiline = true;
            this.txtVectorSize.Name = "txtVectorSize";
            this.txtVectorSize.Size = new System.Drawing.Size(557, 109);
            this.txtVectorSize.TabIndex = 6;
            this.txtVectorSize.Text = "0";
            this.txtVectorSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVectorSize
            // 
            this.lblVectorSize.AutoSize = true;
            this.lblVectorSize.Location = new System.Drawing.Point(8, 15);
            this.lblVectorSize.Name = "lblVectorSize";
            this.lblVectorSize.Size = new System.Drawing.Size(217, 16);
            this.lblVectorSize.TabIndex = 5;
            this.lblVectorSize.Text = "Quantidade de elementos do vetor:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(11, 572);
            this.lblResults.Name = "lblResults";
            this.lblResults.Padding = new System.Windows.Forms.Padding(370, 5, 370, 5);
            this.lblResults.Size = new System.Drawing.Size(740, 56);
            this.lblResults.TabIndex = 9;
            // 
            // lstElements
            // 
            this.lstElements.FormattingEnabled = true;
            this.lstElements.ItemHeight = 16;
            this.lstElements.Location = new System.Drawing.Point(585, 42);
            this.lstElements.Name = "lstElements";
            this.lstElements.Size = new System.Drawing.Size(403, 516);
            this.lstElements.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtVectorSize);
            this.Controls.Add(this.lblVectorSize);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lstElements);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exercício - Análise de vetor";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAverageValue;
        private System.Windows.Forms.Button btnQuantityZeros;
        private System.Windows.Forms.Button btnLowestValue;
        private System.Windows.Forms.Button btnHighestValue;
        private System.Windows.Forms.Button btnFillVector;
        private System.Windows.Forms.Button btnCreateVector;
        private System.Windows.Forms.TextBox txtVectorSize;
        private System.Windows.Forms.Label lblVectorSize;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lstElements;
    }
}

