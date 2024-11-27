using firstDot.Models;
using Microsoft.EntityFrameworkCore;

namespace firstDot // Remplacez par votre namespace
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        // Déclarez vos DbSets ici, par exemple :
        public DbSet<Utilisateur> Users {get;set;}
        public DbSet<Produits> Produits {get;set;}
        public DbSet<Categories> Categories {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
            .HasMany(p=>p.Produits) // Categorie a un ou plusieurs produits
            .WithOne(e=>e.Categorie) // Un produit est lie avec un categorie
            .HasForeignKey(e=>e.Id_cat); // 
        }
    }
}
