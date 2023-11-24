using System.ComponentModel.DataAnnotations;

namespace bdExercicio.Models
{
    public class CadClientes
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF {  get; set; }
    }
}
