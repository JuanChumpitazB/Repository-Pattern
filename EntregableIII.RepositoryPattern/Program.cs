using EntregableIII.RepositoryPattern.Interfaces;
using EntregableIII.RepositoryPattern.Models;
using EntregableIII.RepositoryPattern.Repositories;

Console.WriteLine("=== Entregable III - Repository Pattern ===");
Console.WriteLine("Repositorio en memoria para productos.");
Console.WriteLine();

IProductoRepository productoRepository = new ProductoRepository();

productoRepository.Add(new Producto(1, "Laptop", 2500.00m));
productoRepository.Add(new Producto(2, "Monitor", 850.00m));

Console.WriteLine("Productos registrados:");
foreach (var producto in productoRepository.GetAll())
{
    Console.WriteLine($"{producto.Id} - {producto.Nombre} - S/ {producto.Precio:F2}");
}

Console.WriteLine();

var productoEncontrado = productoRepository.GetById(1);

if (productoEncontrado is not null)
{
    Console.WriteLine($"Producto encontrado: {productoEncontrado.Nombre}");

    productoRepository.Update(
        productoEncontrado with
        {
            Precio = 2400.00m
        });
}

productoRepository.Delete(2);

Console.WriteLine();
Console.WriteLine("Productos después de Update y Delete:");

foreach (var item in productoRepository.GetAll())
{
    Console.WriteLine($"{item.Id} - {item.Nombre} - S/ {item.Precio:F2}");
}
