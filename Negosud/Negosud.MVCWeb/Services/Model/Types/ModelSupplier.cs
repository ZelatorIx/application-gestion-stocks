using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Services.Model.Types
{
    public interface ModelSupplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public int PostalCode { get; set; }
        public string Town { get; set; }
        public string Email { get; set; }
        public List<ModelCommandSupplier> CommandSuppliers { get; set; }
    }
}
