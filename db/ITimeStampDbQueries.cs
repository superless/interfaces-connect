using System.Threading.Tasks;
using trifenix.connect.model;


namespace trifenix.connect.interfaces.db
{
    /// <summary>
    /// obtiene un timestamp desde un documentDb
    /// </summary>
    public interface ITimeStampDbQueries {

        /// <summary>
        /// obtiene un timestamp desde un elemento
        /// </summary>
        /// <typeparam name="T">Elemento de la base de datos</typeparam>
        /// <returns></returns>
        Task<long[]> GetTimestamps<T>() where T: DocumentDb;
    }
}
