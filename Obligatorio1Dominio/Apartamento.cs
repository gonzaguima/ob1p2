namespace Obligatorio1Dominio
{
    public class Apartamento
    {
        private int piso;
        private string numero;
        private int metraje;
        private static int precioBase = 150000;
        private string orientacion;
        public int Piso
        {
            get { return piso; }
            //set { piso = value; }
        }

        public string Numero
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
        internal void ModificarDatos(int piso, string numero, int metraje, string orientacion)
        {
            this.piso = piso;
            this.numero = numero;
            this.metraje = metraje;
            this.orientacion = orientacion;
        }
    }
}
