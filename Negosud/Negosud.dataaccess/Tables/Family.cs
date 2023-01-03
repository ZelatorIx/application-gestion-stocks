using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public Item[]? Items { get; set; }
    }
}