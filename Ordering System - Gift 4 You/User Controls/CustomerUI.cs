namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The UserControl for the Form <see cref="Customers"/>
    /// </summary>
    public partial class CustomerUI : UserControl
    {
        #region Private Members

        /// <summary>
        /// The name of the customer
        /// </summary>
        private string customer_name;

        /// <summary>
        /// The phone number of the customer
        /// </summary>
        private string phone;

        /// <summary>
        /// The address of the customer
        /// </summary>
        private string address; 

        #endregion

        #region Public Properties

        /// <summary>
        /// The id of the customer
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// The name of the customer
        /// </summary>
        public string CustomerName
        {
            get { return customer_name; }
            set
            {
                customer_name = value;
                label_customer_name.Text = value;
                label_initial.Text = CustomerName[0].ToString().ToUpper();
                label_initial.Left = (label_initial.Parent.Width - label_initial.Width) / 2;
                Invalidate();
            }
        }

        /// <summary>
        /// The phone number of the customer
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                label_phone.Text = value; Invalidate();
            }
        }

        /// <summary>
        /// The address of the customer
        /// </summary>
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                label_address.Text = value; Invalidate();
            }
        } 

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomerUI()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Create a new rule for the Click EventHandler
        /// The Click Event will be raised in each and every control in this Control
        /// </summary>
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control c in Controls)
                    if (c.Name != "button_viewmore")
                        c.Click += value;
            }
            remove
            {
                base.Click -= value;
                foreach (Control c in Controls)
                    if (c.Name != "button_viewmore")
                        c.Click -= value;
            }
        } 

        #endregion
    }
}
