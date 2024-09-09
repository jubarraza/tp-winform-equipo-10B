using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select AR.Id, AR.Codigo, AR.Nombre, AR.Descripcion, MA.Id as IdMarca, MA.Descripcion as Marca," +
                    " CA.Id as IdCategoria, CA.Descripcion as Categoria, AR.Precio from ARTICULOS as " +
                    "AR join MARCAS as MA on AR.IdMarca = MA.Id join CATEGORIAS as CA on AR.IdCategoria = CA.Id");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.CodArt = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)datos.Lector["IdMarca"];
                    articulo.Marca.Nombre = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Precio = (float)datos.Lector.GetDecimal(8);

                    lista.Add(articulo);    
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

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio)" +
                    "values(@cod, @nombre, @Descripcion, @IdMarca, @Idcategoria, @precio )");
                datos.SetearParametro("@cod", nuevo.CodArt);
                datos.SetearParametro("@nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@IdMarca", nuevo.Marca.Id);
                datos.SetearParametro("@Idcategoria", nuevo.Categoria.Id);
                datos.SetearParametro("@precio", nuevo.Precio);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("update ARTICULOS set Codigo = @cod,Nombre = @nombre," +
                    "Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @Idcategoria ," +
                    "Precio = @precio where Id = @id");
    
                datos.SetearParametro("@cod", articulo.CodArt);
                datos.SetearParametro("@nombre", articulo.Nombre);
                datos.SetearParametro("@Descripcion", articulo.Descripcion);
                datos.SetearParametro("@IdMarca", articulo.Marca.Id);
                datos.SetearParametro("@Idcategoria", articulo.Categoria.Id);
                datos.SetearParametro("@precio", articulo.Precio);
                datos.SetearParametro("@Id", articulo.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where Id = @id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }


}
