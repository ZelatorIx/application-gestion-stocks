namespace Negosud.dataaccess
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Code { get; set; }
        public Family? Family { get; set; }
    }
}