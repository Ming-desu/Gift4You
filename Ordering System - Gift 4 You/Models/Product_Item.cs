namespace Ordering_System___Gift_4_You
{
    /// <summary>
    /// The model of the product item
    /// </summary>
    public class Product_Item : Database<Product_Item>
    {
        #region Public Properties

        /// <summary>
        /// The product code of the package
        /// </summary>
        public string parent_product { get; set; }

        /// <summary>
        /// The product code of the items of the package
        /// </summary>
        public string component { get; set; } 

        #endregion
    }
}
