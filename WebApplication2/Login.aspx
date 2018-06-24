<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>
<%--- view in FULL SCRENN FN 11---%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN FORM</title>
   
    <style>
        body 
        {
            background-image: url(1a.png);
        }
       
        .formclass {
            padding: 100px;
            margin: 146px auto 0px auto;
            width: 301px;
        }
        h1
        {
            text-align:center;
            color:#ffffff;
            margin-left: 40px;
        }
        </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="formclass">
            <h1>LOGIN</h1><br />
            <asp:TextBox ID="txtuser" CssClass="input" placeholder="user Name" runat="server" BackColor="Black" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" 
                BorderStyle="Double" BorderWidth="5px" Height="32px" Width="295px" Font-Italic="True"></asp:TextBox><br /><br />

            <asp:TextBox ID="txtpass" CssClass="input" placeholder="Password" TextMode="Password" runat="server" BackColor="Black" Font-Size="Large" ForeColor="White" 
                BorderColor="#45B7ED"   BorderStyle="Double" BorderWidth="5px" Height="32px" Width="295px" Font-Italic="True"></asp:TextBox>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button CssClass="input" class="btn" runat="server" Text="SUBMIT" OnClick="Button1_Click"  style="background-color: Transparent" BorderStyle="None" Font-Size="X-Large" 
                ForeColor="White" Height="38px" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Overline="False" />
            xds</div>
    </form>
</body>
</html>

