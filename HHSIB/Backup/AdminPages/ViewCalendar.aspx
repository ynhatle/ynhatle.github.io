﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCalendar.aspx.cs" Inherits="HHSIB.AdminPages.ViewCalendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<!-- #BeginEditable "meta" -->
<title>Admin Menu</title>
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
	    <h1>Admin Menu</h1><!-- #EndEditable -->
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
    
    <div id="search" style="left: 400px; top: 245px" class="body1"><h1>Update Calendar</h1></div>


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
	<br />
<!-- body1 start -->    
	    <asp:Label ID="lblMsg" runat="server"></asp:Label>
	<table width="100%" border="0" cellpadding="5px 5px 5px 5px">	    
	    <tr>
	        <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                     AutoGenerateColumns="False" DataSourceID="LinqDataSource1" 
                    DataKeyNames="IBDate" Caption="Calendar By Dates" CellPadding="5" 
                    onrowdeleted="GridView1_RowDeleted" onrowupdated="GridView1_RowUpdated" 
                    BackColor="White">
                    <Columns>
                        <asp:BoundField DataField="IBDate" HeaderText="Date" 
                            ApplyFormatInEditMode="True" DataFormatString="{0:MM/dd/yyyy} " 
                            HtmlEncode="False" ReadOnly="True" SortExpression="IBDate" 
                            />
                        <asp:BoundField DataField="IBEvent" HeaderText="Event Description" SortExpression="IBEvent"   
                            />
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    </Columns>
                    <PagerStyle Font-Bold="True" />
                    <SelectedRowStyle BackColor="#CC99FF" />
                    <HeaderStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#CC99FF" />
                    <AlternatingRowStyle BackColor="#CCCCFF" />
                </asp:GridView>
            </td>
	    </tr>
	</table> 
	
<!-- body1 end-->	
	<br />
        
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="HHSIB.IBCalendarDataContext"             
            EnableDelete="True" 
            EnableInsert="True" 
            EnableUpdate="True" 
            OrderBy="IBDate" 
            TableName="IB_Calendars">
        </asp:LinqDataSource>
        
        <br />
<!-- #EndEditable -->

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
		        <td>Copyright © 2008. IB Alliance, Inc. All Rights Reserved.   </table>
		    
			
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

