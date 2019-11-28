namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form for managing products
    /// </summary>
    public partial class Products : Form
    {
        #region Private Members

        /// <summary>
        /// The products that are available in the database
        /// </summary>
        private Product products = new Product();

        /// <summary>
        /// The ProductUI selected when a user clicked one
        /// </summary>
        private ProductUI selected_item; 

        #endregion

        #region Contructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Products()
        {
            InitializeComponent();

            ReadProducts();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that will load the products into the form
        /// <see cref="Product.Read(string)"/>
        /// </summary>
        /// <param name="search">The string to be searched</param>
        private void ReadProducts(string search = "")
        {
            // Gets all the available product with the string to searched
            var items = products.Read(search);

            // Clear any previous record in the container
            product_list.Controls.Clear();

            // Add the items if it not empty
            if (items != null)
            {
                foreach (var item in items)
                {
                    item.Click += Product_Click;
                    product_list.Controls.Add(item);
                }
            }
        } 

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event triggers when a record of product was clicked
        /// </summary>
        /// <param name="sender">The object who raised the event</param>
        /// <param name="e">The event itself</param>
        private void Product_Click(object sender, EventArgs e)
        {
            var control = sender as Control;

            // Gets the ProductUI that the user has selected
            selected_item = sender.GetType().ToString().Contains("ProductUI") == true ? control as ProductUI : control.Parent as ProductUI;
        }

        /// <summary>
        /// The event that will raised wheneve a user searched for something
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event itself</param>
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            ReadProducts((sender as Control).Text);
        }

        /// <summary>
        /// The event that handles all of the button action in the form
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "button_create":
                    new Form_AddProduct().ShowDialog();
                    ReadProducts();
                    break;
                case "button_update":
                    new Form_UpdateProduct(selected_item).ShowDialog();
                    ReadProducts();
                    break;
                case "button_delete":
                    if (new Confirm("Are you sure to delete this record?").Show() == DialogResult.Yes)
                    {
                        products.Delete(selected_item);
                        ReadProducts();
                    }
                    break;
                default: break;
            }
        } 

        #endregion
    }
}
