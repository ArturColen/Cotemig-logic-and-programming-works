namespace _19_student_registration
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.lblSeries = new System.Windows.Forms.Label();
            this.rdbFirstSeries = new System.Windows.Forms.RadioButton();
            this.rdbSecondSeries = new System.Windows.Forms.RadioButton();
            this.rdbThirdSeries = new System.Windows.Forms.RadioButton();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.pnlSeries = new System.Windows.Forms.Panel();
            this.dtgStudents = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnSearchData = new System.Windows.Forms.Button();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(401, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro de Aluno";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(637, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(756, 118);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Idade:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(834, 115);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(221, 22);
            this.txtAge.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 187);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(62, 16);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unidade:";
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(142, 224);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(74, 20);
            this.rdbFloresta.TabIndex = 9;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(15, 224);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(73, 20);
            this.rdbBarroca.TabIndex = 8;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(8, 19);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(42, 16);
            this.lblSeries.TabIndex = 10;
            this.lblSeries.Text = "Série:";
            // 
            // rdbFirstSeries
            // 
            this.rdbFirstSeries.AutoSize = true;
            this.rdbFirstSeries.Location = new System.Drawing.Point(11, 56);
            this.rdbFirstSeries.Name = "rdbFirstSeries";
            this.rdbFirstSeries.Size = new System.Drawing.Size(37, 20);
            this.rdbFirstSeries.TabIndex = 11;
            this.rdbFirstSeries.TabStop = true;
            this.rdbFirstSeries.Text = "1ª";
            this.rdbFirstSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbFirstSeries.UseVisualStyleBackColor = true;
            // 
            // rdbSecondSeries
            // 
            this.rdbSecondSeries.AutoSize = true;
            this.rdbSecondSeries.Location = new System.Drawing.Point(98, 56);
            this.rdbSecondSeries.Name = "rdbSecondSeries";
            this.rdbSecondSeries.Size = new System.Drawing.Size(37, 20);
            this.rdbSecondSeries.TabIndex = 12;
            this.rdbSecondSeries.TabStop = true;
            this.rdbSecondSeries.Text = "2ª";
            this.rdbSecondSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbSecondSeries.UseVisualStyleBackColor = true;
            // 
            // rdbThirdSeries
            // 
            this.rdbThirdSeries.AutoSize = true;
            this.rdbThirdSeries.Location = new System.Drawing.Point(191, 56);
            this.rdbThirdSeries.Name = "rdbThirdSeries";
            this.rdbThirdSeries.Size = new System.Drawing.Size(37, 20);
            this.rdbThirdSeries.TabIndex = 13;
            this.rdbThirdSeries.TabStop = true;
            this.rdbThirdSeries.Text = "3ª";
            this.rdbThirdSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbThirdSeries.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(756, 226);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(49, 16);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "Turma:";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "",
            "1A1",
            "1B1",
            "1C1",
            "1D1",
            "1E1",
            "1A2",
            "1B2",
            "1C2",
            "1D2",
            "1E2",
            "2A1",
            "2B1",
            "2C1",
            "2D1",
            "2E1",
            "2A2",
            "2B2",
            "2C2",
            "2D2",
            "2E2",
            "3A1",
            "3B1",
            "3C1",
            "3D1",
            "3E1",
            "3A2",
            "3B2",
            "3C2",
            "3D2"});
            this.cmbClass.Location = new System.Drawing.Point(834, 223);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(221, 24);
            this.cmbClass.TabIndex = 15;
            // 
            // pnlSeries
            // 
            this.pnlSeries.Controls.Add(this.rdbThirdSeries);
            this.pnlSeries.Controls.Add(this.lblSeries);
            this.pnlSeries.Controls.Add(this.rdbFirstSeries);
            this.pnlSeries.Controls.Add(this.rdbSecondSeries);
            this.pnlSeries.Location = new System.Drawing.Point(381, 168);
            this.pnlSeries.Name = "pnlSeries";
            this.pnlSeries.Size = new System.Drawing.Size(260, 89);
            this.pnlSeries.TabIndex = 16;
            // 
            // dtgStudents
            // 
            this.dtgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudents.Location = new System.Drawing.Point(15, 323);
            this.dtgStudents.Name = "dtgStudents";
            this.dtgStudents.Size = new System.Drawing.Size(1040, 144);
            this.dtgStudents.TabIndex = 17;
            this.dtgStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStudents_CellContentClick);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(15, 498);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 34);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChangeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeData.ForeColor = System.Drawing.Color.White;
            this.btnChangeData.Location = new System.Drawing.Point(240, 498);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(108, 34);
            this.btnChangeData.TabIndex = 19;
            this.btnChangeData.Text = "Alterar";
            this.btnChangeData.UseVisualStyleBackColor = false;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // btnSearchData
            // 
            this.btnSearchData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchData.ForeColor = System.Drawing.Color.White;
            this.btnSearchData.Location = new System.Drawing.Point(479, 498);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Size = new System.Drawing.Size(108, 34);
            this.btnSearchData.TabIndex = 20;
            this.btnSearchData.Text = "Pesquisar";
            this.btnSearchData.UseVisualStyleBackColor = false;
            this.btnSearchData.Click += new System.EventHandler(this.btnSearchData_Click);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProgram.ForeColor = System.Drawing.Color.White;
            this.btnCloseProgram.Location = new System.Drawing.Point(710, 498);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(108, 34);
            this.btnCloseProgram.TabIndex = 21;
            this.btnCloseProgram.Text = "Sair";
            this.btnCloseProgram.UseVisualStyleBackColor = false;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.White;
            this.btnDeleteData.Location = new System.Drawing.Point(947, 498);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteData.TabIndex = 22;
            this.btnDeleteData.Text = "Excluir";
            this.btnDeleteData.UseVisualStyleBackColor = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(65, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 22);
            this.txtId.TabIndex = 24;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.btnSearchData);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtgStudents);
            this.Controls.Add(this.pnlSeries);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.rdbFloresta);
            this.Controls.Add(this.rdbBarroca);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSeries.ResumeLayout(false);
            this.pnlSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.RadioButton rdbFirstSeries;
        private System.Windows.Forms.RadioButton rdbSecondSeries;
        private System.Windows.Forms.RadioButton rdbThirdSeries;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Panel pnlSeries;
        private System.Windows.Forms.DataGridView dtgStudents;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnSearchData;
        private System.Windows.Forms.Button btnCloseProgram;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}

