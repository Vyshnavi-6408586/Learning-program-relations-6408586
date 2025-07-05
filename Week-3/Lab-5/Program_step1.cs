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

        var products = await context.Products.ToListAsync();

        Console.WriteLine("📦 Product List:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }
    }
}