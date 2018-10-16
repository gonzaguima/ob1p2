using System;
using System.Collections.Generic;

namespace Obligatorio1Dominio
{
    public class Edificio
    {
        private string nombre;
        private string direccion;
        private List<Apartamento> apartamentos = new List<Apartamento>();
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
            //set { apartamentos = value; }
        }
        internal void ModificarDatos(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string AltaApartamento(int piso, string numero, int metraje, string orientacion)
        {
            string mensaje = "";
            if (piso > -1 /*Puede ser el piso 0*/ &&  metraje > 0 &&  orientacion != "")//Primer paso verificar que no sea vacio.
            {
                if (BuscarApartamento(piso, numero) == null)//Segundo paso verificar que no existe.
                {
                    Apartamento n = new Apartamento(); //Paso iniciar el objeto.
                    apartamentos.Add(n);
                    n.ModificarDatos(piso, numero, metraje, orientacion);
                    mensaje = "Alta exitosa!";
                }
                else { mensaje = "El apartamento ya existe"; }
            }
            else { mensaje = "Los valores son vacios."; }
            return mensaje;
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

        public List<Apartamento> devolverMetrajes(int menorMetraje, int mayorMetraje, string orientacion)
        {
            List<Apartamento> listaMetrajes = new List<Apartamento>();
            foreach (Apartamento a in apartamentos)
            {
                if (a.Metraje >= menorMetraje && a.Metraje <= mayorMetraje && a.Orientacion == orientacion)
                {
                    listaMetrajes.Add(a);
                }
            }
            return listaMetrajes;
        }
    }
}
