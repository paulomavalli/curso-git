using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
              ContaCorrente contaPaulo = new ContaCorrente();
            contaPaulo.titular = "Paulo";
            contaPaulo.ag = 1620;
            contaPaulo.conta = 480230;
            contaPaulo.saldo = 150.40;

            Console.WriteLine(" Titular da conta : " + contaPaulo.titular);
            Console.WriteLine(" Agencia : " + contaPaulo.ag);
            Console.WriteLine(" Conta Corrente : " + contaPaulo.conta);
            Console.WriteLine(" Saldo Disponivel : R$ " + contaPaulo.saldo);

            bool resultadoSaque = contaPaulo.Sacar(50.20);

            Console.WriteLine(" Saque efetuado");
            Console.WriteLine( resultadoSaque);
            Console.WriteLine(" Saldo Disponivel apos o saque : R$ " + contaPaulo.saldo);



            Console.ReadLine();

           

        }
    }
}
