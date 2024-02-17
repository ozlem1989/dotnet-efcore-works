
using EFCoreDatabaseFirstByScaffolding.Models;
using Microsoft.EntityFrameworkCore;

using (var _context = new EFCoreDatabaseFirstDBContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name}-{p.Price}-{p.Stock}"); 
    });

}