namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form that will add a product
    /// </summary>
    public partial class Form_AddProduct : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form_AddProduct()
        {
            InitializeComponent();

            Animator.FadeIn(this);
            LoadProducts();
        } 

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that handles all of the button functions in the form
        /// </summary>
        /// <param name="sender">The trigger of the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "button_close":
                case "button_cancel":
                    this.Close();
                    break;
                case "button_ok":
                    if (Create_Product())
                        this.Close();
                    break;
                case "button_remove":
                    while (product_items.SelectedIndex >= 0)
                        product_items.Items.RemoveAt(product_items.SelectedIndex);
                    break;
                default: break;
            }
        } 

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that will load all of the products into the form
        /// </summary>
        private void LoadProducts()
        {
            // Gets the products from the database
            var items = new Product().Query("SELECT * FROM products");

            // Add the products into the container
            if (items != null)
            {
                foreach (var row in items)
                {
                    ProductItem item = new ProductItem() { ProductCode = row.product_code, ProductName = row.name };
                    item.Click += (sender, e) => { product_items.Items.Add(((sender as Control).Parent as ProductItem).ProductCode); };
                    product_list.Controls.Add(item);
                }
            }
        }

        /// <summary>
        /// The method that will create a product
        /// </summary>
        /// <returns>bool</returns>
        private bool Create_Product()
        {
            Product product = new Product()
            {
                product_code = text_product_code.Text,
                name = text_product_name.Text,
                description = text_product_description.Text
            };

            if (product_items.Items.Count > 0)
                foreach (var item in product_items.Items)
                    product.Items.Add(new Product_Item() { parent_product = text_product_code.Text, component = item.ToString() });

            return product.Create(product);
        } 

        #endregion
    }
}
