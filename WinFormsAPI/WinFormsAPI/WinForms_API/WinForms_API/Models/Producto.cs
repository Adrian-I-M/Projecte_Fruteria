using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms_API.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public float precioKg { get; set; }
        public float stockKg { get; set; }
    }
}