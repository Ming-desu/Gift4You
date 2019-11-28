namespace Ordering_System___Gift_4_You
{
    using System.Collections.Generic;

    /// <summary>
    /// The model of the customer
    /// </summary>
    public class Customer : Database<Customer>
    {
        #region Private Members

        /// <summary>
        /// The id of the customer
        /// </summary>
        public int customer_id { get; set; }

        /// <summary>
        /// The name of hte customer
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The address of the customer
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// The phone of the customer
        /// </summary>
        public string phone { get; set; }

        #endregion

        #region Public Methods
        /// <summary>
        /// The method that will create a new customer
        /// </summary>
        /// <param name="customer">The customer itself</param>
        /// <returns></returns>
        public bool Create(Customer customer)
        {
            // Check for the errors
            string error = "";
            if (string.IsNullOrWhiteSpace(customer.name))
                error = "Name is required.";
            else if (string.IsNullOrWhiteSpace(customer.phone))
                error = "Phone number is required.";
            else if (string.IsNullOrWhiteSpace(customer.address))
                error = "Address is required.";
            else
            {
                // Check first if the customer is already existing in the database
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("customer_name", customer.name);

                var result = customer.Query("SELECT * FROM customers WHERE name = @customer_name", parameters);

                // Insert it into the database if not found
                if (result == null)
                {
                    parameters.Add("phone", customer.phone);
                    parameters.Add("address", customer.address);

                    customer.Query("INSERT INTO customers (name, phone, address) VALUES (@customer_name, @phone, @address)", parameters);
                }
                else
                    error = "Customer is already existing.";
            }

            // Output a notification depending on the error
            if (string.IsNullOrWhiteSpace(error))
            {
                new Notification("Successfully created a customer.").ShowDialog();
                return true;
            }
            else
                new Notification(error, "We encountered a problem.", MessageType.Danger).ShowDialog();

            return false;
        }

        /// <summary>
        /// The method that will read information of customer from the database
        /// </summary>
        /// <param name="search">The string to be searched</param>
        /// <returns></returns>
        public List<CustomerUI> Read(string search = "")
        {
            // Create a container of the customer
            List<CustomerUI> customer_items = new List<CustomerUI>();

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("search", search + "%");

            // Get the information from the database taking into account the search string
            var result = Query("SELECT * FROM customers WHERE name LIKE @search", parameters);

            if (result != null)
            {
                // Add all of the result into the container
                foreach (var row in result)
                {
                    CustomerUI customerUI = new CustomerUI()
                    {
                        CustomerId = row.customer_id,
                        CustomerName = row.name,
                        Phone = row.phone,
                        Address = row.address
                    };

                    customer_items.Add(customerUI);
                }
            }

            return customer_items;
        }

        /// <summary>
        /// The method that will update a customer
        /// </summary>
        /// <param name="customer">The customer to be updated</param>
        /// <returns></returns>
        public bool Update(Customer customer)
        {
            // Check for some errors
            string error = "";
            if (string.IsNullOrWhiteSpace(customer.name))
                error = "Name is required.";
            else if (string.IsNullOrWhiteSpace(customer.phone))
                error = "Phone number is required.";
            else if (string.IsNullOrWhiteSpace(customer.address))
                error = "Address is required.";
            else
            {
                // Check if the custoemer is already existing
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("customer_name", customer.name);
                parameters.Add("customer_id", customer.customer_id);

                var result = customer.Query("SELECT * FROM customers WHERE name = @customer_name AND customer_id != @customer_id", parameters);

                // Update the customer record if not existing
                if (result == null)
                {
                    parameters.Add("phone", customer.phone);
                    parameters.Add("address", customer.address);

                    customer.Query("UPDATE customers SET name = @customer_name, phone = @phone, address = @address WHERE customer_id = @customer_id", parameters);
                }
                else
                    error = "Customer is already existing.";
            }

            // Output a notification depending on the error
            if (string.IsNullOrWhiteSpace(error))
            {
                new Notification("Successfully updated a customer.").ShowDialog();
                return true;
            }
            else
                new Notification(error, "We encountered a problem.", MessageType.Danger).ShowDialog();

            return false;
        }

        /// <summary>
        /// The method that will delete a customer
        /// </summary>
        /// <param name="customer">The customer to be deleted</param>
        public void Delete(CustomerUI customer)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("customer_id", customer.CustomerId);

            // Delete all of information associated with the customer itself

            Query("DELETE FROM orders WHERE customer_id = @customer_id", parameters);
            Query("DELETE FROM order_details WHERE customer_id = @customer_id", parameters);
            Query("DELETE FROM customers WHERE customer_id = @customer_id", parameters);

            new Notification("Successfully deleted a record.").ShowDialog();
        } 

        #endregion
    }
}
