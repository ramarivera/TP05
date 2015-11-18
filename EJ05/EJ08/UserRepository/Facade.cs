using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EJ08.UserRepository
{
    class Facade
    {

        private IRepositorioUsuarios iRepositorio;

        const string COMPARERS_NAMESPACE = "EJ08.UserRepository.Comparers";

        public Facade ()
        {
            this.iRepositorio = new RepositorioUsuarios();
            Usuario lUsuario1 = new Usuario { Codigo = "AAAA", NombreCompleto = "Martin Arrúa", CorreoElectronico = "Martin94.profugo@hotmail.com" };
            Usuario lUsuario2 = new Usuario { Codigo = "MMMM", NombreCompleto = "Ramiro Rivera", CorreoElectronico = "Ramarivera@gmail.com" };
            Usuario lUsuario3 = new Usuario { Codigo = "ZZZZ", NombreCompleto = "Agustina Mannise", CorreoElectronico = "Agusmn95@gmail.com" };

            iRepositorio.Agregar(lUsuario3);
            iRepositorio.Agregar(lUsuario1);
            iRepositorio.Agregar(lUsuario2);
        }

        /// <summary>
        /// Agrega un <see cref="Usuario"/> al Repositorio
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            this.iRepositorio.Agregar(pUsuario);
        }

        /// <summary>
        /// Actualiza la informacion de un <see cref="Usuario"/> 
        /// </summary>
        /// <param name="pUsuario">Usuario a actualizar</param>
        public void Actualizar(Usuario pUsuario)
        {
            this.iRepositorio.Actualizar(pUsuario);
        }

        /// <summary>
        /// Elimina un <see cref="Usuario"/>
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario a Eliminar</param>
        public void Eliminar(string pCodigo)
        {
            this.iRepositorio.Eliminar(pCodigo);
        }

        /// <summary>
        /// Obtiene todos las instancias de <see cref="Usuario"/> contenidas en el repositorio
        /// </summary>
        /// <returns>Lista de todos los usuarios</returns>
        public IList<Usuario> ObtenerTodos()
        {
            return this.iRepositorio.ObtenerTodos();
        }

        /// <summary>
        /// Permite obtener la instancia de <see cref="Usuario"/> cuyo codigo es igual a <paramref name="pCodigo"/>
        /// </summary>
        /// <param name="pCodigo">Codigo del usuario que se desea obtener</param>
        /// <returns>null  si no se encontro el usuario, el usuario en caso contrario</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return this.iRepositorio.ObtenerPorCodigo(pCodigo);
        }

        /// <summary>
        /// Obtiene ordenadas las instancias de <see cref="Usuario"/> contenidas en el repositorio
        /// </summary>
        /// <param name="pComparador">Implementador de <see cref="IComparer{Usuario}"/>, el cual define el criterio del ordenamiento</param>
        /// <returns>Lista de todos los usuarios ordenados</returns>
        public IList<Usuario> ObtenerOrdenadosPor(string pNombreComparador)
        {
            IComparer<Usuario> lComparador = (IComparer<Usuario>)Activator.
                CreateInstance(Type.GetType(COMPARERS_NAMESPACE + pNombreComparador));

            return this.iRepositorio.ObtenerOrdenadosPor(lComparador);
        }

        /// <summary>
        /// Obtiene las instancias de <see cref="Usuario"/> cuyos nombres tienen mayor similitud con la cadena ingresada
        /// </summary>
        /// <param name="pBusqueda">Cadena con la que se busca similitud</param>
        /// <returns>Lista de <see cref="Usuario"/> cuyos nombres tienen mayor similitud con la cadena ingresada</returns>
        public List<Usuario> BusquedaPorAproximacion(string pBusqueda)
        {
            return this.iRepositorio.BusquedaPorAproximacion(pBusqueda);
        }

        public IList<String> ObtenerNombresComparadores()
        {
            IList<String> lResultado = new List<String>();

            IEnumerable<Type> listaClases = from tipo in Assembly.GetExecutingAssembly().GetTypes()
                                            where tipo.IsClass && tipo.Namespace == @COMPARERS_NAMESPACE
                                            select tipo;

            listaClases.ToList().ForEach(t => lResultado.Add(t.Name));

            return lResultado;
        }
    }
}
