namespace ProductManager
{
    partial class ProductManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDeleteProduct = new Button();
            TxtProdName = new TextBox();
            TxtProdSalesPrice = new TextBox();
            BtnAddProd = new Button();
            BtnUpdateProduct = new Button();
            TxtProductId = new TextBox();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Location = new Point(273, 11);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(164, 58);
            BtnDeleteProduct.TabIndex = 1;
            BtnDeleteProduct.Text = "Delete Selected Product";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // TxtProdName
            // 
            TxtProdName.Location = new Point(12, 121);
            TxtProdName.Name = "TxtProdName";
            TxtProdName.PlaceholderText = "Enter Product Name.";
            TxtProdName.Size = new Size(238, 31);
            TxtProdName.TabIndex = 2;
            // 
            // TxtProdSalesPrice
            // 
            TxtProdSalesPrice.Location = new Point(12, 158);
            TxtProdSalesPrice.Name = "TxtProdSalesPrice";
            TxtProdSalesPrice.PlaceholderText = "Enter Product Sales Price.";
            TxtProdSalesPrice.Size = new Size(238, 31);
            TxtProdSalesPrice.TabIndex = 3;
            // 
            // BtnAddProd
            // 
            BtnAddProd.Location = new Point(273, 121);
            BtnAddProd.Name = "BtnAddProd";
            BtnAddProd.Size = new Size(164, 31);
            BtnAddProd.TabIndex = 4;
            BtnAddProd.Text = "Add Product";
            BtnAddProd.UseVisualStyleBackColor = true;
            BtnAddProd.Click += BtnAddProd_Click;
            // 
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Location = new Point(273, 75);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(164, 40);
            BtnUpdateProduct.TabIndex = 5;
            BtnUpdateProduct.Text = "Update Product";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(12, 195);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.PlaceholderText = "Product Id.";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(238, 31);
            TxtProductId.TabIndex = 6;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(238, 103);
            dgvProducts.TabIndex = 7;
            // 
            // ProductManagerForm
            // 
            ClientSize = new Size(448, 236);
            Controls.Add(dgvProducts);
            Controls.Add(TxtProductId);
            Controls.Add(BtnUpdateProduct);
            Controls.Add(BtnAddProd);
            Controls.Add(TxtProdSalesPrice);
            Controls.Add(TxtProdName);
            Controls.Add(BtnDeleteProduct);
            Name = "ProductManagerForm";
            Text = "Product Manager";
            Load += ProductManger_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnDeleteProduct;
        private TextBox TxtProdName;
        private TextBox TxtProdSalesPrice;
        private Button BtnAddProd;
        private Button BtnUpdateProduct;
        private TextBox TxtProductId;
        private DataGridView dgvProducts;
    }
}
