using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {

            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion as Nombre FROM MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

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

        public void Agregar(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@Nombre)");
                datos.SetearParametro("@Nombre", marca.Nombre);
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

        public void Modificar(Marca marca) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("UPDATE MARCAS SET Descripcion = @Nombre WHERE Id = @Id");
                datos.SetearParametro("@Nombre", marca.Nombre);
                datos.SetearParametro("@Id", marca.Id);
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
                datos.SetearConsulta("DELETE FROM MARCAS WHERE Id = @Id");
                datos.SetearParametro("@Id", id);
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

            foreach(Articulo art in listaArticulos)
            {
                if(id == art.Marca.Id)
                {
                    return false;
                }
            }
            return true;
        }

        public bool validarIngreso(Marca aux)
        {
            List<Marca> listaMarca = new List<Marca>();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            listaMarca = marcaNegocio.Listar();

            foreach (Marca marca in listaMarca)
            {
                if (marca.Nombre.ToLower() == aux.Nombre.ToLower())
                {
                    return false;
                }

            }

            return true;
        }

    }

}
