using EntregableIII.RepositoryPattern.Models;

namespace EntregableIII.RepositoryPattern.Interfaces;

public interface IProductoRepository
{
    IEnumerable<Producto> GetAll();

    Producto? GetById(int id);

    void Add(Producto producto);

    bool Update(Producto producto);

    bool Delete(int id);
}
