namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form that will update a product
    /// </summary>
    public partial class Form_UpdateProduct : Form
    {
        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="product">The ProductUI selected</param>
        public Form_UpdateProduct(ProductUI product)
        {
            InitializeComponent();

            Animator.FadeIn(this);
            LoadData(product);
            LoadProducts();
        } 

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that handles all of the button functions in the form
        /// </summary>
        /// <param name="sender">The source of the event</param>
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
                    if (Update_Record())
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
        /// The method that will load the information from the selected ProductUI into the form
        /// </summary>
        /// <param name="product">The ProductUI selected</param>
        private void LoadData(ProductUI product)
        {
            text_product_code.Text = product.ProductCode;
            text_product_name.Text = product.ProductName;
            text_product_description.Text = product.ProductDescription;

            if (product.ProductItems.Count > 0)
            {
                foreach (var item in product.ProductItems)
                {
                    product_items.Items.Add(item.product_code);
                }
            }
        }

        /// <summary>
        /// The method that will load all of the products into the form
        /// </summary>
        private void LoadProducts()
        {
            // Gets all of the products in the database
            var items = new Product().Query("SELECT * FROM products");

            // Adds the products into the container
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
        /// The method that will update a record
        /// </summary>
        /// <returns></returns>
        private bool Update_Record()
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

            return product.Update(product);
        } 

        #endregion
    }
}
