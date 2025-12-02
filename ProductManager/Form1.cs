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
            List<Product> allProducts = ProductDb.GetAllProducts();

            // Add each product to listbox
            foreach (Product p in allProducts)
            {
                lstProducts.Items.Add(p);
            }
        }
    }
}
