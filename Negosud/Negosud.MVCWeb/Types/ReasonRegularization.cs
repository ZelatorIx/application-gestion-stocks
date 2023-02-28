namespace Negosud.MVCWeb.Types
{
    public class ReasonRegularization
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool Sense { get; set; }
        public List<Regularization>? Regularizations { get; set; }
    }
}
