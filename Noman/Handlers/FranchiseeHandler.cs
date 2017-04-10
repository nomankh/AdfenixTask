using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Noman
{
    class FranchiseeHandler
    {

        public static void Register()
        {

            // creating Request handler for the Franchise company 

            Handle.GET("/Noman/partial/franchisee/{?}", (string id) =>
            {
                var json = new FranchiseeView();

                json.Data = (Franchisee)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                return json;
            });

            Handle.GET("/Noman/franchise/{?}", (string id) =>
            {
                if (string.Empty == id)
                {
                    return Self.GET("/Noman");
                }
                return Db.Scope(() =>
                {
                    var json = new SingleFranchiseeView();

                    Franchisee franchisee = (Franchisee)DbHelper.FromID(DbHelper.Base64DecodeObjectID(id));
                    json.Data = franchisee;

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    if (Session.Current.Data is FranchiseeView)
                    {
                        return Session.Current.Data;
                    }
                    if (franchisee.TotalHouses > 0)
                    {
                        json.RefreshCompanyHouses(franchisee.Houses);
                    }

                    json.Session = Session.Current;

                    return json;
                });
            });
        }
    }
}
