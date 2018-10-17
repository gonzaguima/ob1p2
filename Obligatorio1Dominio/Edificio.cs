using System;
using System.Collections.Generic;

namespace Obligatorio1Dominio
{
    public class Edificio
    {
        private string nombre;
        private string direccion;
        private List<Apartamento> apartamentos = new List<Apartamento>();

        public Edificio(string nombre, string direccion, Apartamento apartamento)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.apartamentos.Add(apartamento);
        }

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
