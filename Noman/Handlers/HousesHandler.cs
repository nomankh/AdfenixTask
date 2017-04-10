using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;


namespace Noman
{
    class HousesHandler
    {

        public static void Register()
        {

            // Request Handler for a single house

            Handle.GET("/Noman/partial/house/{?}", (string id) =>
            {
                var json = new HousesView();
                json.Data = (Houses)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });

            Handle.GET("/Noman/house/{?}", (string id) =>
            {

                return Db.Scope(() =>
                {
                    var json = new SingleHouseView();

                    Houses house = (Houses)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                    json.Data = house;

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    if (Session.Current.Data is HousesView)
                    {
                        return Session.Current.Data;
                    }
                   

                    json.Session = Session.Current;

                    return json;
                });
            });


        }
    }
}
