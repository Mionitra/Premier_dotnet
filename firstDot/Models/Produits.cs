using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Net.Http.Headers;

namespace firstDot.Models
{
    public class Produits {
        [Key]
        public int Id_produit {get;set;}
        [Required]
        [MaxLength(50)]
        public required string Nom_produit {get;set;}
        [ForeignKey("Id_cat")]
        public Categories?Categorie{get;set;}
        public int Id_cat {get;set;}

    }
}