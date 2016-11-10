<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cotizacion.aspx.cs" Inherits="Hoja.Cotizacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
    <script type="text/javascript" src="../js/scripts.js"></script>
    <link href="../css/reset.css" rel="stylesheet" type="text/css" />
    <link href="../css/960.css" rel="stylesheet" type="text/css" />
    <link href="../css/coolMenu.css" rel="stylesheet" type="text/css" media="screen" />
    <script type="text/javascript" src="../js/modernizr-1.6.min.js"></script>
    <style>

</style>
    <%--        <style>
        #menu {
            width: 50px;
            cursor: pointer;
        }
        
        #menu_button {
            width: inherit;
            background-color: #DDD;
        }
        

    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="coolMenu" runat="server" />
        </div>


    </form>
</body>
</html>
