using DBLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Retrievers
{
    public class ProductRetriever
    {
        public Product RetrieveById(string c8)
        {
            var query = @"SELECT C8, Title, Description, ImageUrl, InStock FROM Products
                    WHERE C8 = @c8 ;";
            using var connection = new SqlConnection(Constants.SqlConnectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c8", c8);

            using var reader = command.ExecuteReader();
            Product product = null;
            if (reader.Read())
            {
                product = new Product()
                {
                    C8 = reader["C8"].ToString(),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    ImageUrl = reader["ImageUrl"].ToString(),,
                    InStock = int.Parse(reader["InStock"].ToString())
                };
            }
            return product;
        }
    }
}
