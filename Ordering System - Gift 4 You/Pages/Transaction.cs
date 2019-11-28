namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// The form that handles all of the action in the transaction
    /// </summary>
    public partial class Transaction : Form
    {
        #region Private Members

        /// <summary>
        /// The list of the customers from the database
        /// </summary>
        private List<Customer> senders = new List<Customer>();

        /// <summary>
        /// The list of the customers available less the sender
        /// </summary>
        private List<Customer> receivers = new List<Customer>();

        /// <summary>
        /// The order id of the current transaction
        /// </summary>
        private int order_id;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Transaction()
        {
            InitializeComponent();

            LoadProducts();
            LoadCustomers();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that loads the customer into the container
        /// </summary>
        private void LoadCustomers()
        {
            // Gets the records from the database
            senders = new Customer().Query("SELECT * FROM customers");

            // Add the customers to the container
            if (senders != null)
                foreach (var row in senders)
                    cb_sender.Items.Add(row.name);
        }

        /// <summary>
        /// The method that loads the customer into the container less the sender
        /// </summary>
        /// <param name="customer_id">The customer id of the sender</param>
        private void LoadCustomers(int customer_id)
        {
            // Creates a dictionary for the parameter to be passed on the query
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("customer_id", customer_id);

            // Gets all of the customers available in the database
            receivers = new Customer().Query("SELECT * FROM customers WHERE customer_id != @customer_id", parameters);

            // Add the customers to the container
            if (receivers != null)
                foreach (var row in receivers)
                    cb_receiver.Items.Add(row.name);
        }

        /// <summary>
        /// The method that loads all of the product into the container
        /// </summary>
        private void LoadProducts()
        {
            // Gets all of the products on the system
            var items = new Product().Query("SELECT * FROM products");

            // Add the products into the container
            if (items != null)
            {
                foreach (var row in items)
                {
                    ProductItem item = new ProductItem() { ProductCode = row.product_code, ProductName = row.name };
                    item.Width = product_list.Width - 20;
                    item.Margin = new Padding(0, 2, 0, 0);
                    item.Click += (sender, e) => { shopping_cart_list.Items.Add(item.ProductCode); };
                    product_list.Controls.Add(item);
                }
            }
        }

        /// <summary>
        /// The method that will place an order into the current transaction
        /// </summary>
        private void Order_Add()
        {
            // Check if the order was valid
            if (Validate_Order())
            {
                // If the transaction not started yet
                if (order_id == 0)
                {
                    // Start the transaction
                    Customer sender = senders[cb_sender.SelectedIndex];

                    Order order = new Order();
                    order.Create(sender);

                    // Get the order id from the database
                    order_id = order.GetOrderId();
                    cb_sender.Enabled = false;
                }

                // Add each and every item in the shopping cart into the order_details table in the database
                foreach (var item in shopping_cart_list.Items)
                {
                    Order_Detail order_detail = new Order_Detail() { order_id = order_id, product_code = item.ToString(), customer_id = receivers[cb_receiver.SelectedIndex].customer_id };
                    order_detail.Create(order_detail);
                }

                // Clear the shopping cart after placing an order
                shopping_cart_list.Items.Clear();
                new Notification("Order successfully placed.").ShowDialog();
            }
        }

        /// <summary>
        /// The method that will end the current transaction in order to proceed one
        /// </summary>
        private void Transaction_End()
        {
            cb_sender.Enabled = true;
            cb_sender.SelectedItem = null;
            cb_sender.Items.Clear();

            cb_receiver.SelectedItem = null;
            cb_receiver.Items.Clear();
            order_id = 0;

            new Notification("Transaction ended.").ShowDialog();
        }

        /// <summary>
        /// A helper method that will determine whether the order was valid or not
        /// </summary>
        /// <returns>bool</returns>
        private bool Validate_Order()
        {
            string error = "";
            if (!(cb_sender.SelectedIndex >= 0))
                error = "Please choose a sender.";
            else if (!(cb_receiver.SelectedIndex >= 0))
                error = "Please choose a receiver.";
            else if (shopping_cart_list.Items.Count == 0)
                error = "Please choose products.";

            if (string.IsNullOrWhiteSpace(error))
                return true;
            else
                new Notification(error, "Attention!", MessageType.Danger).ShowDialog();
            return false;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that handles all of the button functions in the current form
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "button_remove":
                    while (shopping_cart_list.SelectedIndex >= 0)
                        shopping_cart_list.Items.RemoveAt(shopping_cart_list.SelectedIndex);
                    break;
                case "button_add":
                    Order_Add();
                    break;
                case "button_end":
                    Transaction_End();
                    break;
                default: break;
            }
        }

        /// <summary>
        /// The event that will raised when the sender was changed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event itself</param>
        private void Sender_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex >= 0)
                LoadCustomers(senders[cb_sender.SelectedIndex].customer_id);
        } 

        #endregion
    }
}
