using crud_entity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace crud_entity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Evita que las tablas que se crearán con los modelos se popúlaricen (en vez de qeu se llame Students, se llamará Student)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}