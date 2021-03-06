using MyCommerce.Models;
using System.Data.SqlClient;

namespace MyCommerce.Retrievers
{
    public class CustomerRetriever
    {
        public Customer RetrieveById(int idCustomer)
        {
            var query = @"SELECT IdCustomer, Email, Name, Surname, BirthDate FROM Customers
                    WHERE IdCustomer = @idCustomer ;";
            using var connection = new SqlConnection(Constants.SqlConnectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idCustomer", idCustomer);

            using var reader = command.ExecuteReader();
            Customer customer = null;
            if (reader.Read())
            {
                customer = new Customer()
                {
                    IdCustomer = int.Parse(reader["IdCustomer"].ToString()),
                    Email = reader["Email"].ToString(),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    BirthDate = DateTime.Parse(reader["BirthDate"].ToString())
                };
            }
            return customer;
        }
    }
}
