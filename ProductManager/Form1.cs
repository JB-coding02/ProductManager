using ProductManager.Classes;
using System.ComponentModel;
using System.Globalization;

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
            // Load from DB
            List<Product> allProducts = ProductDb.GetAllProducts();

            // Use a BindingList so the grid can bind easily
            var binding = new BindingList<Product>(allProducts);
            dgvProducts.DataSource = binding;
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            // if no product is selected, tell user and return immediately
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProd = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProd == null)
            {
                MessageBox.Show("Selected item is not a valid product.");
                return;
            }

            ProductDb.DeleteProduct(selectedProd);
            ReloadAllProducts(); // Refresh product list

            MessageBox.Show($"Product {selectedProd.Name} deleted.");
        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProdName.Text) || string.IsNullOrWhiteSpace(TxtProdSalesPrice.Text))
            {
                MessageBox.Show("Please enter BOTH a Sales Price and Name for your product");
                return;
            }

            if (!double.TryParse(TxtProdSalesPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out double price))
            {
                MessageBox.Show("Please enter a valid numeric sales price.");
                return;
            }

            Product p = new() { Name = TxtProdName.Text.Trim(), SalesPrice = price };

            ProductDb.AddProduct(p);
            ReloadAllProducts();

            TxtProdName.Clear();
            TxtProdSalesPrice.Clear();

            MessageBox.Show($"Product {p.Name} Added");
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            // if no product is selected, tell user and return immediately
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            Product selectedProd = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProd == null)
            {
                MessageBox.Show("Selected item is not a valid product.");
                return;
            }

            // If the textboxes are empty, populate them with the selected product
            // allowing the user to edit the values.
            if (string.IsNullOrWhiteSpace(TxtProdName.Text) && string.IsNullOrWhiteSpace(TxtProdSalesPrice.Text))
            {
                TxtProdName.Clear();
                TxtProdSalesPrice.Clear();

                TxtProdName.Text = selectedProd.Name ?? string.Empty;
                TxtProdSalesPrice.Text = selectedProd.SalesPrice.ToString(CultureInfo.InvariantCulture);

                TxtProductId.Text = selectedProd.Id.ToString();

                TxtProdName.Focus();
                return;
            }

            // Otherwise treat as save
            string newName = TxtProdName.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Product name cannot be empty.");
                return;
            }

            if (!double.TryParse(TxtProdSalesPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out double newPrice))
            {
                MessageBox.Show("Please enter a valid numeric sales price (use '.' as decimal separator).");
                return;
            }

            // Apply changes and persist
            selectedProd.Name = newName;
            selectedProd.SalesPrice = newPrice;

            ProductDb.UpdateProduct(selectedProd);

            // Refresh UI and clear edit fields
            ReloadAllProducts();
            TxtProdName.Clear();
            TxtProdSalesPrice.Clear();
            TxtProductId.Clear();

            MessageBox.Show($"Product {selectedProd.Name} Updated.");
        }
    }
}
