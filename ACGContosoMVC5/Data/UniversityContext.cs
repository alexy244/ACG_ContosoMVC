using ACG_ContosoMVC5.Models;
using System.Data.Entity;

namespace ACGContosoMVC5.Data
{
    /// <summary>
    /// You made this class a DbSet when it should be a DbContext!!!
    /// </summary>
    public class UniversityContext: DbContext
    {

         public UniversityContext() : base("UniversityContext")
         {

         }

         public DbSet<Student> Students { get; set; }
         public DbSet<Enrollment> Enrollments { get; set; }
         public DbSet<Course> Courses { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
          // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         }

    } 
}