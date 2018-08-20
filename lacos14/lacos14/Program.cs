using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lacos14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa Laços 14");

            for ( int linha=0; linha <= 10; linha++)     // escrevendo numeros de 1 a 10 sendo que na primeira linha aparece somente um 
                                                         // e  na decima linha a contagem de 1 a 1
            {
                for(int coluna=0; coluna < linha; coluna++)   // aqui estou jogando o if dentro da condição do for 
                                                              // caso fosse int coluna=0; coluna <=10; coluna++
                                                              //meu if entraria como if (coluna < linha) {
                                                                                     // break;            }
                                                                                     
                {
                    Console.Write(coluna +1);
                
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
