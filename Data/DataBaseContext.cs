using CRUD_MVC_PhoneList.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC_PhoneList.Data
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext( DbContextOptions<DataBaseContext> options) : base(options) 
        {
        }
        public DbSet<Person> person { get; set; }
    }
}
