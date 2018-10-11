namespace Obligatorio1Dominio
{
    public class Apartamento
    {
        private string piso;
        private int numero;
        private int metraje;
        private int precioBase;
        private string orientacion;
        public string Piso
        {
            get { return piso; }
            //set { piso = value; }
        }

        public int Numero
        {
            get { return numero; }
            //set { numero = value; }
        }

        public int Metraje
        {
            get { return metraje; }
            //set { metraje = value; }
        }

        public int PrecioBase
        {
            get { return precioBase; }
            //set { precioBase = value; }
        }

        public string Orientacion
        {
            get { return orientacion; }
            //set { orientacion = value; }
        }
        internal void ModificarDatos(string piso, int numero, int metraje, int precioBase, string orientacion)
        {
            this.piso = piso;
            this.numero = numero;
            this.metraje = metraje;
            this.precioBase = precioBase;
            this.orientacion = orientacion;
        }
    }
}
