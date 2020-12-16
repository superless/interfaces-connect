using System.Security.Claims;
using System.Threading.Tasks;

namespace trifenix.connect.interfaces.auth
{
    /// <summary>
    /// interface de autenticación
    /// retorna objeto con datos de autenticación
    /// </summary>
    public interface IAuthentication
    {
        /// <summary>
        /// valida un usuario con un token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns>objeto con información del usuario validado</returns>
        Task<ClaimsPrincipal> ValidateAccessToken(string accessToken);
    }
}
