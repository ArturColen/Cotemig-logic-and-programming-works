namespace _05_product_registration
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtMinimumStock = new System.Windows.Forms.TextBox();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblMinimumStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblCostPriceError = new System.Windows.Forms.Label();
            this.lblMinimumStockError = new System.Windows.Forms.Label();
            this.lblSellingPriceError = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(308, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro de Produtos";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 153);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(862, 29);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Descrição";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(12, 261);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(374, 29);
            this.txtCostPrice.TabIndex = 3;
            // 
            // txtMinimumStock
            // 
            this.txtMinimumStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimumStock.Location = new System.Drawing.Point(500, 261);
            this.txtMinimumStock.Name = "txtMinimumStock";
            this.txtMinimumStock.Size = new System.Drawing.Size(374, 29);
            this.txtMinimumStock.TabIndex = 4;
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(12, 232);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(97, 16);
            this.lblCostPrice.TabIndex = 5;
            this.lblCostPrice.Text = "Preço de custo";
            // 
            // lblMinimumStock
            // 
            this.lblMinimumStock.AutoSize = true;
            this.lblMinimumStock.Location = new System.Drawing.Point(501, 232);
            this.lblMinimumStock.Name = "lblMinimumStock";
            this.lblMinimumStock.Size = new System.Drawing.Size(103, 16);
            this.lblMinimumStock.TabIndex = 6;
            this.lblMinimumStock.Text = "Estoque mínimo";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(501, 323);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 16);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantidade";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(12, 323);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(103, 16);
            this.lblSellingPrice.TabIndex = 9;
            this.lblSellingPrice.Text = "Preço de venda";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(500, 352);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(374, 29);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(12, 352);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(374, 29);
            this.txtSellingPrice.TabIndex = 7;
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(501, 416);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(149, 16);
            this.lblTaxRate.TabIndex = 14;
            this.lblTaxRate.Text = "Alíquota de imposto (%)";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 416);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(177, 16);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Categoria (Alimento/Bebida)";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Location = new System.Drawing.Point(500, 445);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(374, 29);
            this.txtTaxRate.TabIndex = 12;
            // 
            // lblCostPriceError
            // 
            this.lblCostPriceError.AutoSize = true;
            this.lblCostPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPriceError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCostPriceError.Location = new System.Drawing.Point(12, 293);
            this.lblCostPriceError.Name = "lblCostPriceError";
            this.lblCostPriceError.Size = new System.Drawing.Size(0, 13);
            this.lblCostPriceError.TabIndex = 15;
            // 
            // lblMinimumStockError
            // 
            this.lblMinimumStockError.AutoSize = true;
            this.lblMinimumStockError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumStockError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMinimumStockError.Location = new System.Drawing.Point(501, 293);
            this.lblMinimumStockError.Name = "lblMinimumStockError";
            this.lblMinimumStockError.Size = new System.Drawing.Size(0, 13);
            this.lblMinimumStockError.TabIndex = 16;
            // 
            // lblSellingPriceError
            // 
            this.lblSellingPriceError.AutoSize = true;
            this.lblSellingPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPriceError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSellingPriceError.Location = new System.Drawing.Point(12, 384);
            this.lblSellingPriceError.Name = "lblSellingPriceError";
            this.lblSellingPriceError.Size = new System.Drawing.Size(0, 13);
            this.lblSellingPriceError.TabIndex = 17;
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuantityError.Location = new System.Drawing.Point(501, 384);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityError.TabIndex = 18;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCategoryError.Location = new System.Drawing.Point(12, 477);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryError.TabIndex = 19;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(648, 529);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(226, 39);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Alimento",
            "Bebida"});
            this.cmbCategory.Location = new System.Drawing.Point(12, 445);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(374, 32);
            this.cmbCategory.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(886, 593);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCategoryError);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.lblSellingPriceError);
            this.Controls.Add(this.lblMinimumStockError);
            this.Controls.Add(this.lblCostPriceError);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.lblMinimumStock);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.txtMinimumStock);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtMinimumStock;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblMinimumStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lblCostPriceError;
        private System.Windows.Forms.Label lblMinimumStockError;
        private System.Windows.Forms.Label lblSellingPriceError;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}

