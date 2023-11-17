using System.Security.Cryptography.X509Certificates;

namespace MayoroMenor
{
    public class Mayor
    {
        public  void MostraMaxMinArrayEnteros()
        {
            int[] datos = {5,10,15,20,25,100,27,18,9,3};
            
            int max = datos[0];
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] > max)
                    max = datos [i];
            }
            Console.WriteLine(max);
        }
    }
    
} 