using LivrosAPP.Model;
using LivrosAPP.Service.Data;
using LivrosAPP.Service.Interfaces;

namespace LivrosAPP.Service.Repositories
{
    public class AutorRepository : BaseRepository<Autor>, IAutorRepository
    {
        public Autor GetById(int id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Autores.FirstOrDefault(a => a.Id == id);
            }
        }
    }
}
