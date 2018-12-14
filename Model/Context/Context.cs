
using System.Data.Entity;

namespace Model.Context
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Context() : base("DefaultConnection")
        {
        }

        public static Context Create()
        {
            return new Context();
        }
    }
}
