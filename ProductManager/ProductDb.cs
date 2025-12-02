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
        return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductManagerDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
    }

    /// <summary>
    /// This will return all products from the datatbase
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
        string query = """
            SELECT Id, SalesPrice, Name 
            FROM Products 
            ORDER BY Name ASC
            """;
        SqlCommand cmd = new()
        {
            Connection = con,
            CommandText = query
        };

        // Execute command on the db
        SqlDataReader reader = cmd.ExecuteReader();

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
        throw new NotImplementedException();
        //// Get a database connection
        //SqlConnection con = GetConnection();

        //// Open connection
        //con.Open();

        //// Use parameterized query and return the new identity
        //string query = """
        //    INSERT INTO Products (Name, SalesPrice)
        //    VALUES (@Name, @SalesPrice);
        //    SELECT CAST(SCOPE_IDENTITY() AS int);
        //    """;

        //SqlCommand cmd = new()
        //{
        //    Connection = con,
        //    CommandText = query
        //};

        //cmd.Parameters.AddWithValue("@Name", p.Name ?? string.Empty);
        //cmd.Parameters.AddWithValue("@SalesPrice", p.SalesPrice);

        //object result = cmd.ExecuteScalar();
        //if (result != null && int.TryParse(result.ToString(), out int newId))
        //{
        //    p.Id = newId;
        //}

        //// Close connection
        //con.Close();
    }

    public static void UpdateProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}
