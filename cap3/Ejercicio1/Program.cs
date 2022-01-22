class Program
    {
        public static void Main (string[] args)
        {
            double grados, radianes, pi = 3.1416;

            Console.WriteLine("Ingrese los grados a convertir: ");
            grados = Convert.ToDouble(Console.ReadLine());

            radianes = Radianes(grados, pi);

            Console.WriteLine($"{grados}Grados equivale a {radianes}Radianes");



 
            
 
        }

        public static double Radianes(double n1, double n2)
        {
            double r = 0.0;
            r = (n1 * n2) / 180;
            return r;
        }


    }
 