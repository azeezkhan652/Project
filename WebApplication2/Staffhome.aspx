﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staffhome.aspx.cs" Inherits="WebApplication2.Staffhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN REPORTS</title>
      <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <link rel="stylesheet" href="Content/bootstrap.min.css" />
  <script src="Scripts/jquery-1.10.2.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>

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
      <li class="active"><a href="Staffhome.aspx">HOME</a></li>
        <li><a href="Documents.aspx">DOCUMENTS</a></li>
        <li><a href="Videos.aspx">VIDEOS</a></li>
        <li><a href="Delete.aspx">DELETE</a></li>
    </ul>
       <ul class="nav navbar-nav navbar-right">
     
      <li><a href="Login.aspx"><span class="glyphicon glyphicon-log-out"></span>LOGOUT</a></li>
    </ul>
  </div>
</nav>
  
<div class="container">
  <h3>Navbar With Dropdown</h3>
  <p>ADMIN LOGIN SUCCESSFULL </p>
    <p>ADMIN HOME PAGE</p>
</div>
    </form>
</body>
</html>

