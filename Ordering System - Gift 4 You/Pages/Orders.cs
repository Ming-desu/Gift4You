namespace Ordering_System___Gift_4_You
{
    using System.Windows.Forms;

    /// <summary>
    /// The form that will manage all of the orders
    /// </summary>
    public partial class Orders : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Orders()
        {
            InitializeComponent();

            ReadOrders();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// The method that will load the orders from the database depending on the given search value
        /// <see cref="Order.Read(string)"/>
        /// </summary>
        /// <param name="search">The value to be searched</param>
        private void ReadOrders(string search = "")
        {
            // Gets all of the records available in the database
            var items = new Order().Read(search);

            // Clears the previous item from the container
            order_list.Controls.Clear();

            // Add all of the items to the container
            if (items != null)
            {
                foreach (var item in items)
                {
                    order_list.Controls.Add(item);
                }
            }
        }

        /// <summary>
        /// This event triggers when a user search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            ReadOrders((sender as Control).Text);
        } 

        #endregion
    }
}
