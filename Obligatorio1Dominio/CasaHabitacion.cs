﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
    public class CasaHabitacion:Apartamento
    {
        private int dormitorios;
        private int banios;
        private bool garaje;
        private int precioFinalCasa = 200000;

        public CasaHabitacion(int dormitorios, int banios, bool garaje, int piso, string numero, int metraje, string orientacion):base(piso, numero, metraje, orientacion)
        {
            this.dormitorios = dormitorios;
            this.banios = banios;
            this.garaje = garaje;
        }
                
        public int Dormitorios
        {
            get { return dormitorios; }
            set { dormitorios = value; }
        }
        public int Banios
        {
            get { return banios; }
            set { banios = value; }
        }
        public bool Garaje
        {
            get { return garaje; }
            set { garaje = value; }
        }

        public override string Datos()
        {
            return this.Numero;
        }

    }
}
