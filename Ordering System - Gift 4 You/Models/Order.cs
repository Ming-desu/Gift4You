namespace Ordering_System___Gift_4_You
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The model of the order
    /// </summary>
    class Order : Database<Order>
    {
        #region Public Properties

        /// <summary>
        /// The id of the order
        /// </summary>
        public int order_id { get; set; }

        /// <summary>
        /// The date when the order was generated
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// The id of the customer
        /// </summary>
        public int customer_id { get; set; }

        /// <summary>
        /// The name of the customer
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The details of the order
        /// </summary>
        public List<Order_Detail> order_details = new List<Order_Detail>();

        #endregion

        #region Public Methods

        /// <summary>
        /// The method that will create an order
        /// </summary>
        /// <param name="customer">The customer sender</param>
        public void Create(Customer customer)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("date", DateTime.Now);
            parameters.Add("customer_id", customer.customer_id);

            Query("INSERT INTO orders (date, customer_id) VALUES (@date, @customer_id)", parameters);
        }

        /// <summary>
        /// The method that will get the order id
        /// </summary>
        /// <returns>int</returns>
        public int GetOrderId()
        {
            return Convert.ToInt32(Query("SELECT max(order_id) as order_id FROM orders")[0].order_id);
        }

        /// <summary>
        /// The method that will read all of the order records from the database
        /// </summary>
        /// <param name="search">The string to be searched</param>
        /// <returns></returns>
        public List<OrderUI> Read(string search = "")
        {
            // Create a container
            List<OrderUI> order_items = new List<OrderUI>();

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("search", search + "%");

            // Gets all of the orders from the database
            var result = Query("SELECT orders.order_id, orders.date, customers.name FROM orders LEFT JOIN customers ON orders.customer_id = customers.customer_id WHERE name LIKE @search", parameters);

            if (result != null)
            {
                // Add all of the orders into the container
                foreach (var row in result)
                {
                    OrderUI order = new OrderUI()
                    {
                        OrderId = row.order_id,
                        CustomerName = row.name,
                        Date = row.date
                    };

                    parameters = new Dictionary<string, object>();
                    parameters.Add("order_id", order.OrderId);

                    // Get all of the associate data to the order and append to it
                    Order_Detail order_detail = new Order_Detail();
                    order.OrderDetails = order_detail.Query("SELECT customers.name, products.product_code FROM order_details LEFT JOIN customers ON order_details.customer_id = customers.customer_id LEFT JOIN products ON order_details.product_code = products.product_code WHERE order_details.order_id = @order_id", parameters);

                    order_items.Add(order);
                }
            }

            return order_items;
        } 

        #endregion
    }
}
