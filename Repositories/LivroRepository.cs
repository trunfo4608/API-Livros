using LivrosAPP.Model;
using LivrosAPP.Service.Data;
using LivrosAPP.Service.Interfaces;

namespace LivrosAPP.Service.Repositories
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public Livro GetById(int id)
        {
            using (var dataContext = new DataContext()) 
            {
                return dataContext.Livros.FirstOrDefault(l => l.Id == id);
            }
        }
    }
}
