using System;

namespace Delegates
{
    // este delegate pode ser apontado para qualquer função que tenha a mesma assinatura 
    // delegates são ponteiros de função type safe
    //  type safe -> siginifica que se a assinatura entre o método e a delegate não forem iguais, dará erro ao compilar
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            // o método Hello é passado como parâmetro pois possui a mesma assinatura entre a delegato e o método
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Chamando a função hello");
            Console.WriteLine("Hello World!");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
