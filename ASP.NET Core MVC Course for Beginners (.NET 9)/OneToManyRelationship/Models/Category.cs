namespace OneToManyRelationship.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<MyItem> Items { get; set; } = null!;
    }
}
