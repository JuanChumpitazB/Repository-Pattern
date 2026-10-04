using EntregableIII.RepositoryPattern.Interfaces;
using EntregableIII.RepositoryPattern.Models;

namespace EntregableIII.RepositoryPattern.Repositories;

public class ProductoRepository : IProductoRepository
{
    private readonly List<Producto> _productos = new();

    public IEnumerable<Producto> GetAll()
    {
        return _productos;
    }

    public Producto? GetById(int id)
    {
        return _productos.FirstOrDefault(producto => producto.Id == id);
    }

    public void Add(Producto producto)
    {
        _productos.Add(producto);
    }

    public bool Update(Producto producto)
    {
        var index = _productos.FindIndex(item => item.Id == producto.Id);

        if (index == -1)
        {
            return false;
        }

        _productos[index] = producto;
        return true;
    }

    public bool Delete(int id)
    {
        var producto = GetById(id);

        if (producto is null)
        {
            return false;
        }

        return _productos.Remove(producto);
    }
}
