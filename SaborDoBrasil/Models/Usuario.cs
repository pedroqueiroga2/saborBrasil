using System.ComponentModel.DataAnnotations;

namespace SaborDoBrasil.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Senha { get; set; }

        public ICollection<Publicacao> Publicacoes { get; set; }
    }
}