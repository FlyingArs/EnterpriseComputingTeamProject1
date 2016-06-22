<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-19-2016
   File Description: This is the SECURED Games Statistics Page for logged in users that lists Games' names, description, total score, winner, Edit Link and Delete Button
    
    --%>

<%@ Page Title="Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="EnterpriseComputingTeamProject1.GamesPublic" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offest-2 col-md-8">
                <h1>Games Stats</h1>
                <a href="InputForm.aspx" class="text-right btn btn-success btn-sm"><i class="fa fa-plus"></i>Add Game</a>
                <asp:Label runat="server" ID="testlabel"></asp:Label>
                <!-- Drop Down List for Week Selection-->
                <div>
                    <label for="WeekDropDownList">Select Week: </label>
                    <asp:DropDownList ID="WeekDropDownList" runat="server"
                        AutoPostBack="true" CssClass="btn btn-default bt-sm dropdown-toggle"
                        OnSelectedIndexChanged="WeekDropDownList_SelectedIndexChanged">
                        <asp:ListItem Text="Week 1" Value="1" />
                        <asp:ListItem Text="Week 2" Value="2" />
                        <asp:ListItem Text="Week 3" Value="3" />
                        <asp:ListItem Text="Week 4" Value="4" />
                    </asp:DropDownList>
                </div>
                
                <!-- ASP GirdView to List All the Games Stats -->
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                     ID="GamesGridView" AutoGenerateColumns="false" DataKeyNames="GameID"
                     OnRowDeleting="GamesGridView_RowDeleting"
                     AllowSorting="true" OnSorting="GamesGridView_Sorting" OnRowDataBound="GamesGridView_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="false" SortExpression="GameID" />
                        <asp:BoundField DataField="Week" HeaderText="Week" Visible="true" />
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" SortExpression="GameName" />
                        <asp:BoundField DataField="GameDescription" HeaderText="Description" Visible="true" SortExpression="GameDescription" />
                        <asp:BoundField DataField="NumberOfSpectators" HeaderText="Number of Spectators" Visible="true" SortExpression="NumberOfSpectators" />
                        <asp:BoundField DataField="TotalScore" HeaderText="Total Score" Visible="true" SortExpression="TotalScore" />
                        <asp:BoundField DataField="Winner" HeaderText="Winner" Visible="true" SortExpression="Winner" />
                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit" 
                            NavigateUrl="~/InputForm.aspx" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server"
                            DataNavigateUrlFields="GameID" DataNavigateUrlFormatString="InputForm.aspx?GameID={0}" />
                        <asp:CommandField  HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
