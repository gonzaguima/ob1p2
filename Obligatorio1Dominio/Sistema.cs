using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
    public class Sistema
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Edificio> edificios = new List<Edificio>();
        private static Sistema instancia;

        public List<Cliente> Clientes
        {
            get { return clientes; }
        }
        public List<Edificio> Edificios
        {
            get { return edificios; }
        }

        public string AltaEdificio(string nombre, string direccion, int piso, string numero, int metraje, string orientacion)
        {
            string mensaje = ""; //Retornar algo para mensaje de error!
            if (nombre != "" && direccion != "")//Primer paso verificar que no sea vacio.
            {
                if (BuscarEdificio(nombre) == null)//Segundo paso verificar que no existe.
                {
                    if (piso > -1 && metraje > 0 && orientacion != "")
                    { //Verifico solo si es valido. Estoy seguro que el apto no existe porque es el primero que se crea.
                        Edificio n = new Edificio(); //Paso iniciar el objeto.
                        edificios.Add(n);
                        n.ModificarDatos(nombre, direccion);
                        AltaApartamento(piso, numero, metraje, orientacion, nombre);
                        mensaje = "Alta exitosa!";
                    }
                } else { mensaje = "El edificio ya existe"; }
            } else { mensaje = "Los valores son vacios."; }
            return mensaje;
        }

        //public bool ExisteEdificio(string nombre) //Este esta 2 veces con el 
        //{
        //    bool existe = false;
        //    int i = 0;
        //    while (i < edificios.Count && !existe)
        //    {
        //        if (edificios[i].Nombre.ToUpper() == nombre.ToUpper())
        //        {
        //            existe = true;
        //        }
        //        i++;
        //    }
        //    return existe;
        //}

        public Edificio BuscarEdificio(string nombre)
        {
            bool existe = false;
            Edificio c = null;
            int i = 0;
            while (i < edificios.Count && !existe)
            {
                if (edificios[i].Nombre.ToUpper() == nombre.ToUpper())
                {
                    existe = true;
                    c = edificios[i];
                }
                i++;
            }
            return c;
        }

        public List<Edificio> ListadoEdificios(int menorMetraje, int mayorMetraje, string orientacion)
        {
            List<Edificio> listadoEdificios = new List<Edificio>();
            foreach(Edificio e in edificios)
            {
                //listadoEdificios.AddRange(e.devolverMetrajes(menorMetraje, mayorMetraje, orientacion));
            }
            return listadoEdificios;
        }

        private bool CallAltaApartamento(string nombre)
        {
            bool c = false;
            //Abrir AltaApartamento.aspx 
            //Con el edificio ya agregado al form
            return c;
        }

        public string AltaApartamento(int piso, string numero, int metraje, string orientacion, string edificio)
        {
            string mensaje = "";
            Edificio e = BuscarEdificio(edificio);
            if (e != null)
            {
                mensaje = e.AltaApartamento(piso, numero, metraje, orientacion);
            }else { mensaje = "El edificio no existe."; }
            return mensaje;
        }

        public void CargarDatos()
        {
            this.AltaEdificio("Nostrum", "AvUruguay", 2, "201", 20, "SO");
            this.AltaEdificio("Altos", "CiudadVieja", 1, "103", 20, "N");
            this.AltaEdificio("BPS", "ArenalGrande", 3, "301", 20, "SO");
            this.AltaEdificio("HBC", "AvRivera", 2, "201", 12, "SO");
            this.AltaEdificio("TrumpTower", "PdeE", 2, "202", 12, "S");
            this.AltaEdificio("TorreProfesionales", "Yaguaron", 2, "203", 12, "E");

            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Altos");
            //this.AltaApartamento(, "Altos");
            //this.AltaApartamento(, "Altos");
        }
        public static Sistema Instancia //Singleton
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Sistema();
                }
                return instancia;
            }
        }
        private Sistema() { CargarDatos(); }
    }
}
