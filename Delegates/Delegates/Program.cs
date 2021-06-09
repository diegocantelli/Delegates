using System;

namespace Delegates
{
    // este delegate pode ser apontado para qualquer função que tenha a mesma assinatura 
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
