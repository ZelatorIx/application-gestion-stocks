using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class ReasonRegularization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public bool Sense { get; set; }
        public Regularization[]? Regularizations { get; set; }
    }
}
