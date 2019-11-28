namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form that will update a customer
    /// </summary>
    public partial class Form_UpdateCustomer : Form
    {
        #region Private Members
        
        /// <summary>
        /// The id of the customer
        /// </summary>
        private int customer_id;

        #endregion

        #region Constructor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="customer">The CustomerUI selected</param>
        public Form_UpdateCustomer(CustomerUI customer)
        {
            InitializeComponent();

            Animator.FadeIn(this);
            LoadData(customer);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// The button that will handle all of the button functions in this form
        /// </summary>
        /// <param name="sender">The object that will trigger the event</param>
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
                default: break;
            }
        } 

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that will load the information of the customer to the textboxes
        /// </summary>
        /// <param name="customer">The CustomerUI selected</param>
        private void LoadData(CustomerUI customer)
        {
            text_customer_name.Text = customer.CustomerName;
            text_phone.Text = customer.Phone;
            text_address.Text = customer.Address;
            customer_id = customer.CustomerId;
        }

        /// <summary>
        /// The method that will update a record to the database
        /// </summary>
        /// <returns>bool</returns>
        private bool Update_Record()
        {
            Customer customer = new Customer()
            {
                customer_id = customer_id,
                name = text_customer_name.Text,
                phone = text_phone.Text,
                address = text_address.Text
            };

            return customer.Update(customer);
        } 

        #endregion
    }
}
