<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-07-2016
   File Description: This is the login page
    
    --%>
<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EnterpriseComputingTeamProject1.Contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Log In</h1>
                <div class="form-group">
                    <label class="control-label" for="UsernameTextBox"> Username</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="UsernameTextBox" placeholder="Username" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="alert-danger" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Is Required" ControlToValidate="UsernameTextBox" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label class="control-label" for="PasswordTextBox">Password</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="PasswordTextBox" placeholder="Password" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="alert-danger" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Is Required" ControlToValidate="PasswordTextBox" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
                <div class="text-right">
                    <!--<asp:Button runat="server" CssClass="btn btn-warning btn-lg" ID="CancelButton" Text="Cancel" OnClick="CancelButton_Click" />-->
                    <!--<a class="btn btn-warning btn-lg" id="CancelButton" href="Default.aspx">Cancel</a>-->
                    <asp:Button runat="server" CssClass="btn btn-primary btn-lg" ID="SubmitButton" Text="Submit" OnClick="SubmitButton_Click" CausesValidation="true" />
                    <asp:Button runat="server" CssClass="btn btn-primary btn-lg" ID="RegisterButton" Text="Register" OnClick="RegisterButton_Click" CausesValidation="true" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
