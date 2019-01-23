<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Enquiry.aspx.cs" Inherits="eadLab4.Enquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h3>Enquiry</h3>
        <p>Contact us at telephone 91234567 or email our customer officer at
            admin@eadp.com.<br />
            Alternatively leave us your information, our customer officer will contact you
            shortly!
         </p>
        <form id="fm_contact" runat="server" class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                 <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                 <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                 <asp:Label ID="lblEnquiry" runat="server" Text="Enquiry: "></asp:Label>
                 <asp:TextBox ID="tbEnquiry" runat="server" Height="49px" Width="500px"
                    TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
            </div>
         </form>
      </div>
</asp:Content>
