using System;
using System.Configuration;

namespace Magma3
{
    public static class Helper
    {
        public static string ConnValue(string name)
        {
            return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
