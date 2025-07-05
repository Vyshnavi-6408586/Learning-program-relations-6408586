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

        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);

        if (expensive != null)
        {
            Console.WriteLine($"Expensive Product: {expensive?.Name}");
        }
        
    }
}