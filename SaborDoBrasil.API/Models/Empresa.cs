using System.ComponentModel.DataAnnotations;
namespace SaborDoBrasil.API.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        public ICollection<Publicacao> Publicacoes { get; set; }
    }
}
