namespace trifenix.connect.interfaces.translate{

    /// <summary>
    /// Interface para google translate
    /// </summary>
    public interface IGoogleTranslator {
        
        /// <summary>
        /// Método destinado a traducir al español cualquier texto en inglés.
        /// </summary>
        /// <param name="textToTranslate">texto a traducir</param>
        /// <returns>Texto traducido</returns>
        string TranslateText(string textToTranslate);
    }

}