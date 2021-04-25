using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP1
{
    class Agencia
    {
        protected Alojamiento[] misAlojamientos;
        private int cantAlojamientos;
        private int alojAgregados;

        public Agencia(int CantidadAlojamientos)
        {
            misAlojamientos = new Alojamiento[CantidadAlojamientos];
            cantAlojamientos = CantidadAlojamientos;
            alojAgregados = 0;
        }
        
        
        public string insertarAlojamiento (Alojamiento aloj)
        {
            misAlojamientos[alojAgregados] = aloj;
            alojAgregados++;
            return "Se ha ingresado el siguiente alojamiento: " +
                aloj.ToString();             
        }

        public bool estaAlojamiento(Alojamiento aloj)
        {
            for (int i = 0 ; i < misAlojamientos.Length ; i++)
                if(misAlojamientos[i].getCodigo() == aloj.getCodigo())
                    return true;
         
                    return false;
        }

        public bool estaLlena() { return alojAgregados == misAlojamientos.Length; }
        public bool hayAlojamientos() { return alojAgregados > 0; }

        public Agencia soloHoteles()
        {
            Agencia soloHoteles = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in misAlojamientos)
                if (a is Hotel)
                    soloHoteles.insertarAlojamiento(a);
            return soloHoteles;
        }

        public Agencia masEstrellas(int cant)
        {
            Agencia cabEstrellas = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in misAlojamientos)
                if (a.getEstrellas()>=cant)
                    cabEstrellas.insertarAlojamiento(a);
            return cabEstrellas;
        }

        public Agencia cabañasEntrePrecios(float mayor, float menor)
        {
            Agencia cabPrecios = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in misAlojamientos)
                if (a is Cabaña)
                {
                    Cabaña cabana = (Cabaña)a;
                    if (cabana.getPrecioPorPersona() >= menor && cabana.getPrecioPorPersona() <= mayor)
                        cabPrecios.insertarAlojamiento(cabana);
                }
                    
            return cabPrecios;
        }

        public int getCantidad() { return cantAlojamientos; }
        public void setCantidad(int CantAlojamientos) { cantAlojamientos=CantAlojamientos; }

        public Alojamiento[] getAlojamientos()
        {
            Alojamiento[] aloj = new Alojamiento [alojAgregados];
            for (int i = 0; i < alojAgregados; i ++)
                aloj[i] = misAlojamientos[i];
                return aloj.OrderBy(a => a.getEstrellas()).ThenBy(a => a.getCantPersonas()).ThenBy(a => a.getCodigo()).ToArray();
        }
    }
}
