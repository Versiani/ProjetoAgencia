using System.ComponentModel.DataAnnotations;

namespace ProjetoAgencia.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public string NomeDestino { get; set; }
        public DateTime Data { get; set; }
    }
}
