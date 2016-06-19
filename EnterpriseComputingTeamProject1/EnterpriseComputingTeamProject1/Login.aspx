﻿<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-17-2016
   File Description: This is the login page
    
    --%>
<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EnterpriseComputingTeamProject1.Contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4"> 
                <div class="alert alert-danger" id="AlertFlash" runat="server" visible="false">
                    <asp:Label runat="server" ID="StatusLabel" />
                </div>
                <h1>Log In Here</h1>
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h1 class="panel-title"><i class="fa fa-sign-in fa-lg"></i> Login</h1>
                    </div> 
                    <br />
                   <div class="panel-body">
                        <div class="form-group">
                            <label class="control-label" for="UserNameTextBox">Username:</label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" placeholder="Username" required="true" TabIndex="0"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="control-label" for="PasswordTextBox">Password:</label>
                            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true" TabIndex="0"></asp:TextBox>
                        </div>
                        <div class="text-right">
                            <asp:Button Text="Cancel" ID="CancelButton" runat="server" CssClass="btn btn-warning" OnClick="CancelButton_Click" UseSubmitBehavior="false" TabIndex="0" />
                            <asp:Button Text="Login" ID="LoginButton" runat="server" CssClass="btn btn-primary" OnClick="LoginButton_Click" TabIndex="0" />
                            <p>  Or  </p>
                            <asp:Button Text="Register" ID="RegisterButton" runat="server" CssClass="btn btn-success" OnClick="RegisterButton_Click" UseSubmitBehavior="false" TabIndex="0" />
                        </div>
                    </div>                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
