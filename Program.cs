using System;
using ByteBank;

namespace Estudo_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException erro)
            {
                System.Console.WriteLine(erro.Message);
            }

            System.Console.WriteLine();
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {

            try
            {
                int resultado = Dividir(10, divisor);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //System.Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}