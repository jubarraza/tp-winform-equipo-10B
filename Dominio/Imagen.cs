using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }
        public Articulo Articulo { get; set; }
        public string UrlImagen { get; set; }

    }
}
