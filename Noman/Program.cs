using System;
using Starcounter;

namespace Noman
{
    class Program
    {
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            /*
               Calling initialiser
               whatever you want to do please do that in this function
            */
            Initialiser.RegisterHandlers();
        }
    }
}