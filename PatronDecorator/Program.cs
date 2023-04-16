
using PatronDecorator;

BebidaComponent cafe = new CafeSolo();
cafe = new Leche(cafe);
cafe = new Azucar(cafe);

Console.WriteLine($"Producto: {cafe.Description} tiene un costo de: ${cafe.Costo}");
Console.ReadKey();