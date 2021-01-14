using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB.AdminPages
{
    public partial class NewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMsg.Text = "Please add new student, click Done when finish all !!!";
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
                DetailsView1.DataSourceID = "LinqDataSource1";
                DetailsView1.DataBind();

            }
        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            lblMsg.Text = "New Student is added !";
        }

        protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            lblMsg.Text = "New Student is canceled !";
        }

        
    }
}
