namespace ProductManager
{
    public partial class ProductManger : Form
    {
        public ProductManger()
        {
            InitializeComponent();
        }

        private void ProductManger_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Product Manager!");
        }
    }
}
