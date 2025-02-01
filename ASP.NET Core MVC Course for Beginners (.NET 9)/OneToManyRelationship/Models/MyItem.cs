using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyRelationship.Models
{
    public class MyItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}
