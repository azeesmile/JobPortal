using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using JobPortal.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JobPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string UserType { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        #region Tables

        public DbSet<Applied_Job> Applied_Job { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Candidates_Address> Candidates_Address { get; set; }
        public DbSet<Candidates_Education> Candidates_Education { get; set; }
        public DbSet<Candidates_Hobbies> Candidates_Hobbies { get; set; }
        public DbSet<Candidates_Professional> Candidates_Professional { get; set; }
        public DbSet<Candidates_Skills> Candidates_Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Job_Shifts> Job_Shifts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salaries_Range> Salaries_Range { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Rename identity tables

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("User");

            modelBuilder.Entity<IdentityUserRole>()
                .ToTable("UserRole");

            modelBuilder.Entity<IdentityUserLogin>()
                .ToTable("UserLogin");

            modelBuilder.Entity<IdentityUserClaim>()
                .ToTable("UserClaim");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("Role");

            #endregion
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}