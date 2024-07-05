using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApplication.Models
{
    public class BillsList
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateOnly InvoiceDate { get; set; }
        [ForeignKey("ClientsList")]
        public int ClientId { get; set; }
        public virtual ClientsList? ClientsList { get; set; }
        [ForeignKey("TranspotationDetails")]
        public int TranspotationId { get; set; }
        public virtual TranspotationDetails? TranspotationDetails { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal SGSTPercentage { get; set; }
        public decimal SGSTAmount { get; set; }
        public decimal CGSTPercentage { get; set; }
        public decimal CGSTAmount { get; set; }
        public decimal RoundOff { get; set; }
        public decimal FinalTotalAmount { get; set; }
    }
}
