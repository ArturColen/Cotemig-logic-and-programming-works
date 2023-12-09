namespace _09_final_test_2nd_stage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRegistrationCode = new System.Windows.Forms.Label();
            this.txtRegistrationCode = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblObservation = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblRegistrationCodeError = new System.Windows.Forms.Label();
            this.lblFullNameError = new System.Windows.Forms.Label();
            this.lblGenderError = new System.Windows.Forms.Label();
            this.lblClassError = new System.Windows.Forms.Label();
            this.lblObservationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(229, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro de aluno";
            // 
            // lblRegistrationCode
            // 
            this.lblRegistrationCode.AutoSize = true;
            this.lblRegistrationCode.Location = new System.Drawing.Point(12, 88);
            this.lblRegistrationCode.Name = "lblRegistrationCode";
            this.lblRegistrationCode.Size = new System.Drawing.Size(61, 16);
            this.lblRegistrationCode.TabIndex = 1;
            this.lblRegistrationCode.Text = "Matrícula";
            // 
            // txtRegistrationCode
            // 
            this.txtRegistrationCode.Location = new System.Drawing.Point(15, 121);
            this.txtRegistrationCode.Name = "txtRegistrationCode";
            this.txtRegistrationCode.Size = new System.Drawing.Size(177, 22);
            this.txtRegistrationCode.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 180);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(103, 16);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Nome completo";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 210);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(695, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 265);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(38, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Sexo";
            // 
            // lblClass
            // 
            this.lblClass.AllowDrop = true;
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(406, 265);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 16);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Turma";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(409, 295);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(301, 22);
            this.txtClass.TabIndex = 8;
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(15, 380);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(695, 22);
            this.txtObservation.TabIndex = 10;
            // 
            // lblObservation
            // 
            this.lblObservation.AutoSize = true;
            this.lblObservation.Location = new System.Drawing.Point(12, 350);
            this.lblObservation.Name = "lblObservation";
            this.lblObservation.Size = new System.Drawing.Size(82, 16);
            this.lblObservation.TabIndex = 9;
            this.lblObservation.Text = "Observação";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(15, 489);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 38);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.cmbGender.Location = new System.Drawing.Point(15, 295);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(301, 24);
            this.cmbGender.TabIndex = 12;
            // 
            // lblRegistrationCodeError
            // 
            this.lblRegistrationCodeError.AutoSize = true;
            this.lblRegistrationCodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationCodeError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRegistrationCodeError.Location = new System.Drawing.Point(12, 146);
            this.lblRegistrationCodeError.Name = "lblRegistrationCodeError";
            this.lblRegistrationCodeError.Size = new System.Drawing.Size(0, 13);
            this.lblRegistrationCodeError.TabIndex = 13;
            // 
            // lblFullNameError
            // 
            this.lblFullNameError.AutoSize = true;
            this.lblFullNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFullNameError.Location = new System.Drawing.Point(12, 235);
            this.lblFullNameError.Name = "lblFullNameError";
            this.lblFullNameError.Size = new System.Drawing.Size(0, 13);
            this.lblFullNameError.TabIndex = 14;
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGenderError.Location = new System.Drawing.Point(12, 322);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(0, 13);
            this.lblGenderError.TabIndex = 15;
            // 
            // lblClassError
            // 
            this.lblClassError.AutoSize = true;
            this.lblClassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblClassError.Location = new System.Drawing.Point(406, 322);
            this.lblClassError.Name = "lblClassError";
            this.lblClassError.Size = new System.Drawing.Size(0, 13);
            this.lblClassError.TabIndex = 16;
            // 
            // lblObservationError
            // 
            this.lblObservationError.AutoSize = true;
            this.lblObservationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservationError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObservationError.Location = new System.Drawing.Point(12, 405);
            this.lblObservationError.Name = "lblObservationError";
            this.lblObservationError.Size = new System.Drawing.Size(0, 13);
            this.lblObservationError.TabIndex = 17;
            // 
            // FrmQuestion01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(722, 554);
            this.Controls.Add(this.lblObservationError);
            this.Controls.Add(this.lblClassError);
            this.Controls.Add(this.lblGenderError);
            this.Controls.Add(this.lblFullNameError);
            this.Controls.Add(this.lblRegistrationCodeError);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.lblObservation);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtRegistrationCode);
            this.Controls.Add(this.lblRegistrationCode);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmQuestion01";
            this.Text = "Cadastro de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRegistrationCode;
        private System.Windows.Forms.TextBox txtRegistrationCode;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label lblObservation;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblRegistrationCodeError;
        private System.Windows.Forms.Label lblFullNameError;
        private System.Windows.Forms.Label lblGenderError;
        private System.Windows.Forms.Label lblClassError;
        private System.Windows.Forms.Label lblObservationError;
    }
}

