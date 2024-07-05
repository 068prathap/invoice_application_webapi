using InvoiceApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApplication.Data
{
    public class InvoiceAppContext : DbContext
    {
        public InvoiceAppContext(DbContextOptions<InvoiceAppContext> Options): base(Options) { }

        public DbSet<UsersList> UsersList { get; set; }
        public DbSet<ClientsList> ClientsList { get; set; }
        public DbSet<BillsList> BillsList { get; set; }
        public DbSet<TranspotationDetails> TranspotationDetails { get; set;}
        public DbSet<InvoiceProductDetails> InvoiceProductDetails { get; set; }
        public DbSet<ProductsList> ProductsList { get; set; }
        public DbSet<UsersProfile> UsersProfile { get; set; }
        public DbSet<UserBankDetails> UserBankDetails { get; set; }
    }
}
