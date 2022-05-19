using MyCommerce.Models;
using System.Data.SqlClient;

namespace MyCommerce.Persisters
{
    public class CustomerPersister : Persister<Customer>
    {
        public void Persist(Customer customer) //TODO implementare che se esisete già lo crea nuovo altrimenti lo aggiorna
        {
            var query = @"INSERT INTO Customers(Email,Name,Surname,BirthDate) 
                    OUTPUT inserted.IdCustomer 
                    VALUES(@Email, @Name, @Surname, @BirthDate); ";
            using var connection = new SqlConnection(Constants.SqlConnectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", customer.Email);
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Surname", customer.Surname);
            command.Parameters.AddWithValue("@BirthDate", customer.BirthDate);
            Convert.ToInt32(command.ExecuteScalar());
        }

    }
}
