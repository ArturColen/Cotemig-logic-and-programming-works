namespace _04_decision_structure_exercises
{
    partial class FrmQuestion07
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 452);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(169, 118);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(175, 22);
            this.txtWeight.TabIndex = 18;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(12, 121);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(151, 16);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "Digite seu peso (kg):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(168, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(175, 22);
            this.txtHeight.TabIndex = 16;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(12, 68);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(150, 16);
            this.lblHeight.TabIndex = 15;
            this.lblHeight.Text = "Digite sua altura (m):";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(171, 173);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(175, 22);
            this.txtGender.TabIndex = 21;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(12, 176);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(153, 16);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Digite seu sexo (m/f):";
            // 
            // FrmQuestion07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion07";
            this.Text = "Exercício 07 - Calcular peso ideal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
    }
}