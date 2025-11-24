using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{
    internal class Connection
    {
        public static string GetConnectionString() 
        { 
            return "server=saborido.database.windows.net;database=PersonaDB;uid=roman;pwd=Vivaerbeti1234;trustServerCertificate = true;";
        }
    }
}
