using MyCommerce.Models;
using System.Data.SqlClient;

namespace MyCommerce.Persisters
{
    public class ProductPersister : Persister<Product>
    {
        public void Persist(Product product) //TODO implementare che se esisete già lo crea nuovo altrimenti lo aggiorna
        {
            var query = @"INSERT INTO Products(C8,Title,Description,ImageUrl,InStock) 
                    OUTPUT inserted.IdCustomer 
                    VALUES(@C8,@Title,@Description,@ImageUrl,@InStock); ";
            using var connection = new SqlConnection(Constants.SqlConnectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@C8", product.C8);
            command.Parameters.AddWithValue("@Title", product.Title);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@ImageUrl", product.ImageUrl);
            command.Parameters.AddWithValue("@InStock", product.InStock);
            Convert.ToInt32(command.ExecuteScalar());
        }

    }
}