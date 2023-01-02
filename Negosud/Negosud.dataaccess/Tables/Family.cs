namespace Negosud.dataaccess.Tables
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public Item[]? Items { get; set; }
    }
}