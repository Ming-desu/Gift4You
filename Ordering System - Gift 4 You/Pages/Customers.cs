namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form that manage all of the customers
    /// </summary>
    public partial class Customers : Form
    {
        #region Private Members

        /// <summary>
        /// The customers registered in the database
        /// </summary>
        private Customer customers = new Customer();

        /// <summary>
        /// The selected CustomerUI that the user has clicked
        /// </summary>
        private CustomerUI selected_item; 

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Customers()
        {
            InitializeComponent();

            ReadCustomers();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that loads in records from the database into the form
        /// </summary>
        /// <param name="search">The string to be searched</param>
        private void ReadCustomers(string search = "")
        {
            // Gets all of the records form the database
            var items = customers.Read(search);

            // Clears the previous items in the container
            customer_list.Controls.Clear();

            // Add all of the items into the container
            if (items != null)
            {
                foreach (var item in items)
                {
                    item.Click += Customer_Click;
                    customer_list.Controls.Add(item);
                }
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that handles when a CustomerUI was clicked
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event itself</param>
        private void Customer_Click(object sender, EventArgs e)
        {
            var control = sender as Control;

            // Get and set the CustomerUI that the user has clicked
            selected_item = sender.GetType().ToString().Contains("CustomerUI") == true ? control as CustomerUI : control.Parent as CustomerUI;
        }

        /// <summary>
        /// The event that triggers when a user type of the search box
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event itself</param>
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            ReadCustomers((sender as Control).Text);
        }

        /// <summary>
        /// The event that handles all of the button functions in this form
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">The event itself</param>
        private void Button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "button_create":
                    new Form_AddCustomer().ShowDialog();
                    ReadCustomers();
                    break;
                case "button_update":
                    new Form_UpdateCustomer(selected_item).ShowDialog();
                    ReadCustomers();
                    break;
                case "button_delete":
                    if (new Confirm("Are you sure to delete this record?").Show() == DialogResult.Yes)
                    {
                        customers.Delete(selected_item);
                        ReadCustomers();
                    }
                    break;
                default: break;
            }
        } 

        #endregion
    }
}
