using MayoroMenor;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Enteros MinumeroMayor = new Enteros();
            MinumeroMayor.MostraMaxMinArrayEnteros();
            Console.WriteLine("----------------------------");
            MinumeroMayor.SumaArrayEnteros();
            Console.WriteLine("----------------------------");
            MinumeroMayor.PromedioArrayEnteros();
            Console.WriteLine("----------------------------");
            MinumeroMayor.FrecuenciaArrayEnteros();
            Console.WriteLine("----------------------------");
            MinumeroMayor.ComplementoArrayCadenasAyB();
            Console.ReadLine();

            
        }
        
    }
} 