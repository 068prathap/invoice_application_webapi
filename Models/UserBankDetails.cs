using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApplication.Models
{
    public class UserBankDetails
    {
        [Key]
        public int BankDetailsId { get; set; }
        public string BankName { get; set;}
        public string BankAccountNo { get; set;}
        public string BankBranch { get; set;}
        public string IFSCode { get; set; }
    }
}
