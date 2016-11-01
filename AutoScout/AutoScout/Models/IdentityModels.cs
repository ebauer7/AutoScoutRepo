using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AutoScout.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class AutoScoutIdentityUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AutoScoutIdentityUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class AutoScoutDBContext : IdentityDbContext<AutoScoutIdentityUser>
    {
        public AutoScoutDBContext()
            : base("AutoScoutDefaultConnection", throwIfV1Schema: false)
        {
            
        }

        public static AutoScoutDBContext Create()
        {
            return new AutoScoutDBContext();
        }

        public DbSet<Dealership> Dealerships { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleImage> VehicleImages { get; set; }
    }
}