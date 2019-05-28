<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rabisco.aspx.cs" Inherits="exercicio3.rabisco" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

 

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">

    <title></title>

</head>


    <form id="form1" runat="server">
        <div>
            <asp:textbox runat="server" id="nomeid"></asp:textbox>
            <br />
            <asp:button runat="server" text="enviar" onclick="click"/>
            <br />
            <asp:label runat="server" text="Label" id="lblnome"></asp:label>
        </div>



    </form>