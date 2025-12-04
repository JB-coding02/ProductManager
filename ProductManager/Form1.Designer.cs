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
            lstProducts = new ListBox();
            BtnDeleteProduct = new Button();
            TxtProdName = new TextBox();
            TxtProdSalesPrice = new TextBox();
            BtnAddProd = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(22, 21);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(238, 124);
            lstProducts.TabIndex = 0;
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
            TxtProdName.Location = new Point(22, 151);
            TxtProdName.Name = "TxtProdName";
            TxtProdName.PlaceholderText = "Enter Product Name.";
            TxtProdName.Size = new Size(238, 23);
            TxtProdName.TabIndex = 2;
            // 
            // TxtProdSalesPrice
            // 
            TxtProdSalesPrice.Location = new Point(22, 180);
            TxtProdSalesPrice.Name = "TxtProdSalesPrice";
            TxtProdSalesPrice.PlaceholderText = "Enter Product Sales Price.";
            TxtProdSalesPrice.Size = new Size(238, 23);
            TxtProdSalesPrice.TabIndex = 3;
            // 
            // BtnAddProd
            // 
            BtnAddProd.Location = new Point(22, 209);
            BtnAddProd.Name = "BtnAddProd";
            BtnAddProd.Size = new Size(238, 23);
            BtnAddProd.TabIndex = 4;
            BtnAddProd.Text = "Add Product";
            BtnAddProd.UseVisualStyleBackColor = true;
            BtnAddProd.Click += BtnAddProd_Click;
            // 
            // ProductManagerForm
            // 
            ClientSize = new Size(546, 347);
            Controls.Add(BtnAddProd);
            Controls.Add(TxtProdSalesPrice);
            Controls.Add(TxtProdName);
            Controls.Add(BtnDeleteProduct);
            Controls.Add(lstProducts);
            Name = "ProductManagerForm";
            Text = "Product Manager";
            Load += ProductManger_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProducts;
        private Button BtnDeleteProduct;
        private TextBox TxtProdName;
        private TextBox TxtProdSalesPrice;
        private Button BtnAddProd;
    }
}
