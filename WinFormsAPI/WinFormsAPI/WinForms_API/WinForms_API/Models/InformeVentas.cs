using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms_API.Models
{
    public class InformeVentas
    {
        public float total_vendido { get; set; }
        public int numero_ventas { get; set; }
        public string producto_mas_vendido { get; set; }
    }
}
