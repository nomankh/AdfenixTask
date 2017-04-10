using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Noman
{
    class FranchiserHandler
    {
        public static void Register()
        {

            // Handles the main Request when page is requested
            Handle.GET("/Noman", () =>
            {

                return Db.Scope(() => {

                    var mainFranchiser = Db.SQL<MainFranchiser>("SELECT m FROM Noman.MainFranchiser m").First;

                    var json = new FranchiserView
                    {
                        Data = mainFranchiser
                    };

                    /*
                         when assigning QueryResultRows<Houses> to viewModels the nested rows are not copied
                        so we refreshes the viewmodel data by calling the below method
                    */
                    if (mainFranchiser.TotalFranchises > 0)
                    {
                        json.RefreshCompanies(mainFranchiser.Companies);

                    }
                   

                    //checking and assigning session

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }

                    json.Session = Session.Current;

                    return json;

                });


            });


            // Make a new Franchiser if none Exists

            Db.Transact(() => {
                var anyone = Db.SQL<MainFranchiser>("Select m from Noman.MainFranchiser m").First;
                if (anyone == null)
                {


                    new MainFranchiser
                    {
                        Name = "New Realtor"

                    };


                }

            });
        }
    }
}
