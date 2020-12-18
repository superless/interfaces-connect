using System;
using System.Collections.Generic;
using System.Text;

namespace trifenix.connect.interfaces.log
{
    /// <summary>
    /// Interface simple de logs para registrar consultas realizadas por los métodos.
    /// El fin es comparar la correctitud de las consultas.
    /// </summary>
    public interface ILogSimpleQuery
    {
        /// <summary>
        /// registra internamente las consultas
        /// que se han realizado dentro de un método
        /// con fines de validación.
        /// </summary>
        Dictionary<string, List<string>> Queried { get; }
    }
}
