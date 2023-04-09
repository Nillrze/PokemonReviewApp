using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
	public class DataContext : DbContext

	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Oweners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PkemonOwner> PkemonOwners { get; set; }
        public DbSet<PkemonCategory> PkemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PkemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PkemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PkemonCategories)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PkemonCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.PkemonCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PkemonOwner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PkemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(po => po.PkemonOwners)
                .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PkemonOwner>()
                .HasOne(o => o.Owner)
                .WithMany(po => po .PkemonOwners)
                .HasForeignKey(o => o.OwnerId);
        }
    }
}