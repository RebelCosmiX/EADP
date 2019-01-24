<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeBehind="ViewCustTrip.aspx.cs" Inherits="eadLab5.ViewCustTrip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 339px;
            height: 33px;
        }
        .auto-style2 {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
           <table id="cart" class="table table-hover table-condensed">
                 <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow" onitemcommand="DataList1_ItemCommand">
                    <HeaderTemplate>
                    <thead>
						<tr>
							<th >Id</th>
							<th >Name</th>
							<th>Delete</th>
						</tr>
					</thead>
                </HeaderTemplate>

                <ItemTemplate>
                    <tbody>
						<tr>
							<td data-th="custTripId">
							<asp:Label ID="lblName" runat="server" Text='<%#Eval("custTripId") %>'></asp:Label>
							</td>
							<td data-th="tripName"><asp:Label ID="sad" runat="server" Text='<%#Eval("tripName") %>'></asp:Label></td>
							<td class="actions" data-th=""> <asp:LinkButton ID="LinkButton2" class="btn btn-danger" runat="server" CommandArgument='<%#Eval("custTripId") %>'>Remove</asp:LinkButton></td>
                        </tr>
					</tbody>
                     </ItemTemplate>
                </asp:DataList>
			</table>
               
            
            </div>
    </form>
</asp:Content>
