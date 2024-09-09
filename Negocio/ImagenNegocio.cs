using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select id, IdArticulo, ImagenUrl from IMAGENES");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Id = (int)datos.Lector["id"];
                    imagen.IdArticulo = (int)datos.Lector["IdArticulo"];
                    imagen.ImagenURl = (string)datos.Lector["ImagenUrl"];
                    lista.Add(imagen);
                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
    }
}
