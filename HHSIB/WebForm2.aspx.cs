using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace HHSIB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Hashtable schedule = new Hashtable();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetSchedule();
            Calendar1.Style.Add("position", "absolute");
            Calendar1.Style.Add("left", "5px");
            Calendar1.Style.Add("top", "50px");
            Calendar1.Caption = "IB Calendar";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.MonthYear;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Left;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Top;
            Calendar1.DayStyle.Height = new Unit(75);
            Calendar1.DayStyle.Width = new Unit(100);
            
            //Calendar1.TodaysDate = new DateTime(2009,4,1);
            //Calendar1.VisibleDate = Calendar1.TodaysDate;
            Calendar1.VisibleDate = Calendar1.TodaysDate;


        }

        private void GetSchedule()
        {
            schedule["4/22/2009"] = "Early Release";
            schedule["4/25/2009"] = "GradNite Hollywood!";
            schedule["4/30/2009"] = "Senoir Last Day of school";
            schedule["5/13/2009"] = "Early Release";
            schedule["6/04/2009"] = "Senoir Graduation";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            
        }

        protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        {

            Literal lit = new Literal();
            lit.Visible = true;
            lit.Text = "<br>";
            e.Cell.Controls.Add(lit);
            if (schedule[e.Day.Date.ToShortDateString()] != null)
            {
                Label lbl = new Label();
                lbl.Visible = true;                
                lbl.Text = (string)schedule[e.Day.Date.ToShortDateString()];
                e.Cell.Controls.Add(lbl);
            } 
        }
    }
}

