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
        }
        internal void ModificarDatos(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
