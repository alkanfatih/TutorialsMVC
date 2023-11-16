namespace _13_ModelDataTransferObject.Models.DTOs
{
    // Kategori DTO
    //public class CategoryDTO
    //{
    //    public int CategoryId { get; set; }
    //    public string Name { get; set; }
    //}
    public record CategoryDTO
    {
        public int CategoryId { get; init; }
        public string Name { get; init; }
    }
}
