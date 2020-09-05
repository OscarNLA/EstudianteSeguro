

using System.Data.Entity;

namespace ApiSecureStudent.Models
{

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiSecureStudent.Models.Student> Students { get; set; }
    }
}