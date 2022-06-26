using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocadoraVipFilmes.Auth.API.Context
{
    public class AuthDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityUser<int> admin = new IdentityUser<int>()
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 99999
            };

            var hasher = new PasswordHasher<IdentityUser<int>>();
            admin.PasswordHash = hasher.HashPassword(admin, "Admin@123");

            builder.Entity<IdentityUser<int>>().HasData(admin);

            #region Cria roles
            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>()
            {
                Id = 99999,
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>()
            {
                Id = 99998,
                Name = "funcionario",
                NormalizedName = "FUNCIONARIO"
            });

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>()
            {
                Id = 99997,
                Name = "cliente",
                NormalizedName = "CLIENTE"
            });
            #endregion

            builder.Entity<IdentityUserRole<int>>()
                .HasData(new IdentityUserRole<int> { RoleId=99999, UserId=99999 });

        }
    }
}
