
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
            int menuPrice = 1;

            //COMIENZO DE BUCLE DE MENU INICIAL
            do
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Ingrese el número de opción deseada: ");
                Console.WriteLine("Opción 1: Usuario Administrador");
                Console.WriteLine("Opción 2: Usuario Cliente");
                Console.WriteLine("Opción 3: Salir");
                int usuario = int.Parse(Console.ReadLine());

                //VALIDA SI ES ADMINISTRADOR
                if (usuario == 1)
                {
                    //COMIENZO DE BUCLE ADMINSITRADOR
                    do
                    {
                        Console.WriteLine("***********************************");
                        Console.WriteLine("Ingrese el número de opción deseada:");
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
                                Console.WriteLine("¿Tiene TV?  (Opción 1: SI / Opción 0: NO");
                                int readTieneTv = int.Parse(Console.ReadLine());
                                Console.WriteLine("Precio por dia");
                                float precioDia = float.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de habitaciones");
                                int cantHabitaciones = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de baños");
                                int cantBanos = int.Parse(Console.ReadLine());

                                // Traduce el ingreso del usuario a bool
                                bool tieneTv;
                                if (readTieneTv == 1) { tieneTv = true; }
                                else{ tieneTv = false; }

                                // Guarda el array con los valores pasados por consola e imprime el Obj guardado
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
                                Console.WriteLine("¿Tiene TV?  (Opción 1: SI / Opción 0: NO");
                                int readTieneTvHotel = int.Parse(Console.ReadLine());
                                Console.WriteLine("Precio por dia");
                                float precioDiaHotel = float.Parse(Console.ReadLine());

                                // Traduce el ingreso del usuario a bool
                                bool tieneTvHotel;
                                if (readTieneTvHotel == 1) { tieneTvHotel = true; }
                                else { tieneTvHotel = false; }


                                // Guarda el array con los valores pasados por consola e imprime el Obj guardado
                                Console.WriteLine(agencia1.insertarAlojamiento(new Hotel(codigoHotel, nombreHotel, ciudadHotel,
                                barrioHotel, estrellasHotel, cantPersonasHotel, tieneTvHotel, precioDiaHotel)));
                                break;

                            case 3:
                                //VOLVER AL MENU ANTERIOR
                                menuAdministrador = 0;
                                break;

                            default:
                                Console.WriteLine("****Ingrese un número válido****");
                                break;

                        }
                    } while (menuAdministrador > 0);
                    menuAdministrador = 1;
                }
                else if (usuario == 2)
                {
                    do
                    {
                        Console.WriteLine("**********************************");
                        Console.WriteLine("Ingrese el número de opción deseada: ");
                        Console.WriteLine("Opción 1: Para mostrar todos los alojamientos ordenados");
                        Console.WriteLine("Opción 2: Mostrar cabañas entre rango de precios");
                        Console.WriteLine("Opción 3: Mostrar todos los hoteles");
                        Console.WriteLine("Opción 4: Volver");
                        int userOption = int.Parse(Console.ReadLine());

                        if (userOption == 1)
                        {
                            foreach (Alojamiento a in agencia1.getAlojamientos())
                            {
                                Console.WriteLine(a.ToString());
                            }
                        }
                        else if (userOption == 2)
                        {
                            Console.WriteLine("1 - Mostrar cabanas entre $100 y $999");
                            Console.WriteLine("2 - Mostrar cabanas entre $1000 y $1999");                 
                            Console.WriteLine("3 - Mostrar todas las cabanas por un precio superior a $2000");
                            Console.WriteLine("4 - Volver atras");
                            int priceRange = int.Parse(Console.ReadLine());

                            do
                            {
                                if (priceRange == 1) 
                                {
                                Alojamiento[] alojamientosCabanas = agencia1.getAlojamientos();
                                foreach (Cabaña alojCab in alojamientosCabanas)
                                    {
                                    if (alojCab.getPrecioDia() >= 500 && alojCab.getPrecioDia() < 1000)
                                        {
                                        Console.WriteLine(alojCab.ToString());
                                        }
                                    else
                                        {
                                        Console.WriteLine("No hay cabañas disponibles en este rango de precios");
                                        }
                                    }
                                }
                                else if (priceRange == 2)
                                {
                                Alojamiento[] alojamientosCabanas = agencia1.getAlojamientos();
                                foreach (Cabaña alojCab in alojamientosCabanas)
                                    {
                                    if (alojCab.getPrecioDia() > 1000 && alojCab.getPrecioDia() < 2000)
                                        {
                                        Console.WriteLine(alojCab.ToString());
                                        }
                                    else
                                        {
                                        Console.WriteLine("No hay cabañas disponibles en este rango de precios");
                                        }
                                    }        
                                }
                                else if (priceRange == 3)
                                {
                                Alojamiento[] alojamientosCabanas = agencia1.getAlojamientos();
                                foreach (Cabaña alojCab in alojamientosCabanas)
                                    {
                                    if (alojCab.getPrecioDia() > 2000)
                                        {
                                        Console.WriteLine(alojCab.ToString());
                                        }
                                    else
                                        {
                                        Console.WriteLine("No hay cabañas disponibles en este rango de precios");
                                        }
                                    }    
                                }
                                else if(priceRange == 4)
                                {
                                    menuPrice = 0;
                                }

                            } while (menuPrice > 0);

                        }
                        else if (userOption == 3)
                        {
                            Alojamiento[] alojamientosHotel = agencia1.getAlojamientos();
                            foreach(Hotel alojHotel in alojamientosHotel)
                            {
                                Console.WriteLine(alojHotel.ToString());
                            }
                        }
                        else if (userOption == 4) {
                            menuUsuario = 0;
                        }
                        
                    } while (menuUsuario > 0);
                }
                else if (usuario == 3) {
                    Console.WriteLine("Chau");
                    menuInicial = 0;
                }
                else
                {
                    Console.WriteLine("****Ingrese una opción válida****");
                }
            } while (menuInicial > 0);
        } 
    }
}

    
