<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eadLab4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <link href="StyleSheet/DefaultPage.css"  rel="stylesheet"/>
    <asp:Image ID="ImgMainPge" ImageUrl="~/Images/NYPSchool.jpg" runat="server" Width="100%" Height="410px" CssClass="auto-style1" />
    <div class="Role">
        <p>Who are you?</p>

        <main>
            <section>
                <ul>
                    <li>
                        <div>
                            <asp:Label ID="LblStudent" runat="server" Text="Student"></asp:Label>
                            <asp:ImageButton ID="ImgBtnStudentLogin" runat="server" ImageUrl="~/Images/Student.jpg" Height="120px" Width="200px" CssClass="ImgBtnAlign" OnClick="ImgBtnStudentLogin_Click" />
                        </div>
                    </li>

                    <li>
                        <div>
                            <asp:Label ID="LblStaff" runat="server" Text="Staff"></asp:Label>
                            <asp:ImageButton ID="ImageBtnStaffLogin" runat="server" ImageUrl="~/Images/Staff.jpg" Height="120px" Width="200px" CssClass="ImgBtnAlign" OnClick="ImageBtnStaffLogin_Click" />
                        </div>
                    </li>

                    <li>
                        <div>
                            <asp:Label ID="LblAdmin" runat="server" Text="Admin"></asp:Label>
                            <asp:ImageButton ID="ImageBtnAdminLogin" runat="server" ImageUrl="~/Images/Admin.jpg" Height="120px" Width="200px" CssClass="ImgBtnAlign" OnClick="ImageBtnAdminLogin_Click" />
                        </div>
                    </li>
                </ul>
            </section>
        </main>
    </div>
</asp:Content>
