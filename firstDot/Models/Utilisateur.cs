using System.ComponentModel.DataAnnotations;

namespace firstDot.Models
{
    public class Utilisateur
    {
        [Key] // Déclare cette propriété comme clé primaire
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        // Ajouter d'autres propriétés, comme l'âge, le genre, etc.
        public int Age { get; set; }

        [StringLength(10)]
        public string Genre { get; set; }
    }
}
