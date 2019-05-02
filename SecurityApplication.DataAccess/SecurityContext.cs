namespace SecurityApplication.DataAccess
{
    using SecurityApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<User> Users { get; set; }
    }
}