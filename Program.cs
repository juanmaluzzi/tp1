
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
                if (usuario == 1)
                {
                    Console.WriteLine("Opción 1: Ingresar nuevas Cabañas");
                    Console.WriteLine("Opcion 2: Ingresar nuevos Hoteles");
                    Console.WriteLine("Opcion 3: Volver");
                    int choose = int.Parse(Console.ReadLine());
                                    
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
                                Console.WriteLine("¿Tiene TV?");
                                bool tieneTv = bool.Parse(Console.ReadLine());
                                Console.WriteLine("Precio por dia");
                                float precioDia = float.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de habitaciones");
                                int cantHabitaciones = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese cantidad de baños");
                                int cantBanos = int.Parse(Console.ReadLine());
                                //Guarda el array con los valores pasados por consola
                                agencia1.insertarAlojamiento(new Cabaña(codigoCab, nombreCab, ciudadCab,
                                barrioCab, estrellasCab, cantPersonasCab, tieneTv, precioDia, cantHabitaciones, cantBanos));
                                //imprime el array 
                                Console.WriteLine("Se ha ingresado la siguiente Cabaña: ");
                                foreach (Alojamiento a in agencia1.getAlojamientos()) 
                                    {
                                    Console.WriteLine(a.ToString());                                                                
                                    }     
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
                                Console.Clear();
                            break;

                            default:
                                Console.WriteLine("Ingrese un número válido");
                            break;

                         }

                }
                else if(usuario == 2)
                {
                    Console.WriteLine("Ingrese: ");
                    Console.WriteLine("1 - Para mostrar todos los alojamientos ordenados ");
                    Console.WriteLine("2 - Para mostrar todas las cabañas");
                    Console.WriteLine("3 - Para mostrar todos los hoteles");
                    int userOption = int.Parse(Console.ReadLine());
                    
                    if(userOption == 1)
                        {
                            Alojamiento[] alojamientosOrdenados = agencia1.getAlojamientos();

                            foreach(Alojamiento alojamientos in alojamientosOrdenados )
                            { 
                                Console.WriteLine("Alojamiento con mas estrellas: " + alojamientos.getEstrellas()
                                + "\nCantidad de personas: " + alojamientos.getCantPersonas()
                                + "\nCodigo de alojamiento: " + alojamientos.getCodigo());        
                            } 
                        }
                    else if(userOption == 2)
                        {
                            
                            Alojamiento[] alojamientosCabanas = agencia1.getAlojamientos();
                            foreach(Cabaña alojCab in alojamientosCabanas)
                            {                             
                                if(alojCab.getPrecioDia() > 500 && alojCab.getPrecioDia() < 1000 )
                                {
                                    Console.WriteLine(alojCab.ToString());       
                                }
                            }
                        }      
                    //CODIGO PARA EL USUARIO, MOSTRAR CABAÑAS Y HOTELES
                } 
        } 
    }
}

    
