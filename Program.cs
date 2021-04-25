
using System;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia agencia1 = new Agencia(10);
            int menuInicial = 1;
            int menuAdministrador = 1;
            int menuUsuario = 1;

            //COMIENZO DE BUCLE DE MENU INICIAL
            do
            {
                Console.WriteLine("Ingresar 1 si es administrador, 2 si es usuario");
                Console.WriteLine("o 3 para salir.");
                int usuario = int.Parse(Console.ReadLine());

                //VALIDA SI ES ADMINISTRADOR
                if (usuario == 1)
                {
                    //COMIENZO DE BUCLE ADMINSITRADOR
                    do
                    {
                        Console.WriteLine("Opción 1: Ingresar nuevas Cabañas");
                        Console.WriteLine("Opcion 2: Ingresar nuevos Hoteles");
                        Console.WriteLine("Opcion 3: Volver");
                        int choose = int.Parse(Console.ReadLine());

                        //SELECTOR DE OPCIONES
                        switch (choose)
                        {
                            case 1:
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
                                Console.WriteLine("¿Tiene TV? Ingrese true o false");
                                bool tieneTv = bool.Parse(Console.ReadLine());
                                Console.WriteLine("Precio por dia");
                                float precioDia = float.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de habitaciones");
                                int cantHabitaciones = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de baños");
                                int cantBanos = int.Parse(Console.ReadLine());
                                //Guarda el array con los valores pasados por consola

                                //imprime el array 
                                Console.WriteLine(agencia1.insertarAlojamiento(new Cabaña(codigoCab, nombreCab, ciudadCab,
                                barrioCab, estrellasCab, cantPersonasCab, tieneTv, precioDia, cantHabitaciones, cantBanos)));
                                break;

                            case 2:
                                Console.WriteLine("Ingrese codigo de hotel");
                                int codigoHotel = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese nombre de hotel");
                                string nombreHotel = Console.ReadLine();
                                Console.WriteLine("Ingrese ciudad de hotel");
                                string ciudadHotel = Console.ReadLine();
                                Console.WriteLine("Ingrese barrio de hotel");
                                string barrioHotel = Console.ReadLine();
                                Console.WriteLine("Ingrese estrellas de hotel");
                                int estrellasHotel = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de Personas");
                                int cantPersonasHotel = int.Parse(Console.ReadLine());
                                Console.WriteLine("¿Tiene TV? Ingrese true o false");
                                bool tieneTvHotel = bool.Parse(Console.ReadLine());
                                Console.WriteLine("Precio por dia");
                                float precioDiaHotel = float.Parse(Console.ReadLine());
                                agencia1.insertarAlojamiento(new Hotel(codigoHotel, nombreHotel, ciudadHotel,
                                barrioHotel, estrellasHotel, cantPersonasHotel, tieneTvHotel, precioDiaHotel));
                                //imprime el array 
                                Console.WriteLine("Se ha ingresado el siguiente Hotel: ");
                                foreach (Alojamiento a in agencia1.getAlojamientos())
                                {
                                    Console.WriteLine(a.ToString());
                                }
                                break;

                            case 3:
                                menuAdministrador = 0;
                                break;

                            default:
                                Console.WriteLine("****Ingrese un número válido******");
                                break;

                        }
                    } while (menuAdministrador > 0);
                    menuAdministrador = 1;
                }
                else if (usuario == 2)
                {
                    do
                    {
                        //CODIGO PARA EL USUARIO, MOSTRAR CABAÑAS Y HOTELES
                    } while (menuUsuario > 0);
                }
                else if (usuario == 3) {
                    Console.WriteLine("Chau");
                    menuInicial = 0;
                }
                else
                {
                    Console.WriteLine("********Ingrese una opción válida********");
                }
            } while (menuInicial > 0);
        } 
    }
}

    
