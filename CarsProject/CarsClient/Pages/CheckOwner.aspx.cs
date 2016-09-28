using CarsClient.Logic;
using CarsClient.WindowsService;
using CarsService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsClient
{
    public partial class About : Page
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {
                
                
                OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(DropDownListOwnerToCheck, Connector);
                OwnerDisplayer.DisplayAllOwnersInDropDownList();

                CarsFromSelectedOwnerDataList CarList = new CarsFromSelectedOwnerDataList(DataListCarsFromSelectedOwner, Connector, DropDownListOwnerToCheck.SelectedValue);
                CarList.DisplayCarsFromSelectedOwnerDataList();
                 

            }
            }

        protected void CheckCars(object sender, EventArgs e)
        {
            CarsFromSelectedOwnerDataList CarList = new CarsFromSelectedOwnerDataList(DataListCarsFromSelectedOwner, Connector, DropDownListOwnerToCheck.SelectedValue);
            CarList.DisplayCarsFromSelectedOwnerDataList();


        }

       
    }
    }
