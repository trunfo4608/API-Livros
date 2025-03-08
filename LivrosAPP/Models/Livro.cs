namespace LivrosAPP.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }
        public string Titulo { get; set; }
        public decimal Valor { get; set; } 

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
