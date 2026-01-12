using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ConnectionResources
{
    internal class Connection
    {
        public static string GetConnectionString()
        {
            return "server=saborido.database.windows.net;database=PersonaDB;uid=roman;pwd=Vivaerbeti1234;trustServerCertificate = true;";
        }
    }
}
