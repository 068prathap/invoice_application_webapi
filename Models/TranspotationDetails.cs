using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApplication.Models
{
    public class TranspotationDetails
    {
        [Key]
        public int TranspotationId { get; set; }
        public string TranspotationMode { get; set; }
        public string TranspotationVehicleNo { get; set; }
        public DateOnly TranspotationDate { get; set; }
        public TimeOnly TranspotationTime { get; set; }
    }
}
