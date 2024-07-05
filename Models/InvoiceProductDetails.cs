using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApplication.Models
{
    public class InvoiceProductDetails
    {
        [Key]
        public int ProductDetailsId { get; set; }
        [ForeignKey("ProductsList")]
        public int ProductId { get; set; }
        public virtual ProductsList? ProductsList { get; set; }
        public int ClientHSNCode { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductRate { get; set; }
        public int ProductTotalAmount { get; set; }
        [ForeignKey("BillsList")]
        public int InvoiceId { get; set; }
        public virtual BillsList? BillsList { get; set; }
    }
}
