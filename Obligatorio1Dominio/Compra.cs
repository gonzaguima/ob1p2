﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1Dominio
{
     public class Compra
    {
        private DateTime fecha;
        private string vendedor;
        private int precio;
        private Apartamento apartamento;
        private Cliente cliente;


        public Compra(DateTime fecha, string vendedor, int precio, Apartamento apartamento, Cliente cliente)
        {
            this.fecha = fecha;
            this.vendedor = vendedor;
            this.precio = precio;
            this.apartamento = apartamento;
            this.cliente = cliente;
        }
    }
}
