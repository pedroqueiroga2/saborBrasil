using System.ComponentModel.DataAnnotations;
namespace SaborDoBrasil.API.Models
{
    public class Publicacao
    {
        [Key]
        public int IdPublicacao { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
        public string? ImagemUrl { get; set; }

        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
