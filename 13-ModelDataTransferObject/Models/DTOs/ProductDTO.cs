namespace _13_ModelDataTransferObject.Models.DTOs
{
    // Ürün DTO
    //public class ProductDTO
    //{
    //    public int ProductId { get; set; }
    //    public string Name { get; set; }
    //    public decimal Price { get; set; }
    //    public string CategoryName { get; set; }
    //}

    public record ProductDTO
    {
        public int ProductId { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public string CategoryName { get; init; }
    }

}
