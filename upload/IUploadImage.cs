using System.Threading.Tasks;

namespace trifenix.connect.interfaces.upload
{
    /// <summary>
    /// Interface que permite subir archivos a un repositorio
    /// </summary>
    public interface IUploadImage
    {

        /// <summary>
        /// Convierte una imagen y la guarda en el repositorio
        /// </summary>
        /// <param name="base64">imagen en base64</param>
        /// <returns></returns>
        Task<string> UploadImageBase64(string base64);

    }
}
