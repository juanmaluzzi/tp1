
using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia agencia1 = new Agencia(10);
            Console.WriteLine("Ingrese 1 si es administrador, 2 si es usuario");
            int usuario = int.Parse(Console.ReadLine());
            if (usuario >= 3 || usuario < 1)
            {
                Console.WriteLine("Valor Incorrecto");
            }
            else 
            { 
            if (usuario == 1)
            {
                Console.WriteLine("Opción 1: Ingresar nuevas Cabañas");
                Console.WriteLine("Opcion 2: Ingresar nuevos Hoteles");
                Console.WriteLine("Opcion 3: Volver");
                int choose = int.Parse(Console.ReadLine());

                if (usuario >= 4 || usuario < 1) { 
                    Console.WriteLine("Valor Incorrecto");

                } 
                else
                { 
                if (choose == 1)
                {
                    Console.WriteLine("Ingrese codigo de cabaña");
                    int codigoCab = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese nombre de cabaña");
                    string nombreCab = Console.ReadLine();
                    Console.WriteLine("Ingrese ciudad de cabaña");
                    string ciudadCab = Console.ReadLine();
                    Console.WriteLine("Ingrese barrio de cabaña");
                    string barrioCab = Console.ReadLine();
                    Console.WriteLine("Ingrese estrellas de cabaña");
                    int estrellasCab = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de Personas");
                    int cantPersonasCab = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿Tiene TV?");
                    bool tieneTv = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Precio por dia");
                    float precioDia = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de habitaciones");
                    int cantHabitaciones = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de baños");
                    int cantBanos = int.Parse(Console.ReadLine());

                    agencia1.insertarAlojamiento(new Cabaña(codigoCab, nombreCab, ciudadCab,
                        barrioCab, estrellasCab, cantPersonasCab, tieneTv, precioDia, cantHabitaciones, cantBanos));
                }

            }
        } }
    }
}
    }
