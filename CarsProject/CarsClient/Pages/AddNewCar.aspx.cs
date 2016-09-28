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
    public partial class Contact : Page
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Connector = new WCFConnector();
            if (!IsPostBack)
            {
                OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(DropDownListOwnerToSelect, Connector);
                OwnerDisplayer.DisplayAllOwnersInDropDownList();
                info.Text = "";
            }

            
        }

        protected void AddCar_Click(object sender, EventArgs e)
        {
            CarDTO Car = new CarDTO();
            Car.Brand = carBrand.Value;
            Car.Model = carModel.Value;
            Car.KM =Convert.ToInt16(carKM.Value);
            Connector.AddCarToOwner(Car, Convert.ToInt16(DropDownListOwnerToSelect.SelectedValue));

            carBrand.Value="";
            carModel.Value = "";
            carKM.Value = "";

            info.Text = "You added new car";
        }
    }
}