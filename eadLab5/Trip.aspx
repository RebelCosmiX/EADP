<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeBehind="Trip.aspx.cs" Inherits="eadLab5.Trip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <asp:GridView ID="GridView1" CssClass="table table-striped" runat="server"></asp:GridView>

        <section class="section">
            <h1>Shopping Cart</h1>
            <div class="container">
	        <table id="cart" class="table table-hover table-condensed">
                 <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow">
                    <HeaderTemplate>
                    <thead>
						<tr>
							<th style="width:10%">Id</th>
							<th style="width:10%">Name</th>
							<th style="width:40%">Desription</th>
                            <th style="width:10%">Country</th>
							<th style="width:15%">Latitude</th>
                            <th style="width:15%">Longtitude</th>
						</tr>
					</thead>
                </HeaderTemplate>

                <ItemTemplate>
                    <tbody>
						<tr>
							<td data-th="id">
										<h4 class="nomargin"><asp:Label ID="lblName" runat="server" Text='<%#Eval("id") %>'></asp:Label></h4>
							</td>
							<td data-th="tripName"><asp:Label ID="lblPrice" runat="server" Text='<%#Eval("tripName") %>'></asp:Label></td>
							<td data-th="tripDescription"><asp:Label ID="Label1" runat="server" Text='<%#Eval("tripDescription") %>'></asp:Label></td>
						    <td data-th="tripCountry"><asp:Label ID="Label2" runat="server" Text='<%#Eval("tripName") %>'></asp:Label></td>
                            <td data-th="lat"><asp:Label ID="Label3" runat="server" Text='<%#Eval("lat")%>'></asp:Label></td>
                            <td data-th="lng"><asp:Label ID="Label4" runat="server" Text='<%#Eval("lng")%>'></asp:Label></td>
                        </tr>
					</tbody>
                     </ItemTemplate>
                </asp:DataList>
                 
			</table>
               
            
            </div>
            </section>
    </form>
    
</asp:Content>
