namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// The UserControl that will be used in the Form <see cref="Orders"/>
    /// </summary>
    public partial class OrderUI : UserControl
    {
        #region Private Members

        /// <summary>
        /// The id of the order
        /// </summary>
        private int order_id;

        /// <summary>
        /// The name of the customer
        /// </summary>
        private string customer_name;

        /// <summary>
        /// The date of the order was created
        /// </summary>
        private DateTime date;

        /// <summary>
        /// The items of the order
        /// </summary>
        private List<Order_Detail> order_details = new List<Order_Detail>();

        #endregion

        #region Public Properties

        /// <summary>
        /// The id of the order
        /// </summary>
        public int OrderId
        {
            get { return order_id; }
            set
            {
                order_id = value;
                label_order.Text = "Order Id: " + value.ToString(); Invalidate();
            }
        }

        /// <summary>
        /// The name of the customer
        /// </summary>
        public string CustomerName
        {
            get { return customer_name; }
            set
            {
                customer_name = value;
                label_sender.Text = "Sender: " + value; Invalidate();
            }
        }

        /// <summary>
        /// The date of the order was created
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                label_timestamp.Text = "Timestamp: " + value.ToString("dd-MM-yyyy hh:mm:ss"); Invalidate();
            }
        }

        /// <summary>
        /// The items of the order
        /// </summary>
        public List<Order_Detail> OrderDetails
        {
            get { return order_details; }
            set
            {
                order_details = value;
                if (order_details.Count > 0)
                    button_viewmore.Visible = true;
            }
        } 

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrderUI()
        {
            InitializeComponent();
        } 

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that will fire whenever the user click the <see cref="button_viewmore"/>
        /// </summary>
        /// <param name="sender">The button itself</param>
        /// <param name="e">The event itself</param>
        private void button_viewmore_Click(object sender, EventArgs e)
        {
            // Iterate through each and every detail of the order
            string temp = "";
            foreach (var item in OrderDetails)

                // Compile the details into a single string
                temp += string.Format("Receiver: {0} \nProduct Code: {1} \n\n", item.name, item.product_code);

            // Show it in a message box
            MessageBox.Show(temp, "Order Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        #endregion
    }
}
