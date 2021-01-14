using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB
{
    public partial class _Default : System.Web.UI.Page
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
                GetYears();
                ddlClass.SelectedValue = "All";
                gdResult.SelectedIndex = -1;
                gdResult.PageIndex = 0;
            }
            else
            {
                FirstName = txtFirstN.Text.Trim();
                LastName = txtLastN.Text.Trim();
                ClassOf = ddlClass.SelectedValue;
            }


        }

        private void GetYears()
        {
            int year = 0, month = 0;
            int firstyear = 0, totalyear = 4;

            year = (DateTime.Now).Year;
            month = (DateTime.Now).Month;
            if (month >= 6) //can not add to current year after June
            {
                firstyear = year + 1;
                totalyear = 4;
            }
            else
            {
                firstyear = year;
                totalyear = 5;
            }
            int yy = firstyear;
            ddlClass.Items.Clear();
            ddlClass.Items.Add("All");
            for (int i = 0; i < totalyear; i++)
            {
                ListItem item = new ListItem(yy.ToString());
                ddlClass.Items.Add(item);
                yy = yy + 1;
            }

        }
        
        private void SelectAll(string last, string first, string year)
        {
            IBStudentsDataContext db = new IBStudentsDataContext();
            
            var results = from p in db.IB_Students
                          where p.LastName == last
                             && p.FirstName == first
                             && p.ClassOf == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();
            
            var results = from p in db.IB_Students
                          where p.LastName == last
                             && p.FirstName == first
                          orderby p.ClassOf
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students
                          where p.LastName == last
                             && p.ClassOf == year
                          orderby p.FirstName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students //.HHSStudents
                          where p.FirstName == first
                             && p.ClassOf  == year
                          orderby p.LastName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students
                          where p.LastName == last
                          orderby p.FirstName, p.Email
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students
                          where p.FirstName == first
                          orderby p.LastName, p.ClassOf
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students
                          where p.ClassOf == year
                          orderby p.LastName, p.FirstName
                          select new
                          {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
        private void SelectAllYears()
        {
            IBStudentsDataContext db = new IBStudentsDataContext();

            var results = from p in db.IB_Students                          
                          orderby p.ClassOf, p.LastName, p.FirstName
                          select new  {
                              p.StudentNo,
                              p.LastName,
                              p.FirstName,
                              p.ClassOf
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
            gdResult.SelectedIndex = -1;
            if (ClassOf == "All")
                SelectAllYears();
            else
                SelectByYear(ClassOf);
        }

        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                gdResult.DataSource = null;
                gdResult.DataBind();
                lblMessage.Text = "";
                gdResult.SelectedIndex = -1;
                gdResult.PageIndex = 0;

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
                else if ((LastName == "") && (txtFirstN.Text == ""))
                {
                    if (ClassOf == "All")
                        SelectAllYears();
                    else
                        SelectByYear(ClassOf);
                }

            }
            catch (Exception ex)
            {
            }
        }

               

    }
}
