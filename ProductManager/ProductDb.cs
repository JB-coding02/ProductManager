using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager;

public static class ProductDb
{
    /// <summary>
    /// Gets a connection object for the ProductManagerDb.
    /// The connection need to be opened and closed after it's used.
    /// </summary>
    /// <returns></returns>
    public static SqlConnection GetConnection()
    {
        return new SqlConnection("Data Source=localhost;Initial Catalog=ProductManagerDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
    }

    /// <summary>
    /// This will return all products from the database
    /// sorted in ascending order by Name.
    /// </summary>
    /// <returns></returns>
    public static List<Product> GetAllProducts()
    {
        // Get a database connection
        SqlConnection con = GetConnection();

        // Open connection
        con.Open();

        // Prepare SQL command
        // Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
        string query = """
            SELECT Id, SalesPrice, Name 
            FROM Products
            ORDER BY Name ASC
            """;
        SqlCommand selectCommand = new()
        {
            Connection = con,
            CommandText = query
        };

        // Execute command on the db
        SqlDataReader reader = selectCommand.ExecuteReader();

        // Store the results
        List<Product> allProducts = new();
        while(reader.Read())
        {
            Product p = new()
            {
                Name = reader["Name"].ToString(),
                Id = Convert.ToInt32(reader["Id"]),
                SalesPrice = Convert.ToDouble(reader["SalesPrice"])
            };

            //Make sure to add each product to the list so it gets returned.
            allProducts.Add(p);
        }

        // Close connection
        con.Close();

        return allProducts;
    }

    public static void AddProduct(Product p)
    {
        // Get a database connection
        SqlConnection con = GetConnection();

        // Open connection
        con.Open();

        // Use parameterized INSERT and return the new identity
        string query = """
            INSERT INTO Products (Name, SalesPrice)
            VALUES (@Name, @SalesPrice);
            SELECT SCOPE_IDENTITY();
            """;

        SqlCommand addCommand = new()
        {
            Connection = con,
            CommandText = query
        };

        // Add parameters to avoid SQL injection
        addCommand.Parameters.AddWithValue("@Name", p.Name ?? string.Empty);
        addCommand.Parameters.AddWithValue("@SalesPrice", p.SalesPrice);

        // Execute and capture the new Id (SCOPE_IDENTITY returns numeric/decimal)
        object result = addCommand.ExecuteScalar();
        if (result != null && result != DBNull.Value)
        {
            p.Id = Convert.ToInt32(result);
        }

        // Close connection
        con.Close();
    }

    public static void UpdateProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(Product p)
    {
        DeleteProduct(p.Id);
    }

    public static void DeleteProduct(int productId)
    {
        SqlConnection con = GetConnection();

        SqlCommand deleteCommand = new()
        {
            Connection = con,
            CommandText = "DELETE FROM Products WHERE Id = @prodId"
        };
        // using a parameterized query to prevent SQL Injection attacks
        deleteCommand.Parameters.AddWithValue("@prodId", productId);

        con.Open();

        int rows = deleteCommand.ExecuteNonQuery();

        con.Close();
    }
}
