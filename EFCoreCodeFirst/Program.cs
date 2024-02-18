using EFCoreCodeFirst;
using EFCoreCodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        var state = _context.Entry(p).State; // detached
        Console.WriteLine($"{p.Name} state: {state}");
    });

    /*
    
    5.removing
    var product = await _context.Products.FirstAsync();
    Console.WriteLine($"İlk state: {_context.Entry(product).State}");  // unchanged

    _context.Remove(product);
    Console.WriteLine($"Ater removing state: {_context.Entry(product).State}");  // deleted

    await _context.SaveChangesAsync();
    Console.WriteLine($"Ater saving changes state: {_context.Entry(product).State}");  // detached. Because there is no this  object anymore.


    4.Updating the detached product.
   var product = await _context.Products.FirstAsync();
    Console.WriteLine($"İlk state: {_context.Entry(product).State}");  // unchanged

    _context.Entry(product).State = EntityState.Detached;  //  Dont track this product. 

    Console.WriteLine($"After detaching state: {_context.Entry(product).State}");  // detached

    product.Stock = 50; //  doesnt update unless we use Update method.

    _context.Update(product);
    // _context.Entry(product).State = EntityState.Modified; 

    Console.WriteLine($"After Updating state: {_context.Entry(product).State}");  // modified

    await _context.SaveChangesAsync();

    Console.WriteLine($"After Saving Changes state: {_context.Entry(product).State}");  // unchanged


    3.Updating the first product:
    var product = await _context.Products.FirstAsync();
    Console.WriteLine($"İlk state: {_context.Entry(product).State}");  // unchanged

    product.Stock = 200;

    Console.WriteLine($"After updating state: {_context.Entry(product).State}");  // modified

    _context.SaveChanges();

    Console.WriteLine($"After updating state: {_context.Entry(product).State}");  // unchanged

    2.adding new product : 
    var newProduct = new Product
    {
        Name = "Kalem 100",
        Price = 1000,
        Stock = 100,
        Barcode = "testkalem1000"
    };

    Console.WriteLine($"First State : {_context.Entry(newProduct).State} ");  // detached :  EFCore doesnt track this object.

    await _context.AddAsync(newProduct);
    _context.Entry(newProduct).State = EntityState.Added;  => we dont usually use  this because it is long.

    Console.WriteLine($"After Add State : {_context.Entry(newProduct).State} "); // added 

    await _context.SaveChangesAsync();

    Console.WriteLine($"After Save Changes State : {_context.Entry(newProduct).State} "); // unchanged


    1.listing
    products.ForEach(p =>
    {
        var state = _context.Entry(p).State;
        Console.WriteLine($"{p.Id} : {p.Name}-{p.Price}-{p.Stock} state: {state}");
    });

    */
}