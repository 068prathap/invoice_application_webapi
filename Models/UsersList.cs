using System.ComponentModel.DataAnnotations;

namespace InvoiceApplication.Models
{
    public class UsersList
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserTextileName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserPassword { get; set; }
    }
}