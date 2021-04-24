using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Cabaña:Alojamiento
    {
        protected float precioDia;
        protected int habitaciones;
        protected int baños;

        public Cabaña(int Codigo, string Nombre, string Ciudad, string Barrio, int Estrellas, int CantPersonas, bool Tv, float PrecioDIA, int Habitaciones, int Baños)
        {
            codigo = Codigo;
            nombre = Nombre;
            ciudad = Ciudad;
            barrio = Barrio;
            estrellas = Estrellas;
            cantPersonas = CantPersonas;
            tv = Tv;
            precioDia = PrecioDIA;
            habitaciones = Habitaciones;
            baños = Baños;
        }

        public void setPrecioPorPersona(float nuevoPrecioPP) { precioDia = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioDia; }

        public void setHabitaciones(int Habitaciones) { habitaciones = Habitaciones; }

        public int getHabitaciones() { return habitaciones; }

        public void setBaños(int Baños) { baños = Baños; }

        public int getBaños() { return baños; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioDia;
        }

    }
}
