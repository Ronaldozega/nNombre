using System.Security.Cryptography.X509Certificates;

namespace MayoroMenor
{
    public class Enteros
    {
        public  void MostraMaxMinArrayEnteros()
        {
            int[] valores = {5,10,15,20,25,100,27,18,9,3};
            
            int maximo = valores[0];
            int minimo = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if(valores[i] > maximo)
                {
                    maximo = valores[i];
                }

                if(valores[i] < minimo)
                {
                    minimo = valores[i];
                }
            }
            Console.WriteLine("EL VALOR MINIMO ES : " + minimo );
            Console.WriteLine("EL VALOR MAXIMO ES : " + maximo );
        }

        public void SumaArrayEnteros()
            {
                int[] valores = {1,2,3,4,5,6,7,8,9,10};

                int suma = 0 ;

                for (int i = 0; i < valores.Length; i++)
                {
                    suma +=valores[i];
                }
                Console.WriteLine("LA SUMA ES : " + suma);
            }

        public void PromedioArrayEnteros() 
            {
	            double[] calificaciones = {15,33,28,14};
	            double promedio = calificaciones.Average();
	            Console.WriteLine("PROMEDIO : " + promedio);
            }
        public void FrecuenciaArrayEnteros()
    {
        
        int[] miArray = { 1, 2, 3, 4, 2, 5, 2, 6 };

        
        int elementoABuscar = 2;

        
        int frecuencia = ObtenerFrecuencia(miArray, elementoABuscar);


        Console.WriteLine($"La frecuencia de {elementoABuscar} es: {frecuencia}");
    }

    static int ObtenerFrecuencia(int[] array, int elemento)
    {
    
        int frecuencia = array.Count(e => e == elemento);
        return frecuencia;
    }



    public void  ComplementoArrayCadenasAyB()
    {      
        string[] arrayA = { "a", "b", "c", "d", "e" };
        string[] arrayB = { "c", "d", "e", "f", "g" };

        string[] complemento = ObtenerComplemento(arrayA, arrayB);


        static string[] ObtenerComplemento(string[] arrayA, string[] arrayB)
    {
        string[] complemento = arrayA.Except(arrayB).ToArray();
        return complemento;
    }
        Console.WriteLine("Complemento de A y B:");
        foreach (var elemento in complemento)
        {
            Console.Write(elemento + "  ,  ");
        }
    }
}

    }             

