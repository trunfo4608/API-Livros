namespace LivrosAPP.Service.Dto
{
    public class AutorGetDto
    {
        public int? Id { get; set; }
        public string? Nome {  get; set; }

        public DateTime? DataCriacao { get; set; } = DateTime.Now;
    }
}
