<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ClientApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E Learn System</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <style>
        .textArea{
            width:80%;
            height:30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:red;"><b>E Lerning System</b></h1>
            <hr />
          
            <div class="form-group">
            <asp:ListBox ID="ListBox1" runat="server"  OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="true" Font-Bold="true"></asp:ListBox>
            


            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;



            <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" AutoPostBack="true" Font-Bold="true"></asp:ListBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox1" runat="server" class="form-control" Font-Bold="True"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            
            </div>              
          
        </div>
        <asp:TextBox ID="TextBox2" runat="server" Width="1276px" class="textArea" Columns="50" ReadOnly="True" Rows="70" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>
