<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-07-2016
   File Description: This is the nav bar when user is not logged in
    
    --%>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavbarNonSecure.ascx.cs" Inherits="EnterpriseComputingTeamProject1.User_Controls.NavbarNonSecure" %>
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Default.aspx">
                <i class="fa fa-fort-awesome fa-lg"></i> Game Tracker</a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">

            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a href="Default.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>
                <li id="games" runat="server"><a href="Games.aspx"><i class="fa fa-trophy fa-lg"></i> Games</a></li>
                <li id="teams" runat="server"><a href="Teams.aspx"><i class="fa fa-futbol-o fa-lg"></i> Teams</a></li>
                <li id="login" runat="server"><a href="Login.aspx"><i class="fa fa-phone fa-lg"></i> Log In</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>