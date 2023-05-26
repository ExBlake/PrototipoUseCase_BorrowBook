using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowBook.MailServices
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            //Inicializamos los atributos de la empresa para el envio del correo.
            senderMail = "jasstechnologysas@outlook.com";
            password = "jass123456";
            host = "smtp.outlook.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
