using System.ComponentModel.DataAnnotations; // pour les notations key, requireed
using System.ComponentModel.DataAnnotations.Schema;

namespace firstDot.Models
{
    public class Categories {
        [Key]
        public int Id_categorie {get;set;}
        [Required]
        [MaxLength(50)]
        public required string Nom_categorie {get;set;}
        public ICollection<Produits>Produits {get;set;} = new List<Produits>();
    }
    
}