using Microsoft.EntityFrameworkCore;
namespace AdministratorAPI.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        
        
        public  DbSet<User> Usuarios { get; set; }
        
    }
}