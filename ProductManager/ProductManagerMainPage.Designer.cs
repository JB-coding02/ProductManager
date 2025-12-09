namespace ProductManager
{
    partial class BonSucreForm
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
            lstProducts = new ListBox();
            BtnSelectProduct = new Button();
            SuspendLayout();
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Location = new Point(283, 21);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(164, 69);
            BtnDeleteProduct.TabIndex = 1;
            BtnDeleteProduct.Text = "Delete Selected Product";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // TxtProdName
            // 
            TxtProdName.Location = new Point(22, 131);
            TxtProdName.Name = "TxtProdName";
            TxtProdName.PlaceholderText = "Enter Product Name.";
            TxtProdName.Size = new Size(238, 31);
            TxtProdName.TabIndex = 2;
            // 
            // TxtProdSalesPrice
            // 
            TxtProdSalesPrice.Location = new Point(22, 168);
            TxtProdSalesPrice.Name = "TxtProdSalesPrice";
            TxtProdSalesPrice.PlaceholderText = "Enter Product Sales Price.";
            TxtProdSalesPrice.Size = new Size(238, 31);
            TxtProdSalesPrice.TabIndex = 3;
            // 
            // BtnAddProd
            // 
            BtnAddProd.Location = new Point(22, 205);
            BtnAddProd.Name = "BtnAddProd";
            BtnAddProd.Size = new Size(238, 31);
            BtnAddProd.TabIndex = 4;
            BtnAddProd.Text = "Add Product";
            BtnAddProd.UseVisualStyleBackColor = true;
            BtnAddProd.Click += BtnAddProd_Click;
            // 
            // BtnUpdateProduct
            // 
            BtnUpdateProduct.Location = new Point(283, 96);
            BtnUpdateProduct.Name = "BtnUpdateProduct";
            BtnUpdateProduct.Size = new Size(164, 48);
            BtnUpdateProduct.TabIndex = 5;
            BtnUpdateProduct.Text = "Update Product";
            BtnUpdateProduct.UseVisualStyleBackColor = true;
            BtnUpdateProduct.Click += BtnUpdateProduct_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(22, 21);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(238, 104);
            lstProducts.TabIndex = 0;
            // 
            // BtnSelectProduct
            // 
            BtnSelectProduct.Location = new Point(283, 150);
            BtnSelectProduct.Name = "BtnSelectProduct";
            BtnSelectProduct.Size = new Size(164, 49);
            BtnSelectProduct.TabIndex = 6;
            BtnSelectProduct.Text = "Select Product";
            BtnSelectProduct.UseVisualStyleBackColor = true;
            BtnSelectProduct.Click += BtnSelectProduct_Click;
            // 
            // BonSucreForm
            // 
            ClientSize = new Size(546, 347);
            Controls.Add(BtnSelectProduct);
            Controls.Add(BtnUpdateProduct);
            Controls.Add(BtnAddProd);
            Controls.Add(TxtProdSalesPrice);
            Controls.Add(TxtProdName);
            Controls.Add(BtnDeleteProduct);
            Controls.Add(lstProducts);
            Name = "BonSucreForm";
            Text = "Bon Sucre";
            Load += ProductManger_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnDeleteProduct;
        private TextBox TxtProdName;
        private TextBox TxtProdSalesPrice;
        private Button BtnAddProd;
        private Button BtnUpdateProduct;
        private ListBox lstProducts;
        private Button BtnSelectProduct;
    }
}
