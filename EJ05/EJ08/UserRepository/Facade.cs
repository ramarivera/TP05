using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ08.UserRepository
{
    class Facade
    {

        private IRepositorioUsuarios iRepositorio;



        /// <summary>
        /// Agrega un <see cref="Usuario"/> al Repositorio
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Actualiza la informacion de un <see cref="Usuario"/> 
        /// </summary>
        /// <param name="pUsuario">Usuario a actualizar</param>
        public void Actualizar(Usuario pUsuario)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Elimina un <see cref="Usuario"/>
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario a Eliminar</param>
        public void Eliminar(string pCodigo)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Obtiene todos las instancias de <see cref="Usuario"/> contenidas en el repositorio
        /// </summary>
        /// <returns>Lista de todos los usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Permite obtener la instancia de <see cref="Usuario"/> cuyo codigo es igual a <paramref name="pCodigo"/>
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario que se desea obtener</param>
        /// <returns>null  si no se encontro el usuario, el usuario en caso contrario</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Obtiene ordenadas las instancias de <see cref="Usuario"/> contenidas en el repositorio
        /// </summary>
        /// <param name="pComparador">Implementador de <see cref="IComparer{Usuario}"/>, el cual define el criterio del ordenamiento</param>
        /// <returns>Lista de todos los usuarios ordenados</returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene las instancias de <see cref="Usuario"/> cuyos nombres tienen mayor similitud con la cadena ingresada
        /// </summary>
        /// <param name="pBusqueda">Cadena con la que se busca similitud</param>
        /// <returns>Lista de <see cref="Usuario"/> cuyos nombres tienen mayor similitud con la cadena ingresada</returns>
        public List<Usuario> BusquedaPorAproximacion(string pBusqueda)
        {
            throw new NotImplementedException();

        }

        public IList<String> ObtenerNombresComparadores()
        {
            throw new NotImplementedException();

        }
    }
}
