﻿using System;
using System.Collections.Generic;

namespace Miguel.Servicio.DataBase
{
    public partial class DetalleIngreso
    {
        public int IddetalleIngreso { get; set; }
        public int Idingreso { get; set; }
        public int Idarticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual Articulo IdarticuloNavigation { get; set; }
        public virtual Ingreso IdingresoNavigation { get; set; }
    }
}
