using System.Data.Entity;
using SecurityApplication.Services;

namespace SecurityApplication.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            context.Users.Add(new Models.User
            {
                Login = "admin",
                Password = SecurityHasher.HashPassword("123")
            });
        }
    }
}
