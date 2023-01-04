using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public List<Item> Items { get; set; }
    }
}