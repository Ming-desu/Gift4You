namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The form for adding a customer
    /// </summary>
    public partial class Form_AddCustomer : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form_AddCustomer()
        {
            InitializeComponent();

            Animator.FadeIn(this);
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
                    if (Create_Record())
                        this.Close();
                    break;
                default: break;
            }
        } 

        #endregion

        #region Private Helpers

        /// <summary>
        /// The method that will create a record 
        /// </summary>
        /// <returns>bool</returns>
        private bool Create_Record()
        {
            Customer customer = new Customer()
            {
                name = text_customer_name.Text,
                phone = text_phone.Text,
                address = text_address.Text
            };

            return customer.Create(customer);
        } 

        #endregion
    }
}
