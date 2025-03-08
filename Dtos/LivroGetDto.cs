using LivrosAPP.Model;

namespace LivrosAPP.Service.Dtos
{
    public class LivroGetDto
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }
        public string Titulo { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataCriacao { get; set; }= DateTime.Now;

        public int AutorId { get; set; }
        
    }
}
