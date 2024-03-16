

using MailingListDapp;

public void InsertCustomer(Customer customer)
{
    using (var connection = new SqlConnection("YourConnectionString"))
    {
        connection.Open();
        string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
        connection.Execute(query, customer);
    }
}

public void InsertCountry(Country country)
{
    using (var connection = new SqlConnection("YourConnectionString"))
    {
        connection.Open();
        string query = "INSERT INTO Countries (Name) VALUES (@Name)";
        connection.Execute(query, country);
    }
}

public void InsertCity(City city)
{
    using (var connection = new SqlConnection("YourConnectionString"))
    {
        connection.Open();
        string query = "INSERT INTO Cities (Name, CountryId) VALUES (@Name, @CountryId)";
        connection.Execute(query, city);
    }
}

public void InsertCategory(Category category)
{
    using (var connection = new SqlConnection("YourConnectionString"))
    {
        connection.Open();
        string query = "INSERT INTO Categories (Name) VALUES (@Name)";
        connection.Execute(query, category);
    }
}

public void InsertPromotionalProduct(PromotionalProduct product)
{
    using (var connection = new SqlConnection("YourConnectionString"))
    {
        connection.Open();
        string query = "INSERT INTO PromotionalProducts (Name, Price, CategoryId) VALUES (@Name, @Price, @CategoryId)";
        connection.Execute(query, product);
    }
}
var customer = new Customer { Name = "John Doe", Email = "johndoe@example.com", Phone = "1234567890" };
InsertCustomer(customer);

var country = new Country { Name = "USA" };
InsertCountry(country);

var city = new City { Name = "New York", CountryId = 1 };
InsertCity(city);

var category = new Category { Name = "Electronics" };
InsertCategory(category);

var product = new PromotionalProduct { Name = "Smartphone", Price = 499.99m, CategoryId = 1 };
InsertPromotionalProduct(product);
