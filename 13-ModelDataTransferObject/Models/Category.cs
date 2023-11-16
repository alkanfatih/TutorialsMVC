namespace _13_ModelDataTransferObject.Models
{
    // Kategori Modeli
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }

}
