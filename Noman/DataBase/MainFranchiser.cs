using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;


namespace Noman
{
    [Database]
  public  class MainFranchiser
    {

        public string Name;


        //This will not be stored on database but it would tell us all the franchises in a single Franchiser 
        public QueryResultRows<Franchisee> Companies => Db.SQL<Franchisee>("SELECT f FROM Noman.Franchisee f WHERE f.FranchiserMain = ?", this);

        public long TotalFranchises => Db.SQL<long>("SELECT COUNT(f) FROM Noman.Franchisee f WHERE f.FranchiserMain = ?", this).First;

    }
}
