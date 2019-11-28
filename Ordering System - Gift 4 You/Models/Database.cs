namespace Ordering_System___Gift_4_You
{
    using System.Reflection;
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;

    /// <summary>
    /// A helper class for the database 
    /// </summary>
    /// <typeparam name="T">The model of the table</typeparam>
    public class Database<T> where T : class, new()
    {
        #region Private Members

        /// <summary>
        /// The connection of the database
        /// </summary>
        private MySqlConnection con = new MySqlConnection("server=localhost; user=root; database=db_gift4you");

        /// <summary>
        /// The command builder of sql
        /// </summary>
        private MySqlCommand cmd;

        /// <summary>
        /// The data reader of the sql
        /// </summary>
        private MySqlDataReader dr;

        #endregion

        #region Public Methods

        /// <summary>
        /// The method that will communicate with the database
        /// </summary>
        /// <param name="query">The sql query</param>
        /// <param name="parameters">The parameters needed in the query</param>
        /// <returns>List<T></returns>
        public List<T> Query(string query, Dictionary<string, object> parameters = null)
        {
            // Initialize container
            List<T> models = new List<T>();

            // Open the connection to the database
            con.Open();

            // Create the command and pass the query and connection to it
            cmd = new MySqlCommand(query, con);

            // Check if there are parameters passed along
            // If there is, add the parameters to the command
            if (parameters != null && parameters.Count != 0)
                foreach (var parameter in parameters)
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);

            // Check if the query is select
            if (query.Split(' ')[0].ToLower() == "select")
            {
                // Read the results of the query
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Create an object from the generic class
                    T model = new T();

                    // Get the fields from the query results
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        // Set the values to the model
                        SetProperty(dr.GetName(i), dr[i], model);
                    }

                    // Add the object to the container
                    models.Add(model);
                }
            }

            // Execute the query
            else
                cmd.ExecuteNonQuery();

            // Check if the connection is still valid before closing
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            // Return the model or null if none
            return models.Count == 0 ? null : models;
        } 

        #endregion

        #region Helpers

        /// <summary>
        /// A method that will add the value to the property of the object
        /// </summary>
        /// <param name="propertyName">The name of the property</param>
        /// <param name="value">The value of the property</param>
        /// <param name="obj">The object where to put the property</param>
        private void SetProperty(string propertyName, object value, object obj)
        {
            PropertyInfo propInfo = obj.GetType().GetProperty(propertyName);
            if (propInfo != null && propInfo.CanWrite)
                propInfo.SetValue(obj, value, null);
        } 

        #endregion
    }
}
