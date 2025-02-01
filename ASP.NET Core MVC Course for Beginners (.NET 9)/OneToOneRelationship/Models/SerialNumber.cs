using System.ComponentModel.DataAnnotations.Schema;

namespace OneToOneRelationship.Models
{
    public class SerialNumber
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? MyItemId { get; set; }
        [ForeignKey("ItemId")]
        public MyItem? MyItem { get; set; }
    }
}
