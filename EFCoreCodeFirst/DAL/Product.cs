namespace EFCoreCodeFirst.DAL
{
    public class Product
    {
        // Id or  ProductId => EFCore sets them as a default PK. 
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Barcode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
