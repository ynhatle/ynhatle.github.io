<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectoryUpdate.aspx.cs" Inherits="HHSIB.AdminPages.DirectoryUpdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<!-- #BeginEditable "meta" -->
<title>Update Students</title>
<meta name="Keywords" content="place your keywords here" />
<meta name="Description" content="place a description for your webpage here" />
<!-- #EndEditable -->

<meta name="language" content="en-US" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<!-- Links to Style Sheets Begin-->
<link href="/styles/fullscreen.css" rel="stylesheet" type="text/css" />
<link href="/styles/stylesheet.css" rel="stylesheet" type="text/css" />
<link href="/styles/menu.css" rel="stylesheet" type="text/css" />
<link href="/styles/fonts.css" rel="stylesheet" type="text/css" />
<!-- Links to Style Sheets End-->
<style type="text/css">
    .detail_body {font:veranda; color:Black; font-size:small; padding-left:5px; padding-right: 5px}
</style> 

<!-- Links to Javascript files Begin-->
<script type="text/javascript" src="/javascript/swfobject.js"></script>
<script type="text/javascript" src="/javascript/special_functions.js" ></script>
<script type="text/javascript" src="/javascript/faq.js" ></script>
<script type="text/javascript" src="/javascript/menu.js"></script>
<!--[if lt IE 7.]>
<script defer type="text/javascript" src="../javascript/faq.js"></script>
<![endif]-->
<!-- Links to Javascript files End-->

<!-- #BeginEditable "flash_variables" -->
<script type="text/javascript">
    // if this page is in:
    //   the root folder, then set this variable to ./
    //   a sub folder one level deep, then set this variable to ../
    //   a sub folder two levels deep, then set this variable to ../../
    var rootFlashLocation = "../";
    var music_on = 1; // 0 = off, 1 = on
    var clock24hour = 1; // 0 = 12 hour clock, 1 = 24 hour clock
    var maxIntroViews = -1; // -1 = always display, 0 = never display, and any other positive integer = the number of times to display the intro sequence
    var isPersistantCookie = 0; // 0 =  no, 1 = yes -- persistant means it will save even after the user closes their browser
</script>
<!-- #EndEditable -->

</head>

<body>
    <form id="fom1" runat="server">
    <!--main-->
	<div id="main">
	
<!--top-->
	<div class="top">
		<div class="top_r">
			<div class="top_l">
			
<!--header-->

<!--main-->
	<div class="header">
	
	<!--flash header-->
	<div id="template_flash" style="left: 133px; top: 100px">
		<div id="flashcode"></div>
	</div>
	<script type="text/javascript">
	    var so = new SWFObject(rootFlashLocation + "flash/flash-images/template-images.swf", "flashcode", "200", "100", "6");
	    so.addParam("wmode", "transparent");
	    so.addParam("base", rootFlashLocation);
	    so.addVariable("music_on", music_on);
	    so.addVariable("clock24hour", clock24hour);
	    so.write("flashcode");
	</script>
		
<!--page title-->
    
	<div id="page_title" style="left: 225px; top: 5px">
	<!-- #BeginEditable "page_title" -->
	    <h1>Directory Update</h1><!-- #EndEditable -->
	</div>
    

<!--icons-->
	<div id="icons" style="left: 140px; top: 247px; position:absolute">
	<!-- #BeginLibraryItem "/Library/icons.lbi" -->
	<table border="0" width="100%" cellpadding="0" cellspacing="0">
	    <tr>
		    <td>
                <img src="/graphics/home.png" width="20" height="20" alt="home" /><a href="/./index.htm">Home</a>
                <img src="/graphics/contact.png" width="20" height="20" alt="contact" /><a href="../contact.htm">Contact</a>
                <!--img src="graphics/sitemap.png" width="20" height="20" alt="sitemap" /><a href="sitemap.htm">Search</a-->
            </td>
	    </tr>
    </table><!-- #EndLibraryItem -->
    </div>
    
    <div id="search" style="left: 400px; top: 245px" class="body1"><h1>Admin Menu</h1></div>


<!--top button-->
	<div id="top_buttons_w"  style="right:185px; top: 207px; position:absolute">
	
	<!-- #BeginLibraryItem "/Library/top_buttons.lbi" -->
	<div class="chromestyle" id="chromemenu">
        <ul>         
        <li><a href="/class_news.htm">News</a></li>       
        <li><a href="" rel="dropmenu1">Class News</a></li>
        <li><a href="/college_lab.htm">College Lab</a></li>
        <li><a href="" rel="dropmenu3">IB Office</a></li> 
        <li><a href="" rel="dropmenu5">Calendar</a></li>        
        <li><a href="" rel="dropmenu4">CAS Info</a></li>
        </ul>
    </div>
    
    
    <!--1st drop down menu -->                                                   
    <div id="dropmenu1" class="dropmenudiv" style="width: 90px";>    
    <a href="/class_news_2009.htm">2009</a>
    <a href="/class_news_2010.htm">2010</a>
    <a href="/class_news_2011.htm">2011</a>
    <a href="/class_news_2012.htm">2012</a>
    <a href="/class_news_2013.htm">2013</a>
    </div>

    
    <div id="dropmenu2" class="dropmenudiv" style="width: 90px;">
        <a href="/college_lab.htm#Id18">Issue 18</a>
        <a href="/college_lab.htm#Id17">Issue 17</a>
        <a href="/college_lab.htm#Id16">Issue 16</a>
        <a href="/college_lab.htm#Id15">Issue 15</a>
        <a href="/college_lab.htm#Id14">Issue 14</a>
        <a href="/college_lab.htm#Id13">Issue 13</a>
        <a href="/college_lab.htm#Id12">Issue 12</a>
        <a href="/college_lab.htm#Id11">Issue 11</a>
        <a href="/college_lab.htm#Id10">Issue 10</a>
        <a href="/college_lab.htm#Id9">Issue 9</a>
        <a href="/college_lab.htm#Id8">Issue 8</a>
        <a href="/college_lab.htm#Id7">Issue 7</a>
        <a href="/college_lab.htm#Id6">Issue 6</a>        
    </div>    


    <!--3rd drop down menu -->                                                   
    <div id="dropmenu3" class="dropmenudiv" style="width: 100px;">
    <a href="/Coordinator.htm">Coordinator</a>
    <a href="/Counselor.htm">Counselor</a>
    </div>
    
    <!--4th drop down menu -->                                                
    <div id="dropmenu4" class="dropmenudiv" style="width: 105px;">
    <a href="/CAS.htm#1">What is CAS ?</a>
    <a href="/CAS.htm#2">CAS Guidelines</a>
    <a href="/CAS.htm#3">Nature of CAS</a>
    <a href="/CAS.htm#4">Questions</a>
    <a href="/CAS.htm#5">Organization</a>
    <a href="/CAS.htm#6">Examples</a>
    </div>
    
    <!--5th drop down menu -->                                                
    <div id="dropmenu5" class="dropmenudiv" style="width: 80px;">
    <a href="/ibCalendar.aspx">HHS IB</a>
    <a href="http://hillsborough.mysdhc.org/18F676FF-00757E5A?object=/hillsborough_calendar&templates=RWD&ConfPosition=0&Calendar=1&infobar=no">
        HHS</a>
    <a href="http://www.sdhc.k12.fl.us/info/calendars/">District</a>    
    </div>

    <script type="text/javascript">

        cssdropdown.startchrome("chromemenu")
    </script>
    <!-- #EndLibraryItem -->
    </div>
<!-- end top button -->
<!--logo-->
	<div id="logo" style="left: 275px; top: 20px"><!-- #BeginLibraryItem "/Library/logo.lbi" -->
	<div>
        <img src="/logo/logo.png" width="400" height="94" alt="logo" />
    </div><!-- #EndLibraryItem -->
    </div>
<!--end logo -->

	</div>
	</div>
	</div>
	</div>	
	
<!--center-->
	<div class="center">
	<div class="c2">
	<div class="c6">
	<div class="c4">
	<div class="c8">
	<div class="c5">
	<div class="c7">
	<div class="c3">
	<div class="c1">
	
<!--content tables-->
	<table class="content">
		<tr><td scope="col" class="c_l"></td>
			<td scope="col" class="c_menu">

	        <!-- #BeginEditable "body2" -->		
    <div class="body2">
    
    <!--themed image-->
	<div id="themed_image">
		<div id="themed_image2"><!-- #BeginLibraryItem "/Library/themed_image.lbi" -->
		<img border="0" src="/flash/themed-image/themed-image.png" width="160" height="100" alt="themed image" /><!-- #EndLibraryItem --></div>
	</div>

    
	<!--copy for left menu goes here-->

    <!--menu--><!-- #BeginLibraryItem "/Library/vertical_menu.lbi" --> 
    <div class="Vertical_Menu">
	    <ul class="myVerticalMenu">
	        <li><a href="/index.htm">Home</a></li>
	        <li><a href="AddStudents.aspx">Add Students</a></li>	        		  
	        <li><a href="DirectoryUpdate.aspx">Update Students</a></li>	           	        	        		
		    <li><a href="Homeroom.aspx">Update Homeroom</a></li>
		    <li><a href="UpdateCalendar.aspx">Add to Calendar</a></li>
		    <li><a href="ViewCalendar.aspx">Update Calendar</a></li>	 	    
		    <li></li>
		    <li></li>
		    <li></li>
		    <li></li>
		    <li></li>
		    <li></li>	    
	    </ul>
    </div><!-- #EndLibraryItem -->
			
    <!--menu end--><br />
			
    </div>

<!-- #EndEditable -->

	</td><td scope="col" class="c_c"></td>
	<td scope="col" class="body1">
	
<!--body-->		
	<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
	<table width="100%" border="0">
        <%--<tr>
            <td colspan="2" align="left"><span style="color:blue; font-size:x-small;font-style:italic; font-family:Comic Sans MS"><asp:LoginName ID="LoginName1" runat="server" /></span>
	        </td><td colspan="2" align="right"><span style="color:blue; font-size:x-small; font-style:italic; font-family:Comic Sans MS">
                Click here to <asp:LoginStatus ID="LoginStatus1" runat="server" /></span>
            </td>
        </tr>--%>
        <br />
        <tr>
            <td colspan = "4" align="center"><span style="color:Maroon;font-size:small">Search 
                By:</span></td>
        </tr> 
           
        <tr>             
            <td>Last name:</td>
            <td><asp:TextBox ID="txtLastN" runat="server"></asp:TextBox></td>
            <td>First name:</td>
            <td><asp:TextBox ID="txtFirstN" runat="server"></asp:TextBox></td>
        </tr>
        <tr>    
            <td>Class of:</td>
            <td><asp:DropDownList ID="ddlClass" runat="server" Width="75px">                    
                </asp:DropDownList>
            </td> 
            <td align="center">
                <asp:ImageButton ID="btnSearch" runat="server" 
                    ImageUrl="~/graphics/btn_search.jpg" AlternateText="Press to search" 
                    onclick="btnSearch_Click" />
            </td>
            <td></td>
        </tr> 
    </table>        
    <br />	
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <table width="100%" border="0">
        <tr>
            <td colspan = "2"><asp:Label ID="lblMessage" runat="server" Text="" CssClass="detail_body"></asp:Label>    
            </td>
        </tr>    
        <tr>            
            <td width="50%" valign="top">
            <asp:GridView ID="gdResult" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" CellPadding="5" Font-Size="X-Small" 
            HeaderStyle-Font-Bold="true" onpageindexchanging="gdResult_PageIndexChanging"             
            PagerSettings-FirstPageText="First" PagerSettings-LastPageText="Last" 
            PagerSettings-Mode="NumericFirstLast" PagerSettings-NextPageText="Next" 
            PagerSettings-Position="Bottom" PagerSettings-PreviousPageText="Prev" 
            PagerStyle-Font-Size="Small" PageSize="10" DataKeyNames="StudentNo">
            <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" 
                PreviousPageText="Prev" />
            <RowStyle BackColor="White" CssClass="detail_body" Font-Size="XX-Small" 
                ForeColor="Black" />
            <Columns>
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="ClassOf" HeaderText="Class Of" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <PagerStyle Font-Size="Medium" />
            <SelectedRowStyle BackColor="#CCCCFF" Font-Bold="True" ForeColor="#6600CC" />
            <HeaderStyle BackColor="Gray" Font-Bold="True" Font-Size="X-Small" 
                ForeColor="White" />
            <AlternatingRowStyle BackColor="#CCFFFF" ForeColor="Black" />
            </asp:GridView>
            
            <br />
            <asp:Panel ID="RefreshDiv" runat="server">
                <asp:ImageButton ID="btnRefresh" runat="server" 
                    ImageUrl="~/graphics/btn_refresh.jpg" onclick="btnSearch_Click" />
                    </asp:Panel>
            <br /><br />
            </td>
            <td width="50%"  valign="top">
            <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="5" Font-Size="X-Small" 
                    AutoGenerateRows="False" BackColor="White" DataSourceID="LinqDataSource1" 
                    DataKeyNames="StudentNo" 
                    AutoGenerateDeleteButton="True" 
                    AutoGenerateEditButton="True" 
                    onitemcommand="DetailsView1_ItemCommand"
                    >                
                <Fields>
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" 
                        SortExpression="LastName" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" 
                        SortExpression="FirstName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" 
                        SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" 
                        SortExpression="City" />
                    <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" 
                        SortExpression="ZipCode" />
                    <asp:BoundField DataField="Email" HeaderText="Email" 
                        SortExpression="Email" />
                    <asp:BoundField DataField="Phone1" HeaderText="Phone" 
                        SortExpression="Phone1" />
                    <asp:BoundField DataField="Phone2" HeaderText="Alt.Phone" 
                        SortExpression="Phone2" />
                    <asp:BoundField DataField="Homeroom" HeaderText="Homeroom" 
                        SortExpression="Homeroom" />
                    <asp:BoundField DataField="ClassOf" HeaderText="ClassOf" 
                        SortExpression="ClassOf" />
                    <asp:BoundField DataField="Parents" HeaderText="Parents" 
                        SortExpression="Parents" />
                    <asp:BoundField DataField="ParentEmail1" HeaderText="Parent Email1" 
                        SortExpression="ParentEmail1" />
                    <asp:BoundField DataField="ParentEmail2" HeaderText="Parent Email2" 
                        SortExpression="ParentEmail2" />
                </Fields>
                <CommandRowStyle BackColor="#CC0000" BorderStyle="Double" Font-Bold="True" 
                    Font-Size="Small" ForeColor="White"  />
                <RowStyle Width="250px" />
                <FieldHeaderStyle BackColor="Gray" Font-Bold="True" BorderStyle="None" 
                    Font-Size="X-Small" ForeColor="White"  />
                <EditRowStyle BackColor="#CCCCFF"  />
                <AlternatingRowStyle BackColor="#CCFFFF" />
            </asp:DetailsView>
            </td>
         </tr>
     </table>     
    </ContentTemplate>  
    </asp:UpdatePanel>
	    
    
	<!--body1 end-->
	
	<asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="HHSIB.IBStudentsDataContext"             
            TableName="IB_Students" 
            EnableDelete="True" 
            EnableUpdate="True"             
            Where="StudentNo == @StudentNo"                
            >
        <WhereParameters>
            <asp:ControlParameter ControlID="gdResult" DefaultValue="0" Name="StudentNo" 
                PropertyName="SelectedValue" Type="Int32" />
        </WhereParameters>
            
        </asp:LinqDataSource>
    </td>
	<td scope="col" class="c_r">&nbsp;</td></tr></table>

<!--end content-->

</div></div></div></div></div></div></div></div></div>


<!--bottom-->

<!--footer-->
<!--footer-->
<div class="bottom">
	<div class="bottom_r">
		<div class="bottom_l">
		
		<div class="body3">	
		
		<div class="footer">
			
				<div class="footer_l">
				
<!--Start favorites-->
	<div id="favorites" style="left: 259px; top: 7px"><!-- #BeginLibraryItem "/Library/favorites.lbi" --><div class="favorites_button">
<a href="javascript:bookmark()">
<img src="/graphics/favorites.png" class="favorites_button" alt="bookmark" width="70" height="80" /></a>
</div><!-- #EndLibraryItem --></div>
		
<!--Start contact-->
	<div id="contact" style="left: 174px; top: 7px"><!-- #BeginLibraryItem "/Library/contact.lbi" --><a href="mailto:hhsibwebmaster@gmail.com?subject=Message from website">
<img src="/graphics/contact_us.png" class="contact_button" alt="contact us" width="70" height="80" /></a><!-- #EndLibraryItem --></div>

				</div>
				
				<div class="footer_r">
				
<!--Start site_info-->
			<div id="site_info"><!-- #BeginLibraryItem "/Library/site_info.lbi" -->
			<table border="0" width="100%" cellpadding="0" cellspacing="0">	        
	        <tr>	         
		        <td>Copyright © 2008. IB Alliance, Inc. All Rights Reserved. 
		        </td>
		    </tr>
		    </table>
		    
			
		</div>
	</div>
</div>
	

    </div>
    </div></div></div></div>
    <!--main end-->
    </form>
		
		<!-- #EndEditable -->
 </body>

<!-- #EndTemplate -->
</html>	
