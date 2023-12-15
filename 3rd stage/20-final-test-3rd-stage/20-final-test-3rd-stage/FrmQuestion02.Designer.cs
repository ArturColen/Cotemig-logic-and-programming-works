namespace _20_final_test_3rd_stage
{
    partial class FrmQuestion02
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dtgEmployees = new System.Windows.Forms.DataGridView();
            this.btnEmployeeRegistration = new System.Windows.Forms.Button();
            this.btnSearchEmployees = new System.Windows.Forms.Button();
            this.btnChangeData = new System.Windows.Forms.Button();
            this.btnCloseProgram = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(990, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 140);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 16);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Cargo:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(640, 137);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(415, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(581, 140);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 16);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salário:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "",
            "Secretário",
            "Disciplinário",
            "Professor",
            "Diretor"});
            this.cmbPosition.Location = new System.Drawing.Point(65, 137);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(415, 24);
            this.cmbPosition.TabIndex = 6;
            // 
            // dtgEmployees
            // 
            this.dtgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployees.Location = new System.Drawing.Point(15, 199);
            this.dtgEmployees.Name = "dtgEmployees";
            this.dtgEmployees.Size = new System.Drawing.Size(1040, 150);
            this.dtgEmployees.TabIndex = 7;
            this.dtgEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployees_CellContentClick);
            // 
            // btnEmployeeRegistration
            // 
            this.btnEmployeeRegistration.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmployeeRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRegistration.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRegistration.Location = new System.Drawing.Point(15, 384);
            this.btnEmployeeRegistration.Name = "btnEmployeeRegistration";
            this.btnEmployeeRegistration.Size = new System.Drawing.Size(94, 31);
            this.btnEmployeeRegistration.TabIndex = 8;
            this.btnEmployeeRegistration.Text = "Cadastrar";
            this.btnEmployeeRegistration.UseVisualStyleBackColor = false;
            this.btnEmployeeRegistration.Click += new System.EventHandler(this.btnEmployeeRegistration_Click);
            // 
            // btnSearchEmployees
            // 
            this.btnSearchEmployees.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSearchEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployees.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployees.Location = new System.Drawing.Point(257, 384);
            this.btnSearchEmployees.Name = "btnSearchEmployees";
            this.btnSearchEmployees.Size = new System.Drawing.Size(94, 31);
            this.btnSearchEmployees.TabIndex = 9;
            this.btnSearchEmployees.Text = "Pesquisar";
            this.btnSearchEmployees.UseVisualStyleBackColor = false;
            this.btnSearchEmployees.Click += new System.EventHandler(this.btnSearchEmployees_Click);
            // 
            // btnChangeData
            // 
            this.btnChangeData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnChangeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeData.ForeColor = System.Drawing.Color.White;
            this.btnChangeData.Location = new System.Drawing.Point(490, 384);
            this.btnChangeData.Name = "btnChangeData";
            this.btnChangeData.Size = new System.Drawing.Size(94, 31);
            this.btnChangeData.TabIndex = 10;
            this.btnChangeData.Text = "Alterar";
            this.btnChangeData.UseVisualStyleBackColor = false;
            this.btnChangeData.Click += new System.EventHandler(this.btnChangeData_Click);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProgram.ForeColor = System.Drawing.Color.White;
            this.btnCloseProgram.Location = new System.Drawing.Point(733, 384);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(94, 31);
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.Text = "Sair";
            this.btnCloseProgram.UseVisualStyleBackColor = false;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.White;
            this.btnDeleteData.Location = new System.Drawing.Point(961, 384);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(94, 31);
            this.btnDeleteData.TabIndex = 12;
            this.btnDeleteData.Text = "Excluir";
            this.btnDeleteData.UseVisualStyleBackColor = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(65, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 22);
            this.txtId.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID:";
            // 
            // FrmQuestion02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 432);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnCloseProgram);
            this.Controls.Add(this.btnChangeData);
            this.Controls.Add(this.btnSearchEmployees);
            this.Controls.Add(this.btnEmployeeRegistration);
            this.Controls.Add(this.dtgEmployees);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuestion02";
            this.Text = "Questão 02";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DataGridView dtgEmployees;
        private System.Windows.Forms.Button btnEmployeeRegistration;
        private System.Windows.Forms.Button btnSearchEmployees;
        private System.Windows.Forms.Button btnChangeData;
        private System.Windows.Forms.Button btnCloseProgram;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}