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

        public int IdArticulo { get; set; }

        public string ImagenURl { get; set; }

        public override string ToString()
        {
            return ImagenURl;
        }

    }
}
