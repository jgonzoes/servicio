using System;
using System.Collections.Generic;

namespace Miguel.Servicio.DataBase
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? Precio { get; set; }
    }
}
