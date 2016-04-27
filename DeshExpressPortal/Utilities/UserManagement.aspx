<%@ Page Title="" Language="C#" MasterPageFile="~/SitePopUp.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="DeshExpressPortal.Utilities.UserManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="ContectHead">
        <asp:Label ID="Label21" runat="server" Text="User Management" CssClass="Font_header"></asp:Label>
    </div>

    <%-- <ajaxtoolkit:toolkitscriptmanager ID="ScriptManager1" runat="server" /> --%>
    <asp:Panel ID="pnlCnSButton" Visible="true" runat="server">
        <div>
            <table style="width: 100%">
                <tr>
                    <td>
                        <asp:Button ID="btn_Create" CssClass="btn btn-primary Otherbutton" runat="server" Text="Create New" OnClick="btn_Create_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    <div class="clear-fix"></div>
    <asp:Panel ID="pnlCreate" Visible="false" runat="server">
        <div>
            <table>
                <tr>
                    <td>UserName </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server"
                            TargetControlID="txtUserName" FilterType="LowercaseLetters, UppercaseLetters,Numbers,Custom" ValidChars=" " InvalidChars="'" />

                    </td>
                    <td>Password </td>
                    <td>
                        <asp:TextBox ID="txtPassword"  runat="server"></asp:TextBox><ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server"
                            TargetControlID="txtPassword" FilterType="LowercaseLetters, UppercaseLetters,Numbers,Custom" ValidChars=" " InvalidChars="'" />

                    </td>
                </tr>
               
            </table>
            <table>
                <tr>

                    <td>
                        <asp:Button ID="btnSave" Style="margin-left: 100px" CssClass="btn btn-primary Otherbutton" runat="server" Text="Save" OnClick="btnSave_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnCancelNew" CssClass="btn btn-info Otherbutton" runat="server" Text="Cancel" OnClick="btnCancelNew_Click" />
                    </td>
                </tr>
            </table>
        </div>

    </asp:Panel>
    <div class="clear-fix"></div>
    <asp:Panel ID="pnlRepeater" Visible="true" runat="server">

        <div class="Reperter_div" style="overflow: scroll; height: 450px;">
            <table class="table table-hover table-striped table-bordered datatable" aria-expanded="false">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>UserName</th>
                        <th>Password</th>
                        <th class="Cus_OptWidth">Options</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RptData" ClientIDMode="AutoID" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label ID="lbId" runat="server" Text='<%# Eval("Id") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbUserName" runat="server" Text='<%# Eval("UserName") %>' />
                                </td>
                                <td>
                                    <asp:Label ID="lbPassword" runat="server" Text='<%# Eval("Password") %>' />
                                </td>
                                <td style="padding-left: 0px; padding-right: 0px;">
                                    <asp:LinkButton ID="btnShow" runat="server" OnCommand="LinkButton_Command_Basic"
                                        CommandArgument='<%# Eval("Id") %>' CssClass="Cus_LinkBtn icon-edit" CommandName="Show" ClientIDMode="AutoID" CausesValidation="false" />


                                    <asp:LinkButton ID="btndelete" CssClass="Cus_LinkBtn icon-trash" CausesValidation="false" ClientIDMode="AutoID" OnCommand="LinkButton_btndelete" CommandArgument='<%# Eval("Id") %>'
                                        runat="server"></asp:LinkButton>
                                    <ajaxToolkit:ConfirmButtonExtender ID="cbeDelete" TargetControlID="btndelete" ConfirmText="Are you sure you want to Delete? " runat="server">
                                    </ajaxToolkit:ConfirmButtonExtender>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <table align="center">
                <tr>
                    <td align="center">
                        <asp:Label ID="lblCurrentPage" runat="server"> </asp:Label>
                        <asp:HyperLink ID="lnkPrev" ClientIDMode="AutoID" runat="server"><< Prev</asp:HyperLink>
                        <asp:HyperLink ID="lnkNext" ClientIDMode="AutoID" runat="server">Next >></asp:HyperLink>

                    </td>
                </tr>
            </table>
        </div>

    </asp:Panel>
</asp:Content>
