using LivrosAPP.Model;

namespace LivrosAPP.Service.Interfaces
{
    public interface IAutorRepository : IBaseRepository<Autor>
    {
        Autor GetById(int id);

    }
}
