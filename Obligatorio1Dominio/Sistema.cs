using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
    public class Sistema
    {   /*listados*/
        List<Cliente> clientes = new List<Cliente>();
        List<Edificio> edificios = new List<Edificio>();
        //instancia
        private static Sistema instancia;

        public List<Cliente> Clientes
        {
            get { return clientes; }
        }
        public List<Edificio> Edificios
        {
            get { return edificios; }
        }

        //******metodo alta edificio ******
        public string AltaEdificio(string nombre, string direccion, int piso, string numero, int metraje, string orientacion, bool esOficina, int dormitorio, int banios, bool garaje, bool equipamiento, int puestosTrabajo)
        {
            string mensaje = ""; //retorno error
            if (nombre != "" && direccion != "")//Primer paso verificar que no sea vacio.
            {
                if (BuscarEdificio(nombre) == null)//Segundo paso verificar que no existe.
                {
                    if (piso > -1 && metraje > 0 && orientacion != "")
                    { //Verifico solo si es valido. Estoy seguro que el apto no existe porque es el primero que se crea.
                        Edificio n;
                        if (esOficina)
                        {
                            n = new Edificio(nombre, direccion, new Oficina(puestosTrabajo, equipamiento, piso, numero, metraje, orientacion));
                        }else{
                            n = new Edificio(nombre, direccion, new CasaHabitacion(dormitorio, banios, garaje, piso, numero, metraje, orientacion));
                        }
                        edificios.Add(n); //se agrega el apartamento al edificio
                        mensaje = "Alta exitosa!";
                    }
                } else { mensaje = "El edificio ya existe"; }
            } else { mensaje = "Los valores son vacios."; }
            return mensaje;
        }

        //*********** metodo buscar edificio *************
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

        //********** metodo listado edificios por metraje *********
        public List<Edificio> ListadoEdificios(int menorMetraje, int mayorMetraje, string orientacion)
        {
            List<Edificio> listadoEdificios = new List<Edificio>();
            foreach (Edificio e in edificios)
            {
                if (e.devolverMetrajes(menorMetraje, mayorMetraje, orientacion))
                {
                    listadoEdificios.Add(e);
                }
            }
            return listadoEdificios;
        }

        //*********** metodo alta apartamento ******************
        public string AltaApartamento(int piso, string numero, int metraje, string orientacion, string edificio, bool esOficina, int dormitorio, int banios, bool garaje, bool equipamiento, int puestosTrabajo)
        {
            string mensaje = "";
            Edificio e = BuscarEdificio(edificio);
            if (e != null)
            {
                if (esOficina)
                {
                    e.Apartamentos.Add(new Oficina(puestosTrabajo, equipamiento, piso, numero, metraje, orientacion));
                }
                else
                {
                    e.Apartamentos.Add(new CasaHabitacion(dormitorio, banios, garaje, piso, numero, metraje, orientacion));
                }
            }else { mensaje = "El edificio no existe."; }
            return mensaje;
        }

        //************* DATOS DE PRUEBA ******************
        public void CargarDatos()
        {
            this.AltaEdificio("Nostrum", "AvUruguay", 2, "201", 20, "SO", true, 2, 2, true, true, 0);
            this.AltaEdificio("Altos", "CiudadVieja", 1, "103", 20, "N", true, 2, 2, true, true, 0);
            this.AltaEdificio("BPS", "ArenalGrande", 3, "301", 20, "SO", true, 2, 2, true, true, 0);
            this.AltaEdificio("HBC", "AvRivera", 2, "201", 12, "SO", true, 2, 2, true, true, 0);
            this.AltaEdificio("TrumpTower", "PdeE", 2, "202", 12, "S", true, 2, 2, true, true, 0);
            this.AltaEdificio("TorreProfesionales", "Yaguaron", 2, "203", 12, "E", true, 2, 2, true, true, 0);

            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Nostrum");
            //this.AltaApartamento(, "Altos");
            //this.AltaApartamento(, "Altos");
            //this.AltaApartamento(, "Altos");
        }

        //***************** singleton ****************
        public static Sistema Instancia 
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
