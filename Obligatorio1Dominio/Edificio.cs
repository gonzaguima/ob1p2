using System;
using System.Collections.Generic;

namespace Obligatorio1Dominio
{
    public class Edificio
    {
        private string nombre;
        private string direccion;
        private List<Apartamento> apartamentos;
        private Oficina oficina;
        private CasaHabitacion casaHabitacion;

        public Edificio(string nombre, string direccion, List<Apartamento> apartamentos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.apartamentos = apartamentos;
        }

        //public Edificio(string nombre, string direccion,  CasaHabitacion casaHabitacion)
        //{
        //    this.nombre = nombre;
        //    this.direccion = direccion;
        //    this.casaHabitacion = casaHabitacion;
        //}

        //public Edificio(string nombre, string direccion, Oficina oficina)
        //{
        //    this.nombre = nombre;
        //    this.direccion = direccion;
        //    this.oficina = oficina;
        //}


        public string Nombre
        {
            get { return nombre; }
        }
        public string Direccion
        {
            get { return direccion; }
        }
        public List<Apartamento> Apartamentos
        {
            get { return apartamentos; }
            set { apartamentos = value; }
        }
        public Apartamento BuscarApartamento(int piso, string numero)
        {
            bool existe = false;
            Apartamento c = null;
            int i = 0;
            while (i < apartamentos.Count && !existe)
            {
                if (apartamentos[i].Piso == piso && apartamentos[i].Numero == numero)
                {
                    existe = true;
                    c = apartamentos[i];
                }
                i++;
            }
            return c;
        }

        public bool devolverMetrajes(int menorMetraje, int mayorMetraje, string orientacion)
        {
            bool esta = false;
            int cont= 0;
            while (cont < apartamentos.Count && !esta)
            {
                Apartamento apto = apartamentos[cont];
                if (apto.Metraje >= menorMetraje && apto.Metraje <= mayorMetraje && apto.Orientacion == orientacion)
                {
                    esta = true;
                }
                cont++;
            }
            return esta;
        }
    }
}
