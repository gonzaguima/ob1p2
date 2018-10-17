namespace Obligatorio1Dominio
{
    public abstract class Apartamento
    {
        private int piso;
        private string numero;
        private int metraje;
        private static int precioBase = 150000;
        private string orientacion;

        public Apartamento(int piso, string numero, int metraje, string orientacion)
        {
            this.piso = piso;
            this.numero = numero;
            this.metraje = metraje;
            this.orientacion = orientacion;
        }

        public int Piso
        {
            get { return piso; }
        }

        public string Numero
        {
            get { return numero; }
        }

        public int Metraje
        {
            get { return metraje; }
        }

        public int PrecioBase
        {
            get { return precioBase; }
        }

        public string Orientacion
        {
            get { return orientacion; }
        }
    }
}
