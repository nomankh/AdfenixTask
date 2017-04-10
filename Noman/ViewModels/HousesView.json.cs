using Starcounter;
using System;
namespace Noman
{
    partial class HousesView : Json
    {
        public string CompleteAddress => House_No + " " + Street + " " + City + " " + ZipCode + " " + State + " " + Country;
        public double latitude => Convert.ToDouble(Latitude);
        public double longitude => Convert.ToDouble(Longitude);
        public string url => "/Noman/house/" + this.Data.GetObjectID();


        /* Action Methods*/

        void Handle(Input.RegisterHouse action)
        {
            Transaction.Commit();
        }
    }
}
