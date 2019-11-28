namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// The UserControl that will be use in <see cref="Products"/>
    /// </summary>
    public partial class ProductUI : UserControl
    {
        #region Private Members

        /// <summary>
        /// The code of the product
        /// </summary>
        private string product_code;

        /// <summary>
        /// The name of the product
        /// </summary>
        private string product_name;

        /// <summary>
        /// The description of the product
        /// </summary>
        private string product_description;

        /// <summary>
        /// The items present inside a package
        /// </summary>
        private List<Product> product_items = new List<Product>(); 

        #endregion

        #region Public Properties

        /// <summary>
        /// The code of the product
        /// </summary>
        public string ProductCode
        {
            get { return product_code; }
            set
            {
                product_code = value;
                label_code.Text = value; Invalidate();
            }
        }

        /// <summary>
        /// The name of the product
        /// </summary>
        public new string ProductName
        {
            get { return product_name; }
            set
            {
                product_name = value;
                label_name.Text = value;
                label_initial.Text = ProductName[0].ToString().ToUpper();
                label_initial.Left = (label_initial.Parent.Width - label_initial.Width) / 2;
                Invalidate();
            }
        }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string ProductDescription
        {
            get { return product_description; }
            set
            {
                product_description = value;
                label_description.Text = value; Invalidate();
            }
        }

        /// <summary>
        /// The items present inside a package
        /// </summary>
        public List<Product> ProductItems
        {
            get { return product_items; }
            set
            {
                product_items = value;
                if (value != null)
                    if (value.Count > 0)
                        button_viewmore.Visible = true;
            }
        }

        /// <summary>
        /// The new EventHandler Click method
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

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductUI()
        {
            InitializeComponent();
        } 

        #endregion

        #region Event Handlers

        /// <summary>
        /// The event that handles all of the button function in the form
        /// </summary>
        /// <param name="sender">The soure of the event</param>
        /// <param name="e">The event itself</param>
        private void button_viewmore_Click(object sender, EventArgs e)
        {
            // Gets all of the items inside a package if has
            string temp = "";
            foreach (var item in ProductItems)

                // Compile and store it into a single string
                temp += string.Format("Product Code: {0} \nProduct Name: {1} \nProduct Description: {2} \n\n", item.product_code, item.name, item.description);

            // Show the compile string in a messagebox
            MessageBox.Show(temp, "Order Details:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

        #endregion
    }
}
