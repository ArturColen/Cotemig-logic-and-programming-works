namespace _04_decision_structure_exercises
{
    partial class FrmQuestion12
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
            this.txtAverageExercise = new System.Windows.Forms.TextBox();
            this.lblAverageExercise = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtStudentGrades = new System.Windows.Forms.TextBox();
            this.lblStudentGrades = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAverageExercise
            // 
            this.txtAverageExercise.Location = new System.Drawing.Point(235, 185);
            this.txtAverageExercise.Name = "txtAverageExercise";
            this.txtAverageExercise.Size = new System.Drawing.Size(175, 22);
            this.txtAverageExercise.TabIndex = 28;
            // 
            // lblAverageExercise
            // 
            this.lblAverageExercise.AutoSize = true;
            this.lblAverageExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageExercise.Location = new System.Drawing.Point(12, 188);
            this.lblAverageExercise.Name = "lblAverageExercise";
            this.lblAverageExercise.Size = new System.Drawing.Size(217, 16);
            this.lblAverageExercise.TabIndex = 27;
            this.lblAverageExercise.Text = "Digite a média dos exercícios:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(15, 443);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 41);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtStudentGrades
            // 
            this.txtStudentGrades.Location = new System.Drawing.Point(235, 119);
            this.txtStudentGrades.Name = "txtStudentGrades";
            this.txtStudentGrades.Size = new System.Drawing.Size(175, 22);
            this.txtStudentGrades.TabIndex = 25;
            // 
            // lblStudentGrades
            // 
            this.lblStudentGrades.AutoSize = true;
            this.lblStudentGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGrades.Location = new System.Drawing.Point(12, 122);
            this.lblStudentGrades.Name = "lblStudentGrades";
            this.lblStudentGrades.Size = new System.Drawing.Size(179, 16);
            this.lblStudentGrades.TabIndex = 24;
            this.lblStudentGrades.Text = "Digite as notas do aluno:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(235, 60);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(175, 22);
            this.txtStudentNumber.TabIndex = 23;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(12, 63);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(184, 16);
            this.lblStudentNumber.TabIndex = 22;
            this.lblStudentNumber.Text = "Digite o número do aluno:";
            // 
            // FrmQuestion12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAverageExercise);
            this.Controls.Add(this.lblAverageExercise);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStudentGrades);
            this.Controls.Add(this.lblStudentGrades);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblStudentNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion12";
            this.Text = "Exercício 12 - Verificar nota do aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAverageExercise;
        private System.Windows.Forms.Label lblAverageExercise;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtStudentGrades;
        private System.Windows.Forms.Label lblStudentGrades;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentNumber;
    }
}