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
        public List<Apartamento> Apartamentos {
            get { return apartamentos; }
            set { apartamentos = value; }
        }
        internal void ModificarDatos(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        internal string AltaApartamento(string piso, int numero, int metraje, int precioBase, string orientacion)
        {
            string mensaje = "";
            if (piso != "" && numero != 0 && metraje != 0 && precioBase != 0 && orientacion != "")//Primer paso verificar que no sea vacio.
            {
                if (BuscarApartamento(piso, numero) == null)//Segundo paso verificar que no existe.
                {
                    Apartamento n = new Apartamento(); //Paso iniciar el objeto.
                    apartamentos.Add(n);
                    n.ModificarDatos(piso, numero, metraje, precioBase, orientacion);
                }
                else { mensaje = "El edificio ya existe"; }
            }
            else { mensaje = "Los valores son vacios."; }
            return mensaje;
        }

        public object BuscarApartamento(string piso, int numero)
        {
            bool existe = false;
            Apartamento c = null;
            int i = 0;
            while (i < apartamentos.Count && !existe)
            {
                if (apartamentos[i].Piso.ToUpper() == piso.ToUpper() && apartamentos[i].Numero == numero)
                {
                    existe = true;
                    c = apartamentos[i];
                }
                i++;
            }
            return c;
        }
    }
}
