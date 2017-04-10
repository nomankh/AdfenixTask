using Starcounter;
using System.Collections.Generic;

namespace Noman
{
    partial class FranchiserView : Json,IBound<MainFranchiser>
    {
       

        /* Event Action Methods */

        void Handle(Input.SaveFranchiseAgencyInfo action)
        {

            //Saves current Franchiser data/edited Fields
            Transaction.Commit();

        }


        //Create New Franchisee and initialise the data
        void Handle(Input.CreateNewFranchiseeCompany action)
        {
            var newFranchise = new Franchisee()
            {
                FranchiserMain = this.Data

            };

            AddNewFranchiseeCompany(newFranchise);

        }


        /* Utility View Manipulation Methods*/


            // Refresh Needs to be called as nested Query Resulted rows are not copied to the parent array 
        public void RefreshCompanies(IEnumerable<Franchisee> companies)
        {
           
            this.Companies.Clear();
            foreach (Franchisee comp in companies)
            {
                AddNewFranchiseeCompany(comp);


            }
        }


        //Creates new viewmodel for the Franchisee Company
        public void AddNewFranchiseeCompany(Franchisee newcompany)
        {

            var franchiseeJson = new FranchiseeView() { Data = newcompany };
         
            if (newcompany.TotalHouses > 0)
            {
                franchiseeJson.RefreshCompanyHouses(newcompany.Houses);
            }
            this.Companies.Add(franchiseeJson);
            AddChartItem(newcompany);
        }



        /*   graph renderin calculations */

        private void AddChartItem(Franchisee company)
        {

            // Adds Data to Averge Commision Chart

            var row = this.AverageCommisionValues.Add();
            row.Add().StringValue = company.Name;
            row.Add().IntegerValue = company.AverageCommision;

            // Adds Data to Total Commision Chart
            var totalCommisions = this.TotalCommisionValues.Add();
            totalCommisions.Add().StringValue = company.Name;
            totalCommisions.Add().IntegerValue = company.TotalCommisions;

            // Adds Data to House sold Chart
            var totalHouses = this.HouseSoldValues.Add();
            totalHouses.Add().StringValue = company.Name;
            totalHouses.Add().IntegerValue = company.TotalHouses;

            // Adds Data to Company Trends Chart

            /*
                 * Basically Trend tell us that this particular franchisee is suitable
                  to work with or not depending on the commision they are getting, 
                  closer to 0 and they are not good to do business with but we should also keep 
                  an eye on rest of the charts, it may be the case that its taking about 90%
                  but still its giving less business than rest
                  */


            //Calculating company Trend on the bases of tot
            float trend =  (company.TotalCommisions * 100) / (company.TotalSales > 0 ? company.TotalSales : 1);
          var   companyTrend = this.CompanyTrendValues.Add();
            companyTrend.Add().StringValue = company.Name;
            companyTrend.Add().DoubleValue = trend;

            




        }

    }
}
