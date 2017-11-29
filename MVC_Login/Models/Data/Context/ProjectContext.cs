using MVC_Login.Models.Data.Entities;
using System.Data.Entity;

namespace MVC_Login.Models.Data.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-N00BKHH\\MERT;Database=YMS3119AccountDB;uid=sa;pwd=123";
        }

        public DbSet<ApplicationUser> User { get; set; }
    }
}