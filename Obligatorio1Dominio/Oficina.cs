using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
    public class Oficina:Apartamento
    {
        private int puestosTrabajo;
        private bool equipamiento;

        public Oficina(int puestosTrabajo, bool equipamiento, int piso, string numero, int metraje, string orientacion) : base(piso, numero, metraje, orientacion)
        {
            this.puestosTrabajo = puestosTrabajo;
            this.equipamiento = equipamiento;
        }
        public int PuestosTrabajo
        {
            get { return puestosTrabajo; }
            //set { puestosTrabajo = value; }
        }

        public bool Equipamiento
        {
            get { return equipamiento; }
            //set { equipamiento = value; }
        }
    }
}
