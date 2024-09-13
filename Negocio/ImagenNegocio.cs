using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        private List<Imagen> listaImg;
        public List<Imagen> Listar()
        {
            listaImg = new List<Imagen>();
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

                    listaImg.Add(aux);
                    
                }
                return listaImg;
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

        public void Agregar(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo,ImagenUrl) VALUES (@IdArticulo,@UrlImagen)");
                datos.SetearParametro("@IdArticulo", img.Articulo.Id);
                datos.SetearParametro("@UrlImagen", img.UrlImagen);
                datos.EjecutarAccion();
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

        public void Modificar(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE IMAGENES SET IdArticulo = @IdArticulo, ImagenUrl = @UrlImagen WHERE Id = @Id");
                datos.SetearParametro("@IdArticulo", img.Articulo.Id);
                datos.SetearParametro("@UrlImagen", img.UrlImagen);
                datos.SetearParametro("@Id", img.Id);
                datos.EjecutarAccion();
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

        public List<Imagen> BuscarImagenes(int idArticulo)
        {
            listaImg = Listar();
            List<Imagen> listaXArticulo = new List<Imagen>();

            foreach (Imagen img in listaImg)
            {
                if (img.Articulo.Id == idArticulo)
                {
                    listaXArticulo.Add(img);
                }
            }

            if(listaXArticulo.Count == 0)
            {
                return null;
            }
            else
            {
                return listaXArticulo;
            }
            
        }

        public Imagen BuscarImagen(int idArticulo, int index)
        {
            listaImg = Listar();
            List<Imagen> listaXArticulo = new List<Imagen>();
            Imagen imagen = new Imagen();

            foreach (Imagen img in listaImg)
            {
                if (img.Articulo.Id == idArticulo)
                {
                    listaXArticulo.Add(img);
                }
            }

            if (listaXArticulo.Count == 0)
            {
                return null;
            }
            else
            {
                imagen = listaXArticulo[index];
                return imagen;
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

        public void Eliminar(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                datos.SetearParametro("@Id", img.Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
