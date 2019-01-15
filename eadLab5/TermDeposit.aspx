<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeBehind="TermDeposit.aspx.cs" Inherits="eadLab5.TermDeposit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-inline">

        <div class="row">
            <div class="col-sm-8">
                <!-- Refer to http://getbootstrap.com/components/#alerts on using Alert -->
                <asp:Panel ID="PanelErrorResult" Visible="false" runat="server" CssClass="alert alert-dismissable alert-danger">
                    <button type="button" class="close" data-dismiss="alert">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <asp:Label ID="Lbl_err" runat="server"></asp:Label>
                </asp:Panel>

                <!-- Refer to http://getbootstrap.com/components/#panels on using Panel -->
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h3 class="panel-title">Search</h3>
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <asp:Label ID="lbCustId" runat="server" Text="Customer NRIC:"></asp:Label>
                            <asp:TextBox ID="tbCustId" runat="server" CssClass="form-control" placeholder="Input NRIC"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnGetCustomer" runat="server" CssClass="btn btn-default" Text="Get" OnClick="btnGetCustomer_Click" />

                    </div>
                </div>
                <asp:Panel ID="PanelCust" Visible="false" runat="server">
                    <div class="panel panel-info">
                        <div class="panel-heading">Results:</div>
                        <div class="panel-body">

                            <div class="row">
                                <label for="Lbl_custname" class="col-sm-2 col-form-label">Name :</label>
                                <div class="col-sm-4">
                                    <asp:Label ID="Lbl_custname" runat="server"></asp:Label>
                                </div>
                                <label for="Lbl_HomePhone" class="col-sm-2 col-form-label">Home Phone:</label>
                                <div class="col-sm-4">
                                    <asp:Label ID="Lbl_HomePhone" runat="server"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <label for="Lbl_Address" class="col-sm-2 col-form-label">Address :</label>
                                <div class="col-sm-4">
                                    <asp:Label ID="Lbl_Address" runat="server"></asp:Label>
                                </div>
                                <label for="Lbl_Mobile" class="col-sm-2 col-form-label">Mobile:</label>
                                <div class="col-sm-4">
                                    <asp:Label ID="Lbl_Mobile" runat="server"></asp:Label>
                                </div>
                            </div>

                        </div>
                    </div>
                </asp:Panel>
                <div class="row">   
<asp:HyperLink ID="HyplinkAdd" CssClass="col-sm-12"      NavigateUrl="~/TermDepositPlacement.aspx" Visible="false" runat="server">Create a new term deposit</asp:HyperLink>
</div>
                <asp:GridView ID="GridView_TD" runat="server" AutoGenerateColumns="False"
             CssClass="table table-striped" OnSelectedIndexChanged="GridView_TD_SelectedIndexChanged">
              
             <Columns>
                 <asp:BoundField DataField="tdAccount" HeaderText="Account" />
                 <asp:BoundField DataField="tdPrincipal" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:C2}"
                     HeaderText="Principal">
                 </asp:BoundField>
                 <asp:BoundField DataField="tdTerm" HeaderText="Term" DataFormatString="{0:n0} mth" />
                 <asp:BoundField DataField="tdEffDte" DataFormatString="{0:d}" HeaderText="Value Date" HeaderStyle-CssClass="hidden-sm hidden-xs" ItemStyle-CssClass="hidden-sm hidden-xs"  />
                 <asp:BoundField DataField="tdMaturityDte" DataFormatString="{0:d}" HeaderText="Maturity Date" />
                 <asp:BoundField DataField="tdIntRte" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:n3}"
                     HeaderText="Interest Rate" HeaderStyle-CssClass="hidden-sm hidden-xs" 
                     ItemStyle-CssClass="hidden-sm hidden-xs" />
                
                 <asp:BoundField DataField="tdMaturedAmt" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:C2}"
                     HeaderText="Principal + Interest">
                     <ItemStyle HorizontalAlign="Right"></ItemStyle>
                 </asp:BoundField>
                 <asp:BoundField DataField="tdRenewMode" ItemStyle-HorizontalAlign="Center" DataFormatString="{0:n0}"
                     HeaderText="Renew mode" >

                     <ItemStyle HorizontalAlign="Center"></ItemStyle>
                 </asp:BoundField>
                 <asp:CommandField HeaderText="Change renewal mode" ShowHeader="True" ShowSelectButton="True" ItemStyle-CssClass="hidden-sm hidden-xs" HeaderStyle-CssClass="hidden-sm hidden-xs" />

             </Columns>
         </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>
