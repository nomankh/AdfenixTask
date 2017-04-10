using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;


namespace Noman
{
    [Database]
   public class Houses : Address
    {

        public Franchisee CaretakerCompany; // The company under which this house comes
        public string TransactionTime; 
        public int SalePrice;
        public int Commision;
        
    }
}
