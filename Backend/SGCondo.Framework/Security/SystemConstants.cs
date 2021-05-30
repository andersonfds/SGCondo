using System;

namespace SGCondo.Framework.Security
{
    public class SystemConstants
    {

        public static string DbConnection
        {
            get => Environment.GetEnvironmentVariable("SG_CONDO_DB_CONNECTION");
        }

    }
}
