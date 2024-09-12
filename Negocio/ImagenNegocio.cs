using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            try
            {
                datos.SetearConsulta("SELECT i.Id as IdImagen, i.IdArticulo as IdArticulo, ImagenUrl FROM IMAGENES i INNER JOIN ARTICULOS a ON IdArticulo = a.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["IdImagen"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    Articulo articulo = new Articulo();
                    articulo.Marca = new Marca();
                    articulo.Categoria = new Categoria();

                    articulo = negocioArticulo.BuscarArticulo((int)datos.Lector["IdArticulo"]);

                    if (articulo != null) {
                        aux.Articulo = articulo;
                    }
                    else
                    {
                        //TODO: No existe el articulo
                    }

                    lista.Add(aux);
                    
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

        public void Eliminar(int idArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.SetearParametro("@IdArticulo", idArt);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
