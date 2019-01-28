<%@ Page Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="eadLab4.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: block;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            border: 1px solid #ccc;
            padding: 6px 12px;
            background-color: #fff;
            background-image: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Stylesheet/MasterPage.css" rel="stylesheet" />
    <asp:Label ID="Lbl_err" runat="server"></asp:Label>
    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">Search</h3>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <asp:Label ID="lbSearch" runat="server" Text="Type in which trip you want to search for:"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="tbSearch" runat="server" CssClass="auto-style1" placeholder="Input Search Result" OnTextChanged="tbSearch_TextChanged" Width="236px"></asp:TextBox>
            </div>
            <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-default" Text="Search" OnClick="btnSearch_Click" />
        </div>
    </div>

    <asp:Panel ID="PanelSearch" Visible="false" runat="server">
        <div class="panel panel-info">
            <div class="panel-heading">Search Results:</div>
            <div class="panel-body">

                <div class="row">
                    <label for="Lbl_triplocation" class="col-sm-2 col-form-label">Trip Location:</label>
                    <div class="col-sm-4">
                        <asp:Label ID="Lbl_triplocation" runat="server"></asp:Label>
                    </div>
                    <label for="Lbl_triptype" class="col-sm-2 col-form-label">Trip Type:</label>
                    <div class="col-sm-4">
                        <asp:Label ID="Lbl_triptype" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <label for="Lbl_tripduration" class="col-sm-2 col-form-label">Trip Duration:</label>
                    <div class="col-sm-4">
                        <asp:Label ID="Lbl_tripduration" runat="server"></asp:Label>
                    </div>
                    <label for="Lbl_tripcost" class="col-sm-2 col-form-label">Trip Cost:</label>
                    <div class="col-sm-4">
                        <asp:Label ID="Lbl_tripcost" runat="server"></asp:Label>
                    </div>
                </div>
                <br />
            </div>
        </div>
    </asp:Panel>
</asp:Content>
