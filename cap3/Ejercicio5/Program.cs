public class Ejercicio5
{
   public static void Main() {

    int n;

    Console.WriteLine("Ingrese el numero: ");
    n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Su factorial es: {Factorial(n)}");


  
   }

    public static long Factorial(int n) 
    {
        if (n==1)               
            return 1;
        return n * Factorial(n-1);  
    }
}
