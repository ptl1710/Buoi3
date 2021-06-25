using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Buoi3.Models
{
    public partial class BookManagerContext : DbContext
    {
        public BookManagerContext()
            : base("name=BookManagerContext")
        {
        }

        public virtual DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
