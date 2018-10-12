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
                    while (!CallAltaApartamento(nombre)) //Crear nuevo apto
                    {
                        //Queda encerrado hasta que se ingrese un apto valido.
                    } //DUDA no se si esta bien esto.
                }else { mensaje = "El edificio ya existe"; }
            }else { mensaje = "Los valores son vacios."; }
            return mensaje;
        }

        private object BuscarEdificio(string nombre)
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

        private bool CallAltaApartamento(string nombre)
        {
            bool c = false;
            //Abrir AltaApartamento.aspx 
            //Con el edificio ya agregado al form
            return c;
        }

        public string AltaApartamento(string piso, int numero, int metraje, int precioBase, string orientacion, Edificio edificio)
        {
            return edificio.AltaApartamento(piso, numero, metraje, precioBase, orientacion);
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
        private Sistema() {}
    }
}
