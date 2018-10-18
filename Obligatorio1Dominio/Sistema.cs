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


        private Oficina AltaApartamento(int puestosTrabajo, bool equipamiento, int piso, string numero, int metraje, string orientacion)
        {
            Oficina oficina = new Oficina(puestosTrabajo, equipamiento, piso,  numero,  metraje,  orientacion);
            
            return oficina;
        }
        
        private CasaHabitacion AltaApartamento(int dormitorio, int banios, bool garaje, int piso, string numero, int metraje, string orientacion)
        {
            CasaHabitacion casa = new CasaHabitacion(dormitorio, banios, garaje, piso, numero, metraje, orientacion);
            return casa;
        }


     

        ////******metodo alta edificio ******
        //public string AltaEdificio(string nombre, string direccion, int piso, string numero, int metraje, string orientacion, bool esOficina, int dormitorio, int banios, bool garaje, bool equipamiento, int puestosTrabajo)
        //{
        //    string mensaje = ""; //retorno error
        //    if (nombre != "" && direccion != "")//Primer paso verificar que no sea vacio.
        //    {
        //        if (BuscarEdificio(nombre) == null)//Segundo paso verificar que no existe.
        //        {
        //            if (piso > -1 && metraje > 0 && orientacion != "")
        //            { //Verifico solo si es valido. Estoy seguro que el apto no existe porque es el primero que se crea.
        //                Edificio n;
        //                if (esOficina)
        //                {
        //                    n = new Edificio(nombre, direccion, new Oficina(puestosTrabajo, equipamiento, piso, numero, metraje, orientacion));
        //                }else{
        //                    n = new Edificio(nombre, direccion, new CasaHabitacion(dormitorio, banios, garaje, piso, numero, metraje, orientacion));
        //                }
        //                edificios.Add(n); //se agrega el apartamento al edificio
        //                mensaje = "Alta exitosa!";
        //            }
        //        } else { mensaje = "El edificio ya existe"; }
        //    } else { mensaje = "Los valores son vacios."; }
        //    return mensaje;
        //}


        //***************metodo alta Edificio con CasaHabitacion**********************

        
         public Edificio AltaEdificio(string nombreEdificio, string direccionEdificio, int piso, string numero, int metraje, string orientacion, int dormitorio, int banios, bool garaje)
        {
            List<Apartamento> apartamentos = new List<Apartamento>();
            Edificio edificio = null;
            
            edificio = BuscarEdificio(nombreEdificio);

            if (edificio == null)
            {
                edificio = new Edificio(nombreEdificio, direccionEdificio, apartamentos);

                CasaHabitacion aptoCasa = AltaApartamento(dormitorio, banios, garaje, piso, numero, metraje, orientacion);

                if (!buscarApto(numero))
                {
                    edificio.Apartamentos.Add(aptoCasa);

                    if (BuscarEdificio(nombreEdificio) == null)
                    {
                        edificios.Add(edificio);
                    }
                }
               
            }

            return edificio;

        }

        //**********************metodo alta Edificio con Oficina***************************
        public Edificio AltaEdificio(string nombreEdificio, string direccionEdificio, int piso, string numero, int metraje, string orientacion, int puestosTrabajo, bool equipamiento)
        
        {
            List<Apartamento> apartamentos = new List<Apartamento>();
            Edificio edificio = null;

            edificio = BuscarEdificio(nombreEdificio);

            if (edificio == null)
            {
                edificio = new Edificio(nombreEdificio, direccionEdificio, apartamentos);

                Oficina aptoOficina = AltaApartamento(puestosTrabajo, equipamiento, piso, numero, metraje, orientacion);

                if (!buscarApto(numero))
                {
                    edificio.Apartamentos.Add(aptoOficina);

                    if (BuscarEdificio(nombreEdificio) == null)
                    {
                        edificios.Add(edificio);
                    }
                }

            }

            return edificio;

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

        //****************** metodo buscar apto *****************

        public bool buscarApto(string numero)
        {
            bool existe = false;
            int i = 0;

            while (existe == false && i < edificios.Count)
            {
                int j = 0;

                while (existe == false && j < edificios[i].Apartamentos.Count)
                {
                    if (edificios[i].Apartamentos[j].Numero == numero)
                    {
                        existe = true;
                    }
                    j++;
                }
                i++;
            }

            return existe;
        }



        //*************metodo listado apartamentos por precio***********
        public List<Apartamento> ListadoAptoPrecio(int menor, int mayor)
        {
            List<Apartamento> rango = new List<Apartamento>();
            foreach (Edificio e in edificios)
            {
                foreach (Apartamento a in e.Apartamentos)
                {
                    if (a.PrecioBase >= menor && a.PrecioBase <= mayor)
                    {
                        rango.Add(a);
                    }
                }
            }
            return rango;
        }

        //*********************** existencia de apto segun rango de metrajes ****************************

        public bool HayApto(int menor, int mayor)
        {
            bool existe = false;
            int i = 0;

            while (existe == false && i < edificios.Count)
            {
                int j = 0;

                while (existe == false && j < edificios[i].Apartamentos.Count)
                {
                    if (edificios[i].Apartamentos[j].Metraje >= menor && edificios[i].Apartamentos[j].Metraje <= mayor)
                    {
                        existe = true;
                    }
                    j++;
                }
                i++;
            }

            return existe;
        }


        //************************ listado edificios por rango de metrajes *********************************
        public List<Edificio> ListadoEdificios(int menorMetraje, int mayorMetraje, string orientacion)
        {
            List<Edificio> listadoEdificios = new List<Edificio>();

            foreach (Edificio e in edificios)
            {
                if (menorMetraje != 0 && mayorMetraje != 0)
                    foreach (Apartamento a in e.Apartamentos)
                    {
                        if (a.Metraje >= menorMetraje && a.Metraje <= mayorMetraje && a.Orientacion == orientacion)
                        {
                            Edificio encontrado = new Edificio(e.Nombre, e.Direccion, e.Apartamentos);
                            listadoEdificios.Add(encontrado);
                        }
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

        //***Metodo muestra de aptos******
        public List<Apartamento> CargaAptos()
        {
            List<Apartamento> aptos = new List<Apartamento>();
            foreach (Edificio e in edificios)
            {
                foreach (Apartamento a in e.Apartamentos)
                {
                    aptos.Add(a);
                }
            }
            return aptos;
        }

        //************* DATOS DE PRUEBA ******************
        public void CargarDatos()
        {
            //this.AltaEdificio("Nostrum", "AvUruguay", 2, "201", 70, "SO", true, 2, 2, true, true, 0);
            //this.AltaEdificio("Altos", "CiudadVieja", 1, "103", 20, "N", true, 2, 2, true, true, 0);
            //this.AltaEdificio("BPS", "ArenalGrande", 3, "301", 200, "SO", true, 2, 2, true, true, 0);
            //this.AltaEdificio("HBC", "AvRivera", 2, "201", 125, "SO", true, 2, 2, true, true, 0);
            //this.AltaEdificio("TrumpTower", "PdeE", 2, "202", 162, "S", true, 2, 2, true, true, 0);
            //this.AltaEdificio("TorreProfesionales", "Yaguaron", 45, "203", 12, "E", true, 2, 2, true, true, 0);

            //new Oficina(2, true, 2, "2S",100, "S");
            
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
