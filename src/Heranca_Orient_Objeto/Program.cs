using System;
using Heranca_Orient_Objeto.Entitties;

namespace Heranca_Orient_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(0010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);

            Console.ReadKey();

        }
    }
}
