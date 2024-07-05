using System.ComponentModel.DataAnnotations;

namespace InvoiceApplication.Models
{
    public class ProductsList
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
