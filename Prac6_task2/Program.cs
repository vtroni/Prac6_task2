using System;
using System.Text.Json;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        string json = "{\"Id\":1,\"Name\":\"Laptop\",\"Price\":1600,\"Quantity\":7}";

        Product product = JsonSerializer.Deserialize<Product>(json);

        if (product != null)
        {
            Console.WriteLine("Deserialized Product:");
            Console.WriteLine($"Id: {product.Id}");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Quantity: {product.Quantity}");
        }
    }
}