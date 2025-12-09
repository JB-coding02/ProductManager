using ProductManager.Classes;
using System.Globalization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProductManager
{
    public partial class BonSucreForm : Form
    {
        public BonSucreForm()
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
            ReloadAllProducts();

            MessageBox.Show($"Product {p.Name} Added");
        }

        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product? selectedProd = lstProducts.SelectedItem as Product;
            

            // We treat this click as the "save changes" action.
            // Validate user input
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
            selectedProd?.Name = newName;
            selectedProd?.SalesPrice = newPrice;

            ProductDb.UpdateProduct(selectedProd!);

            // Refresh UI and clear edit fields
            ReloadAllProducts();
            TxtProdName.Clear();
            TxtProdSalesPrice.Clear();

            MessageBox.Show($"Product {selectedProd?.Name} Updated.");
        }

        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            // if no product is selected, tell user and return immediately
            if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            Product? selectedProd = lstProducts.SelectedItem as Product;
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
                // Use invariant culture for a predictable decimal separator
                TxtProdSalesPrice.Text = selectedProd.SalesPrice.ToString(CultureInfo.InvariantCulture);

                // Focus the name box so the user can begin editing immediately
                TxtProdName.Focus();
                return;
            }
        }
    }
}
