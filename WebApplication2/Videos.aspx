<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Videos.aspx.cs" Inherits="WebApplication2.Videos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN REPORTS</title>
      <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <link rel="stylesheet" href="Content/bootstrap.min.css" />
  <script src="Scripts/jquery-1.10.2.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>

     <link href="css/pikaday.css" rel="stylesheet" />
    <script src="css/pikaday.js"></script>
    <link href="css/theme.css" rel="stylesheet" />
    <link href="css/triangle.css" rel="stylesheet" />

    <style type="text/css">
        .nav a{
    font-size:large;
    }
        /*DOWN BACKGROUND COLOR WILL CHANGE COLOR OF NAVBAR*/
        .navbar-default {
    background-color: aqua;
    border-color: #E7E7E7;
}
/* Title */
.navbar-default .navbar-brand {
    color: #777;
}
.navbar-default .navbar-brand:hover,
.navbar-default .navbar-brand:focus {
    color: #5E5E5E;
}
/* Link */
.navbar-default .navbar-nav > li > a {
    color: #ffffff;
}
.navbar-default .navbar-nav > li > a:hover,
.navbar-default .navbar-nav > li > a:focus {
    color: #333;
}
.navbar-default .navbar-nav > .active > a,
.navbar-default .navbar-nav > .active > a:hover,
.navbar-default .navbar-nav > .active > a:focus {
    color: #555;
    background-color: #E7E7E7;
}
.navbar-default .navbar-nav > .open > a,
.navbar-default .navbar-nav > .open > a:hover,
.navbar-default .navbar-nav > .open > a:focus {
    color: #555;
    background-color: #D5D5D5;
}
/* Caret */
.navbar-default .navbar-nav > .dropdown > a .caret {
    border-top-color: #777;
    border-bottom-color: #777;
}
.navbar-default .navbar-nav > .dropdown > a:hover .caret,
.navbar-default .navbar-nav > .dropdown > a:focus .caret {
    border-top-color: #333;
    border-bottom-color: #333;
}
.navbar-default .navbar-nav > .open > a .caret,
.navbar-default .navbar-nav > .open > a:hover .caret,
.navbar-default .navbar-nav > .open > a:focus .caret {
    border-top-color: #555;
    border-bottom-color: #555;
}
/* Mobile version */
.navbar-default .navbar-toggle {
    border-color: #DDD;
}
.navbar-default .navbar-toggle:hover,
.navbar-default .navbar-toggle:focus {
    background-color: #DDD;
}
.navbar-default .navbar-toggle .icon-bar {
    background-color: #CCC;
}
@media (max-width: 767px) {
    .navbar-default .navbar-nav .open .dropdown-menu > li > a {
        color: #777;
    }
    .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover,
    .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
          color: #333;
    }
}
       #TextBox1, #TextBox2, #TextBox3, #DropDownList1, #DropDownList2, #DropDownList3, #DropDownList4{
            color: #ffffff;
            background-color: rgba(0, 52, 255, 0.75);
            padding: 6px 15px 6px 35px;
            border-radius: 20px;
            box-shadow: 0 1px 0 #ccc inset;
            transition: 500ms all ease;
            outline: 0;
            font-size:16px;
            font-weight:bolder;
        }

                 #TextBox1:hover,   #TextBox2:hover,  #TextBox3:hover,  #DropDownList1:hover,  #DropDownList2:hover,  #DropDownList3:hover,  #DropDownList4:hover{
    width: 270px;
}
        body {
            background-image:url(2a.jpg) ;
            background-size:cover;
                font-size:16px;
            font-weight: bolder;
        color:#ff0000;
        }
    </style>
</head>





<body>
    <form id="form1" runat="server">
    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#"><asp:Image ID="Image1" runat="server" Height="35px" ImageUrl="~/download.png" Width="200px" />
        </a>
    &nbsp;</div>
    <ul class="nav navbar-nav">
      <li><a href="Staffhome.aspx">HOME</a></li>
        <li><a href="Documents.aspx">DOCUMENTS</a></li>
        <li class="active"><a href="Videos.aspx">VIDEOS</a></li>
        <li><a href="Delete.aspx">DELETE</a></li>
    </ul>
       <ul class="nav navbar-nav navbar-right">
     
      <li><a href="Login.aspx"><span class="glyphicon glyphicon-log-out"></span>LOGOUT</a></li>
    </ul>
  </div>
</nav>
  
<div class="container">
  <h3>&nbsp;</h3>
  <p>&nbsp;</p>
    <div style="margin-left: 40px">
        <div style="margin-left: 40px">
            <div style="margin-left: 40px">
                <div style="margin-left: 40px">
                    <div style="margin-left: 40px">
                        <div style="margin-left: 40px">
                            <p>
    &nbsp; COURSE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="course" DataValueField="course" >
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT DISTINCT [course] FROM [course]"></asp:SqlDataSource>
                                <br />
                                <br />&nbsp; SEMESTER:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="semester" DataValueField="semester" >
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT DISTINCT [semester] FROM [course] WHERE ([course] = @course)">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="DropDownList4" Name="course" PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                <br />&nbsp;SUBJECT:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="subject" DataValueField="subject">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [subject] FROM [course] WHERE (([semester] = @semester) AND ([course] = @course))">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="DropDownList1" Name="semester" PropertyName="SelectedValue" Type="String" />
                                        <asp:ControlParameter ControlID="DropDownList4" Name="course" PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <br />
                                <br />VIDEO NAME:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />
                                <br />DATE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
     <script type="text/javascript">
         var picker = new Pikaday(
             {
                 field: document.getElementById('TextBox2'),
                 firstDay: 1,
                 minDate: new Date('1000-01-01'),
                 maxDate: new Date('3000-12-31'),
                 yearRange: [1000, 3000],
                 numberOfMonths: 1,
                 theme: 'dark-theme'
             });
     </script> 
                                <br />
                                <br />DESCRIPTION:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <br />SELECT FILE:<asp:FileUpload ID="FileUpload1" runat="server" />
                                <br />
                                <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" Text="UPLOAD" Width="83px" OnClick="Button1_Click"  />
                                <br />
                                <br />
                                <br />
                                <br />
                                <asp:GridView ID="gvdocuments" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" style="margin-top: 0px" Visible="False">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Sl No">
                                            <ItemTemplate>
                                                <%# Container.DataItemIndex+1  %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Documents">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" Onclick="opendocument" Text='<%# Eval("Name") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </p>
    <br />
</div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
