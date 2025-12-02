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
            // ProductManger
            // 
            ClientSize = new Size(546, 347);
            Controls.Add(lstProducts);
            Name = "ProductManger";
            Text = "Product Manager";
            Load += ProductManger_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
    }
}
