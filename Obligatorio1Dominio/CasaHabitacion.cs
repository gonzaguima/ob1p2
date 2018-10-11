using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
    class CasaHabitacion:Apartamento
    {
        private int dormitorios;
        private int banios;
        private bool garaje;

        public int Dormitorios
        {
            get { return dormitorios; }
            //set { dormitorios = value; }
        }
        public int Banios
        {
            get { return banios; }
            //set { banios = value; }
        }
        public bool Garaje
        {
            get { return garaje; }
            //set { garaje = value; }
        }
    }
}
