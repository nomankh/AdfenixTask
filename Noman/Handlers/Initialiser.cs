using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noman
{
    class Initialiser
    {
        public static void RegisterHandlers()
        {

            // Entry Point for the app to register and create Database
            FranchiserHandler.Register();
            FranchiseeHandler.Register();
            HousesHandler.Register();
        }
    }
}
