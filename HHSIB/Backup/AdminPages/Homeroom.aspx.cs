using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB.AdminPages
{
    public partial class Homeroom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMsg.Text = "";
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
            }            

        }


        protected void btnLoad_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("Homeroom.aspx");
        }

        protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert", StringComparison.CurrentCultureIgnoreCase))
            {
                lblMsg.Text = "New Homeroom is added successfully!";              

            } 
            else if (e.CommandName.Equals("Cancel", StringComparison.CurrentCultureIgnoreCase))
            {
                lblMsg.Text = "Fail to add new Homeroom!";

            } 
        }
        

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            if (e.Exception == null)
                lblMsg.Text = "Homeroom is deleted succesfully!";
            else
                lblMsg.Text = "Fail to delete this Homeroom!";
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if (e.Exception == null)
                lblMsg.Text = "Homeroom is updated succesfully!";
            else
                lblMsg.Text = "Fail to update this Homeroom!";
        }
               
    }
}
