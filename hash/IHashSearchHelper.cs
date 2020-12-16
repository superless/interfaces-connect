


using System;

namespace trifenix.connect.interfaces.hash
{

    /// <summary>
    /// Esta interface obliga a asignar un hash para el header, es decir lograr un hash desde el diccionario
    /// e un entitySearch, es decir cuales son los nombres de los indices.
    /// Esto permitirá saber si los índices han cambiado.
    /// También existe un hash generado por el json de un elemento de base de datos de persistencia,
    /// esto permitirá validar que el entitySearch sea un elemento de la base de datos.
    /// </summary>
    public interface IHashSearchHelper
    {
        /// <summary>
        /// Convierte un objeto en un hash
        /// esto se usa para asignar un hash a un entitySearch.
        /// De esta manera si el resultado de un hash de un elemento entitySearch
        /// es distinto al que se espera, el objeto habrá sido corrompido.
        /// </summary>
        /// <param name="obj">modelo a hashear</param>
        /// <returns>hash</returns>
        string HashModel(object obj);

        /// <summary>
        /// Obtiene un hash de las cabeceras
        /// toma las enumeraciones existentes, las convierte en un hash
        /// con esto todas las colecciones tendrán un único hash.
        /// Si llegase a modificar los índices de las cabeceras, el hash sería diferente al resto.
        /// </summary>
        /// <returns>Hash de cabeceras</returns>
        string HashHeader(Type type);
    }



    
}
