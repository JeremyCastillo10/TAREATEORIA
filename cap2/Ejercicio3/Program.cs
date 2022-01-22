String codigo = "";

var cod = codigo;

Console.WriteLine("Ingrese el precio del producto: ");
double precio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el codigo del producto: ");
cod  = Console.ReadLine();

if(codigo.StartsWith("M"))
{
    Console.WriteLine("El producto es de medicina no hay impuestos...");
    Console.WriteLine($"El precio es: {precio}");
}
else 
    Console.WriteLine($"El impuesto del producto es de: {precio * (0.18)}$");
