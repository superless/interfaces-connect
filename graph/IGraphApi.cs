using System.Threading.Tasks;


namespace trifenix.connect.interfaces.graph
{

    /// <summary>
    /// Manejo de usuarios en active directory
    /// </summary>
    public interface IGraphApi {

        /// <summary>
        /// Crea un usuario en active directory
        /// </summary>
        /// <param name="name">nombre del usuario</param>
        /// <param name="email">correo</param>
        /// <returns>token</returns>
        Task<string> CreateUserIntoActiveDirectory(string name, string email);

    }
}