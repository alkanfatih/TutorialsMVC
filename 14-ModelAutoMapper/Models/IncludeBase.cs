namespace _14_ModelAutoMapper.Models
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class EntityDto
    {
        public int Id { get; set; }
    }

    public class Customer : Entity
    {
        public string Name { get; set; }
    }

    public class Order : Entity
    {
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
    }

    public class OrderDto : EntityDto
    {
        public DateTime OrderDate { get; set; }
        public CustomerDto Customer { get; set; }
    }

    public class CustomerDto : EntityDto
    {
        public string Name { get; set; }
    }

}
