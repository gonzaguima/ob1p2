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

        public string AltaEdificio(string nombre, string direccion)
        {
            string mensaje = ""; //Retornar algo para mensaje de error!
            if (nombre != "" && direccion != "")//Primer paso verificar que no sea vacio.
            {
                if (BuscarEdificio(nombre) == null)//Segundo paso verificar que no existe.
                {
                    Edificio n = new Edificio(); //Paso iniciar el objeto.
                    edificios.Add(n);
                    n.ModificarDatos(nombre, direccion);
                    //while (!CallAltaApartamento(nombre)) //Crear nuevo apto
                    //{
                    //    //Queda encerrado hasta que se ingrese un apto valido.
                    //} //DUDA no se si esta bien esto.
                }else { mensaje = "El edificio ya existe"; }
            }else { mensaje = "Los valores son vacios."; }
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
            }
            return mensaje;
        }

        public void CargarDatos()
        {
            this.AltaEdificio("Nostrum", "AvUruguay");
            this.AltaEdificio("Altos", "CiudadVieja");
            this.AltaEdificio("BPS", "ArenalGrande");
            this.AltaEdificio("HBC", "AvRivera");
            this.AltaEdificio("TrumpTower", "PdeE");
            this.AltaEdificio("TorreProfesionales", "Yaguaron");

            this.AltaApartamento(2, "201", 20, "SO", "Nostrum");
            this.AltaApartamento(1, "103", 20, "N", "Nostrum");
            this.AltaApartamento(3, "301", 20, "SO", "Nostrum");
            this.AltaApartamento(2, "201", 12, "SO", "Altos");
            this.AltaApartamento(2, "202", 12, "S", "Altos");
            this.AltaApartamento(2, "203", 12, "E", "Altos");
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
