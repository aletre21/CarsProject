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
    public partial class EditTheCar : System.Web.UI.Page
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {

                CarDisplayerDropDownList CarDisplayer = new CarDisplayerDropDownList(CarToEditDropDownList, Connector);
                CarDisplayer.DisplayAllCarsInDropDownList();

                EditableCarDisplayerDataList EditableCarDisplayer = new EditableCarDisplayerDataList(CarToEditDataList, Connector, CarToEditDropDownList.SelectedValue);
                EditableCarDisplayer.DisplayCarInEditableDataList();

                carsavedInfo.Text = "";

                OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(OwnerToChangeDropDownList, Connector);
                OwnerDisplayer.DisplayAllOwnersInDropDownList();

                EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList((DataList)OwnerDL.FindControl("OwnerDataList"), Connector, OwnerToChangeDropDownList.SelectedValue);
                EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

            }
        }
      

        protected void OwnerIsChanged_SelectedIndexChanged(object sender, EventArgs e)
        {

            EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList((DataList)OwnerDL.FindControl("OwnerDataList"), Connector, OwnerToChangeDropDownList.SelectedValue);
            EditableOwnerDisplayer.DisplayOwnerInEditableDataList();
        }

        protected void SaveCar_Click(object sender, EventArgs e)
        {
            CarDTO Car = new CarDTO();

            foreach (DataListItem item in CarToEditDataList.Items)
            {
                TextBox TextBoxBrand = (TextBox)item.FindControl("carToEditBrand");
                Car.Brand = TextBoxBrand.Text;
                TextBox TextBoxModel = (TextBox)item.FindControl("carToEditModel");
                Car.Model = TextBoxModel.Text;
                TextBox TextBoxKM = (TextBox)item.FindControl("carToEditKM");
                Car.KM =Convert.ToInt16(TextBoxKM.Text);
                Label TextBoxCarId= (Label)item.FindControl("carToEditID");
                Car.Id = Convert.ToInt16(TextBoxCarId.Text);

            }

            Connector.EditTheCar(Car.Id, Car, Convert.ToInt16(OwnerToChangeDropDownList.SelectedValue));
            carsavedInfo.Text = "Changes have been saved";

            EditableCarDisplayerDataList EditableCarDisplayer = new EditableCarDisplayerDataList(CarToEditDataList, Connector, CarToEditDropDownList.SelectedValue);
            EditableCarDisplayer.DisplayCarInEditableDataList();
        }

        protected void CarIsChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditableCarDisplayerDataList EditableCarDisplayer = new EditableCarDisplayerDataList(CarToEditDataList, Connector, CarToEditDropDownList.SelectedValue);
            EditableCarDisplayer.DisplayCarInEditableDataList();

            carsavedInfo.Text = "";
        }
    }
}