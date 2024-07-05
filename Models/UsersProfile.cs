using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceApplication.Models
{
    public class UsersProfile
    {
        [Key]
        public int ProfileId { get; set; }
        public string UserGSTNo { get; set; }
        public string UserAddress { get; set; }
        [ForeignKey("UserBankDetails")]
        public int BankDetailsId { get; set; }
        public virtual UserBankDetails? UserBankDetails { get; set; }
        [ForeignKey("UsersList")]
        public int UserId { get; set; }
        public virtual UsersList? UsersList { get; set; }
    }
}
