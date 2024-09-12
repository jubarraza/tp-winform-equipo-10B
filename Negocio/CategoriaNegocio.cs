using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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

        public void Agregar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into CATEGORIAS (Descripcion) values (@Descripcion)");
                datos.SetearParametro("@Descripcion", nueva.Descripcion);

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

        public void Modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update Categorias set Descripcion = @Descripcion where Id = @Id");
                datos.SetearParametro("@Descripcion", categoria.Descripcion);
                datos.SetearParametro("@Id", categoria.Id);

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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from CATEGORIAS where Id = @id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool validarEliminacion(int id)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();

            listaArticulos = negocioArticulo.listar();

            foreach (Articulo art in listaArticulos)
            {
                if (id == art.Categoria.Id)
                {
                    return false;
                }
            }
            return true;
        }

        public bool validarIngreso(Categoria aux)
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            CategoriaNegocio catNegocio = new CategoriaNegocio();

            listaCategoria = catNegocio.Listar();

            foreach (Categoria categoria in listaCategoria)
            {
                if (categoria.Descripcion.ToLower() == aux.Descripcion.ToLower())
                {
                    return false;
                }

            }

            return true;
        }

    }
}