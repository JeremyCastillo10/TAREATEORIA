float nLados;
double valorLado;
char opcion;


Console.WriteLine(" QUE DESEA CALCULAR?");
Console.WriteLine("A)-Perimetro.");
Console.WriteLine("B)-Volumen.");
opcion = Convert.ToChar(Console.ReadLine());

         switch (opcion) {
             case 'A':
             Console.WriteLine("Ingrese la cantidad de lados de su poligono");
             nLados = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el valor de sus lados: ");
             valorLado = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine($"El perimetro es: {nLados * valorLado}");
             break;

             case 'B':
             Console.WriteLine("TODAVIA no programado");
             break;


         }


