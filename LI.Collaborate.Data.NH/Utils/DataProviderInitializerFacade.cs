using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LI.Collaborate.Data.NH.Utils
{
    public class DataProviderInitializerFacade
    {
        private static DataProviderInitializer initializer;

        static DataProviderInitializerFacade()
        {
            initializer = new DataProviderInitializer();
        }
    }
}