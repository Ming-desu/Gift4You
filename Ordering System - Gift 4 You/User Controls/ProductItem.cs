namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The UI design for the product item in the <see cref="Transaction"/>, <seealso cref="Form_AddProduct"/>, and <seealso cref="Form_UpdateProduct"/>
    /// </summary>
    public partial class ProductItem : UserControl
    {
        #region Private Members

        /// <summary>
        /// The product code of the item
        /// </summary>
        private string productCode;

        /// <summary>
        /// The product name of the item
        /// </summary>
        private string productName;

        #endregion

        #region Public Properties

        /// <summary>
        /// The color of the background gets when hovered
        /// </summary>
        public Color HoverColor { get; set; } = Color.FromArgb(197, 205, 215);

        /// <summary>
        /// The product code of the item
        /// </summary>
        public string ProductCode
        {
            get { return productCode; }
            set
            {
                productCode = value;
                label_product_code.Text = ProductCode;
            }
        }

        /// <summary>
        /// The product name of the item
        /// </summary>
        public new string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                label_product_name.Text = ProductName;
            }
        }

        /// <summary>
        /// Adds an event for all of the elements in this control
        /// </summary>
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control c in Controls)
                    c.Click += value;
            }
            remove
            {
                base.Click -= value;
                foreach (Control c in Controls)
                    c.Click -= value;
            }
        } 

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductItem()
        {
            InitializeComponent();

            Color backgroundColor = BackColor;

            hoverable.MouseEnter += (sender, e) => { BackColor = HoverColor; };
            hoverable.MouseLeave += (sender, e) => { BackColor = backgroundColor; };
        } 

        #endregion
    }
}
