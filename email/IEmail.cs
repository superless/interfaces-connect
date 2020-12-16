using System.Collections.Generic;

namespace trifenix.connect.interfaces.email
{
    /// <summary>
    /// interface encargada de envíar emails
    /// </summary>
    public interface IEmail {

        /// <summary>
        /// Envío de un email
        /// </summary>
        /// <param name="mails">Email del receptor</param>
        /// <param name="subject">Sujeto del correo</param>
        /// <param name="htmlBody">Cuerpo del corrreo</param>
        void SendEmail(List<string> mails, string subject, string htmlBody);
    }
}