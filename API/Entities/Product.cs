namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; }= string.Empty;
        public long Price { get; set; }
        public string? PictureUrl { get; set; }
        public string Type { get; set; }= default!; 
        public string Brand { get; set; }= string.Empty;
        public int QuantityInStock { get; set; }

    }
}