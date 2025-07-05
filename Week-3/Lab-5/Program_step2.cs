using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        var product = await context.Products.FindAsync(1);

        if (product != null)
        {
            Console.WriteLine($"Found: {product.Name} - ₹{product.Price}");
        }
        
    }
}