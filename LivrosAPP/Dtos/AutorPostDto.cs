using System.ComponentModel.DataAnnotations;

namespace LivrosAPP.Service.Dto
{
    public class AutorPostDto
    {
        [Required(ErrorMessage ="Nome obrigatório.")]
        [StringLength(100,MinimumLength =8,ErrorMessage ="Nome entre {2} e {1} caracteres.")]
        public string Nome { get; set; }

    }
}
