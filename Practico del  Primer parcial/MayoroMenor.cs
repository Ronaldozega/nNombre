using System.Security.Cryptography.X509Certificates;

namespace MayoroMenor
{
    public class Mayor
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
    }

} 