using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string FirstName = "";
        string LastName = "";
        string ClassOf = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FirstName = ""; LastName = ""; ClassOf = "";
                lblMessage.Text = "";
                txtFirstN.Text = "";
                txtLastN.Text = "";
                ddlClass.SelectedValue = "All";
            }
            else
            {
                FirstName = txtFirstN.Text.Trim();
                LastName = txtLastN.Text.Trim();
                ClassOf = ddlClass.SelectedValue;

            }


        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            int pageIndex = 0;
            try
            {
                gdResult.DataSource = null;
                gdResult.DataBind();
                lblMessage.Text = "";

                FirstName = txtFirstN.Text.Trim();
                LastName = txtLastN.Text.Trim();
                ClassOf = ddlClass.SelectedValue;

                if ((LastName != "") && (FirstName != "") && (ClassOf != "All"))
                    SelectAll(LastName, FirstName, ddlClass.SelectedValue);
                else if ((LastName != "") && (txtFirstN.Text != "") && (ClassOf == "All"))
                    SelectByFirstLast(LastName, txtFirstN.Text);
                else if ((LastName != "") && (txtFirstN.Text == "") && (ClassOf != "All"))
                    SelectByLastYear(LastName, ClassOf);
                else if ((LastName == "") && (txtFirstN.Text != "") && (ClassOf != "All"))
                    SelectByFirstYear(txtFirstN.Text, ClassOf);
                else if ((LastName != "") && (txtFirstN.Text == "") && (ClassOf == "All"))
                    SelectByLast(LastName);
                else if ((LastName == "") && (txtFirstN.Text != "") && (ClassOf == "All"))
                    SelectByFirst(txtFirstN.Text);
                else if ((LastName == "") && (txtFirstN.Text == "") && (ClassOf != "All"))
                    SelectByYear(ClassOf);

            }
            catch (Exception ex)
            {
            }
        }

        private void SelectAll(string last, string first, string year)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();
            var results = from p in db.HHSStudents
                          where p.LastName == last
                             && p.FirstName == first
                             && p.Year == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };

            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByFirstLast(string last, string first)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();

            var results = from p in db.HHSStudents
                          where p.LastName == last
                             && p.FirstName == first
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };
            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByLastYear(string last, string year)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();

            var results = from p in db.HHSStudents
                          where p.LastName == last
                             && p.Year == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };
            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByFirstYear(string first, string year)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();

            var results = from p in db.HHSStudents
                          where p.FirstName == first
                             && p.Year == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };
            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByLast(string last)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();

            var results = from p in db.HHSStudents
                          where p.LastName == last
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };
            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByFirst(string first)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();

            var results = from p in db.HHSStudents
                          where p.FirstName == first
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };
            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }
        private void SelectByYear(string year)
        {
            HHSStudentsDataContext db = new HHSStudentsDataContext();
            var results = from p in db.HHSStudents
                          where p.Year == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.Year
                          };

            if (results.FirstOrDefault() != null)
            {
                gdResult.DataSource = results;
                gdResult.DataBind();
                lblMessage.Text = "Click select to view details !";
            }
            else
                lblMessage.Text = "No student found !";

        }

        protected void gdResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdResult.PageIndex = e.NewPageIndex;
            //rebind the grid
            SelectByYear(ClassOf);
        }

        protected void gdResult_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            

        }

        
    }
}
