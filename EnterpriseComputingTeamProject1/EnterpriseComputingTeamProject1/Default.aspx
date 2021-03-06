﻿<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-07-2016
   File Description: This is the Default Home Page that give users link to Games or Teams Page
    
    --%>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EnterpriseComputingTeamProject1.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <bs3:Jumbotron runat="server" ID="Jumbotron">
        <BodyContent>
            <h1>Welcome to Game Tracker!</h1>
            <br />
            <br />
            <br />
            <asp:PlaceHolder runat="server" ID="PublicMenuPlaceHolder">
                <div class="text-center">
                    <a href="GamesPublic.aspx" class="btn btn-primary btn-lg"><i class="fa fa-trophy fa-lg"></i> Game List</a>               
                </div>
            </asp:PlaceHolder>
            <asp:PlaceHolder runat="server" ID="SecureMenuPlaceHolder">
                <div class="text-center">
                    <a href="Games.aspx" class="btn btn-primary btn-lg"><i class="fa fa-trophy fa-lg"></i> Game List</a>               
                </div>
            </asp:PlaceHolder>           
            <br />
            <div class="text-center">
                <a href="Teams.aspx" class="btn btn-primary btn-lg"><i class="fa fa-futbol-o fa-lg"></i> Team List</a>               
            </div>           
        </BodyContent>
    </bs3:Jumbotron>
</asp:Content>
