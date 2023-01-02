namespace Negosud.dataaccess.Tables
{
    public class ReasonRegularization
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool Sense { get; set; }
        public Regularization[]? Regularizations { get; set; }
    }
}
