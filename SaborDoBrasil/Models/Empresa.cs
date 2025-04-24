using System.ComponentModel.DataAnnotations;

namespace SaborDoBrasil.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(20)]
        public string Cnpj { get; set; }
    }
}