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
        IBHhsDataContext db = new IBHhsDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMsg.Text = "";
            if(!IsPostBack)
            {
                FillGridview1();
            }
        }

        private void FillGridview1()
        {
            GridView1.DataSource = from slCal in db.CalendarIBs select slCal;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; FillGridview1();
        }

        //protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        //{
        //    int Cid = Convert.ToInt32(GridView1.DataKeys[e.AffectedRows].Value);
        //    CalendarIB c = db.CalendarIBs.Single(casl => casl.id == Cid);
        //    db.CalendarIBs.DeleteOnSubmit(c);
        //    db.SubmitChanges();
        //    FillGridview1();
        //    if (e.Exception == null)
        //        lblMsg.Text = "Calendar Event is deleted succesfully!";
        //    else
        //        lblMsg.Text = "Fail to delete this Calendar event!";

        //}

        //protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        //{
        //    int Cid = Convert.ToInt16(GridView1.DataKeys[e.AffectedRows].Value);
        //    CalendarIB c = db.CalendarIBs.Single(cals => cals.id == Cid);
        //    c.IBEVent = ((TextBox)GridView1.Rows[e.AffectedRows].FindControl("TextBox1")).Text;
        //    string Cdate = ((TextBox)GridView1.Rows[e.AffectedRows].FindControl("TextBox2")).Text;
        //    //c.IBDate = Cdate;
        //    db.SubmitChanges();
        //    GridView1.EditIndex = -1;
        //    FillGridview1();

        //    //if (e.Exception == null)
        //    //    lblMsg.Text = "Calendar is updated succesfully!";
        //    //else
        //    //    lblMsg.Text = "Fail to update this date Event!";
        //}

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex; FillGridview1();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int Cid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
                CalendarIB c = db.CalendarIBs.Single(casl => casl.id == Cid);
                db.CalendarIBs.DeleteOnSubmit(c);
                db.SubmitChanges();
                FillGridview1();
                lblMsg.Text = " Successfully Deleted ";
            }
            catch (Exception E)
            {
                
                lblMsg.Text = "System error when adding , please advise Webmaster." + E.Message;
            }
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int Cid = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            CalendarIB c = db.CalendarIBs.Single(cals => cals.id == Cid);
            c.IBEVent = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string Cdate = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            //c.IBDate = Cdate;
            db.SubmitChanges();
            GridView1.EditIndex = -1;
            FillGridview1();
                lblMsg.Text = " Successfully Updated ";
            }
            catch (Exception E)
            {
                
                lblMsg.Text = "System error when updating , please advise Webmaster." + E.Message;
            }
        }

       

        


    }
}
