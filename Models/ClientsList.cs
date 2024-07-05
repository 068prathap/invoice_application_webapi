using System.ComponentModel.DataAnnotations;

namespace InvoiceApplication.Models
{
    public class ClientsList
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientGSTNo { get; set; }
    }
}
