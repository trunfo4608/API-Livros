using LivrosAPP.Model;
using System.ComponentModel.DataAnnotations;

namespace LivrosAPP.Service.Dtos
{
    public class LivroPostDto
    {
        [Required(ErrorMessage ="Genero Obrigatório.")]
        [StringLength(50,MinimumLength =8,ErrorMessage ="Genero entre {2} e {1} caracteres.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Editora Obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Editora entre {2} e {1} caracteres.")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Titulo Obrigatório.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Titulo entre {2} e {1} caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Titulo Obrigatório.")]
        [Range(0,99999,ErrorMessage ="Valor entre {1} e {2}.")]
        public decimal Valor { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Id Autor Obrigatório.")]
        public int AutorId { get; set; }
        

    }
}
