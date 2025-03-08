using LivrosAPP.Model;

namespace LivrosAPP.Service.Interfaces
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
        Livro GetById(int id);
    }
}
