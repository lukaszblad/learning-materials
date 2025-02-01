namespace ManyToManyRelationship.Models
{
    public class MyItemClient
    {
        public int MyItemId { get; set; }
        public MyItem? MyItem { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
    }
}
