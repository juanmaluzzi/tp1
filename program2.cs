using System;

namespace TP1
{
    class program2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Con 1 anda bien, con 2 anda mal");
            int usuario;
            usuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hola");
            if (usuario == 1)
                {
                    Console.WriteLine("Anda bien");
                }
            else
                {
                    Console.WriteLine("Mal");
                } 
        }

    }
}