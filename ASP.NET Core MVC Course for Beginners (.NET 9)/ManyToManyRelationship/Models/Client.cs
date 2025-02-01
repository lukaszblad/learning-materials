namespace ManyToManyRelationship.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<MyItemClient>? MyItemClients { get; set; }
    }
}
