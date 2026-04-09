using System;
using System.Runtime.Remoting.Contexts;

namespace ISFDyT93.Datos.Core
{
    internal static class Settings
    {
        public static string STRCONNECTION
        {
            get
            {
                string connStr = "Data Source = DESKTOP-JJFT39E\\GDBD; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = True"; ;
                if (string.IsNullOrWhiteSpace(connStr))
                    throw new InvalidOperationException(
                        "La variable de entorno INSTITUTO_DB_CONNECTION_STRING no está definida.");
                return connStr;
            }
        }
    }
}
