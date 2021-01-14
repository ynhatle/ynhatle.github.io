using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB.AdminPages
{
    public partial class ViewCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            if (e.Exception == null)
                lblMsg.Text = "Calendar Event is deleted succesfully!";
            else
                lblMsg.Text = "Fail to delete this Calendar event!";

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if (e.Exception == null)
                lblMsg.Text = "Calendar is updated succesfully!";
            else
                lblMsg.Text = "Fail to update this date Event!";
        }
    }
}
