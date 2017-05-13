using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a tabuada desejada: ");
            string textoNum = Console.ReadLine();
            int numero = int.Parse(textoNum);
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = i * numero;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }
        }
    }
}
