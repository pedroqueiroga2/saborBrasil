using System.ComponentModel.DataAnnotations;

namespace SaborDoBrasil.Models
{
    public class Publicacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        [StringLength(255)]
        public string ImagemPath { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}