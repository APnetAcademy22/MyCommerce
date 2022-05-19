
using DBLibrary.Entities;
using DBLibrary.Retrievers;

Customer c = new Customer()
{
    Email = "gimli@yahoo.it",
    Name = "Gimli",
    Surname = "The Dwarf",
    BirthDate = new DateTime(1950, 02, 11)
};

//CustomerPersister persister = new CustomerPersister();
//persister.Persist(c);
Console.WriteLine(new CustomerRetriever().RetrieveById(1).Name);