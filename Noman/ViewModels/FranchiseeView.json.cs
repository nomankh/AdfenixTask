using Starcounter;
using System.Collections.Generic;

namespace Noman
{
    partial class FranchiseeView : Json,IBound<Franchisee>
    {

        public string CompleteAddress => House_No + " " + Street + " " + City + " " + ZipCode + " " + State + " " + Country;
        public string url => "/Noman/franchise/" + this.Data.GetObjectID();
         


        
        /* Event Handlers */
        void Handle(Input.SaveCurrentFranchiseeInfo action)
        {
            Transaction.Commit(); // saves current  Franchisee Details for which save is pressed
        }

        // Create new house of model type and calls its respective viewmodel  function to create a viewmodel house
        void Handle(Input.CreateNewHouse action)
        {

            var newHouse = new Houses()
            {
                CaretakerCompany = (Franchisee)Data
            };

            AddNewHouse(newHouse);
        }

        /*View Manipulation Methods*/


            // creating viewmodel house from model Houses data
        public void AddNewHouse(Houses newhouse)
        {


            var houseJson = new HousesView() { Data = newhouse };   
            Houses.Add(houseJson);
        }

        /* refreshes the houses in a franchise this method is called while creating the Franchise view mmodel */
        public void RefreshCompanyHouses(IEnumerable<Houses> houses)
        {
            Houses.Clear();
            foreach (Houses house in houses)
            {
                AddNewHouse(house);
            }
        }
    }
}
