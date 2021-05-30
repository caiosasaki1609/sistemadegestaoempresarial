using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SGE.Context.Configurations;
using SGE.Context.Models;

namespace SGE.Context
{
    public class SGEDbContext : IdentityDbContext<Usuario>
    {
        public DbSet<Ponto> Ponto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public SGEDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsuarioConfiguration());
            builder.ApplyConfiguration(new AspNetUserClaimsConfiguration());
        }
    }
}