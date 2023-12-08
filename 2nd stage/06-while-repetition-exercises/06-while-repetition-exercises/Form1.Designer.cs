namespace _06_while_repetition_exercises
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
            this.btnExercise01 = new System.Windows.Forms.Button();
            this.btnExercise02 = new System.Windows.Forms.Button();
            this.btnExercise03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercise01
            // 
            this.btnExercise01.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExercise01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercise01.ForeColor = System.Drawing.Color.White;
            this.btnExercise01.Location = new System.Drawing.Point(200, 38);
            this.btnExercise01.Name = "btnExercise01";
            this.btnExercise01.Size = new System.Drawing.Size(142, 48);
            this.btnExercise01.TabIndex = 0;
            this.btnExercise01.Text = "Mostrar múltiplos de 3";
            this.btnExercise01.UseVisualStyleBackColor = false;
            this.btnExercise01.Click += new System.EventHandler(this.btnExercise01_Click);
            // 
            // btnExercise02
            // 
            this.btnExercise02.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExercise02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercise02.ForeColor = System.Drawing.Color.White;
            this.btnExercise02.Location = new System.Drawing.Point(449, 38);
            this.btnExercise02.Name = "btnExercise02";
            this.btnExercise02.Size = new System.Drawing.Size(142, 48);
            this.btnExercise02.TabIndex = 1;
            this.btnExercise02.Text = "Mostrar números de 100 a 1000";
            this.btnExercise02.UseVisualStyleBackColor = false;
            this.btnExercise02.Click += new System.EventHandler(this.btnExercise02_Click);
            // 
            // btnExercise03
            // 
            this.btnExercise03.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExercise03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercise03.ForeColor = System.Drawing.Color.White;
            this.btnExercise03.Location = new System.Drawing.Point(713, 38);
            this.btnExercise03.Name = "btnExercise03";
            this.btnExercise03.Size = new System.Drawing.Size(148, 48);
            this.btnExercise03.TabIndex = 2;
            this.btnExercise03.Text = "Mostrar sequência de alunos";
            this.btnExercise03.UseVisualStyleBackColor = false;
            this.btnExercise03.Click += new System.EventHandler(this.btnExercise03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExercise03);
            this.Controls.Add(this.btnExercise02);
            this.Controls.Add(this.btnExercise01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercise01;
        private System.Windows.Forms.Button btnExercise02;
        private System.Windows.Forms.Button btnExercise03;
    }
}

