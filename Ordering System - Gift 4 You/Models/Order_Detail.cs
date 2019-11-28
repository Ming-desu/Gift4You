namespace Ordering_System___Gift_4_You
{
    using System.Collections.Generic;

    /// <summary>
    /// The model of order details
    /// </summary>
    public class Order_Detail : Database<Order_Detail>
    {
        #region Public Properties

        /// <summary>
        /// The id of the order
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// The id of the customer
        /// </summary>
        public int customer_id { get; set; }

        /// <summary>
        /// The code of the product
        /// </summary>
        public string product_code { get; set; }

        /// <summary>
        /// The name of the customer
        /// </summary>
        public string name { get; set; } 

        #endregion

        #region Public Methods

        /// <summary>
        /// The method that will create a order detail
        /// </summary>
        /// <param name="order_detail">The order detail itself</param>
        public void Create(Order_Detail order_detail)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("order_id", order_detail.order_id);
            parameters.Add("customer_id", order_detail.customer_id);
            parameters.Add("product_code", order_detail.product_code);

            Query("INSERT INTO order_details (order_id, customer_id, product_code) VALUES (@order_id, @customer_id, @product_code)", parameters);
        } 

        #endregion
    }
}
