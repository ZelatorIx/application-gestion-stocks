namespace Negosud.dataaccess
{
    class Program
    {
        static void Main(string[] args)
        {
            NegosudContext.InitDataDb();

            //using (NegosudContext context = new NegosudContext())
            //{
            //    Family family = context.Families.First();
            //    family.Name = "rienàvoir";
            //    context.SaveChanges();
            //}
        }
    }
}