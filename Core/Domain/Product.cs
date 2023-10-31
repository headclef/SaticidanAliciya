using Domain.Common;

namespace Domain
{
    public class Product : BaseEntity
    {
        public string? Description { get; set; }
        public string? DescriptionShort { get; set; }
        public List<string>? Images { get; set; }
        public float? Price { get; set; }
        public float? Discount { get; set; }

        // Satıcının Primary Key 'i
        public int IdDealer { get; set; }
    }
}
