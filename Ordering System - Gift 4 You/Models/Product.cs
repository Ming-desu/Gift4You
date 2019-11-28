namespace Ordering_System___Gift_4_You
{
    using System.Collections.Generic;

    /// <summary>
    /// The model of the products
    /// </summary>
    public class Product : Database<Product>
    {
        #region Public Properties

        /// <summary>
        /// The code of the product
        /// </summary>
        public string product_code { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The items associated with the product
        /// </summary>
        public List<Product_Item> Items { get; set; } = new List<Product_Item>();

        #endregion

        #region Public Methods

        /// <summary>
        /// The method that will create a product
        /// </summary>
        /// <param name="product">The product to be created</param>
        /// <returns>bool</returns>
        public bool Create(Product product)
        {
            // Check for some errors
            string error = "";
            if (string.IsNullOrWhiteSpace(product.product_code))
                error = "Product Code is required.";
            else if (string.IsNullOrWhiteSpace(product.name))
                error = "Product Name is required.";
            else if (string.IsNullOrWhiteSpace(product.description))
                error = "Product Description is required.";
            else
            {
                // Check if the product is already existing
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("product_code", product.product_code);

                var result = product.Query("SELECT * FROM products WHERE product_code = @product_code", parameters);

                // If not add the produt to the database
                if (result == null)
                {
                    parameters.Add("name", product.name);
                    parameters.Add("description", product.description);

                    product.Query("INSERT INTO products (product_code, name, description) VALUES (@product_code, @name, @description)", parameters);

                    // If there were items put inside
                    // or simply it is a package
                    // Add the items into database also
                    if (product.Items.Count > 0)
                    {
                        foreach (var item in product.Items)
                        {
                            parameters = new Dictionary<string, object>();
                            parameters.Add("parent_product", item.parent_product);
                            parameters.Add("component", item.component);

                            Product_Item product_item = new Product_Item();
                            product_item.Query("INSERT INTO product_items (parent_product, component) VALUES (@parent_product, @component)", parameters);
                        }
                    }
                }
                else
                    error = "Product Code is already existing.";
            }

            // Output a notification depending on the error
            if (string.IsNullOrWhiteSpace(error))
            {
                new Notification("Successfully created a product.").ShowDialog();
                return true;
            }
            else
                new Notification(error, "We encountered a problem.", MessageType.Danger).ShowDialog();

            return false;
        }

        /// <summary>
        /// The method that will read all of the product in the database
        /// </summary>
        /// <param name="search">The string to be searched</param>
        /// <returns></returns>
        public List<ProductUI> Read(string search = "")
        {
            // Create a container
            List<ProductUI> product_items = new List<ProductUI>();

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("search", search + "%");

            // Get all of the products in the database
            var result = Query("SELECT * FROM products WHERE product_code LIKE @search OR name LIKE @search", parameters);

            if (result != null)
            {
                // Add each and every result into the container
                foreach (var row in result)
                {
                    ProductUI productUI = new ProductUI()
                    {
                        ProductCode = row.product_code,
                        ProductName = row.name,
                        ProductDescription = row.description
                    };

                    parameters = new Dictionary<string, object>();
                    parameters.Add("code", row.product_code);
                    var items = Query("SELECT * FROM product_items LEFT JOIN products ON product_items.component = products.product_code WHERE parent_product = @code", parameters);

                    if (items != null)
                        productUI.ProductItems = items;

                    product_items.Add(productUI);
                }
            }

            return product_items;
        }

        /// <summary>
        /// The method that will update a product
        /// </summary>
        /// <param name="product">The product to be updated</param>
        /// <returns>bool</returns>
        public bool Update(Product product)
        {
            // Check for some errors
            string error = "";
            if (string.IsNullOrWhiteSpace(product.product_code))
                error = "Product Code is required.";
            else if (string.IsNullOrWhiteSpace(product.name))
                error = "Product Name is required.";
            else if (string.IsNullOrWhiteSpace(product.description))
                error = "Product Description is required.";
            else
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("product_code", product.product_code);
                parameters.Add("name", product.name);
                parameters.Add("description", product.description);

                // Update the product
                product.Query("UPDATE products SET product_code = @product_code, name = @name, description = @description WHERE product_code = @product_code", parameters);

                parameters = new Dictionary<string, object>();
                parameters.Add("product_code", product.product_code);

                // Delete the old items inside of it if it has
                product.Query("DELETE FROM product_items WHERE parent_product = @product_code", parameters);

                // Add the items that was put here
                if (product.Items.Count > 0)
                    foreach (var item in product.Items)
                    {
                        parameters = new Dictionary<string, object>();
                        parameters.Add("parent_product", item.parent_product);
                        parameters.Add("component", item.component);

                        product.Query("INSERT INTO product_items (parent_product, component) VALUES (@parent_product, @component)", parameters);
                    }
            }

            // Output a notification depending on the error
            if (string.IsNullOrWhiteSpace(error))
            {
                new Notification("Successfully updated a product.").ShowDialog();
                return true;
            }
            else
                new Notification(error, "We encountered a problem.", MessageType.Danger).ShowDialog();

            return false;
        }

        /// <summary>
        /// The method that will delete a product
        /// </summary>
        /// <param name="product">The product to be deleted</param>
        public void Delete(ProductUI product)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("product_code", product.ProductCode);

            Query("DELETE FROM product_items WHERE parent_product = @product_code OR component = @product_code", parameters);
            Query("DELETE FROM products WHERE product_code = @product_code", parameters);

            new Notification("Successfully deleted a record.").ShowDialog();
        } 

        #endregion
    }
}
