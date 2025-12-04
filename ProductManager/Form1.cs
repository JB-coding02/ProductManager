using ProductManager.Classes;

namespace ProductManager
{
    public partial class ProductManagerForm : Form
    {
        public ProductManagerForm()
        {
            InitializeComponent();
        }

        private void ProductManger_Load(object sender, EventArgs e)
        {
            ReloadAllProducts();
        }

        /// <summary>
        /// This clears and reloads all the products into
        /// the listbox
        /// </summary>
        private void ReloadAllProducts()
        {
            lstProducts.Items.Clear(); // Clear existing items

            List<Product> allProducts = ProductDb.GetAllProducts();

            // Add each product to listbox
            foreach (Product p in allProducts)
            {
                lstProducts.Items.Add(p);
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            // if no product is selected, tell user and return immediately
            if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProd = lstProducts.SelectedItem as Product;

            ProductDb.DeleteProduct(selectedProd);
            ReloadAllProducts(); // Refresh product list

            MessageBox.Show($"Product {selectedProd.Name} deleted.");
        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            if (TxtProdName.Text == "" || TxtProdSalesPrice.Text == "")
            {
                MessageBox.Show("Please enter BOTH a Sales Price and Name for your product");
                return;
            }
            Product p = new() { Name = TxtProdName.Text, SalesPrice = Convert.ToDouble(TxtProdSalesPrice.Text) };
            
            ProductDb.AddProduct(p);

            MessageBox.Show($"Product {p.Name} Added");
        }
    }
}
