using System.ComponentModel.DataAnnotations;

namespace Projeto_BancoDados.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int idUsu { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage ="O Campo nome é obrigatorio")]
        public string nomeUsu { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "O Campo cargo é obrigatorio")]
        public string Cargo { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O Campo data nascimeto é obrigatorio")]
        public DateTime DataNasc { get; set; }
    }
}
