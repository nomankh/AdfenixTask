using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Noman
{
    [Database]
   public class Franchisee : Address
    {
        public string Name;
        public MainFranchiser FranchiserMain;

        
        

        public QueryResultRows<Houses> Houses
        {
            get {
                return Db.SQL<Houses>("SELECT h FROM Noman.Houses h WHERE h.CaretakerCompany = ?", this);
            }
        }

        /*
         We create these values to avoid the server call whenever company data is modified server calculate
         these values for us to do small tasks like charts and stuff
        */
        public long TotalSales => Db.SQL<long>("SELECT SUM(h.SalePrice) FROM Noman.Houses h WHERE h.CaretakerCompany = ?", this).First;
        public long TotalCommisions => Db.SQL<long>("SELECT SUM(h.Commision) FROM Noman.Houses h WHERE h.CaretakerCompany = ?", this).First;
        public long TotalHouses => Db.SQL<long>("SELECT COUNT(h) FROM Noman.Houses h WHERE h.CaretakerCompany = ?", this).First;
        public long AverageCommision => TotalCommisions / (Houses.Count() > 0 ? Houses.Count() : 1);
    }
}
