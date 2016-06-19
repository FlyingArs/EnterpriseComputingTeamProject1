<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-19-2016
   File Description: This is the PUBLIC Games Statistics Page for public users that lists Games' names, description, total score and winner
    
    --%>

<%@ Page Title="GamesPublic" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GamesPublic.aspx.cs" Inherits="EnterpriseComputingTeamProject1.GamesPublic1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offest-2 col-md-8">
                <h1>Games Stats</h1>               

                <!-- Drop Down List for Week Selection-->
                <label for="WeekDropDownList">Select Week: </label>
                <asp:DropDownList ID="WeekDropDownList" runat="server"
                    AutoPostBack="true" CssClass="btn btn-default bt-sm dropdown-toggle"
                    OnSelectedIndexChanged="WeekDropDownList_SelectedIndexChanged">
                    <asp:ListItem Text="Week 1" Value="1" />
                    <asp:ListItem Text="Week 2" Value="2" />
                    <asp:ListItem Text="Week 3" Value="3" />
                    <asp:ListItem Text="Week 4" Value="4" />
                </asp:DropDownList>

                <!-- ASP GirdView to List All the Games Stats -->
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                     ID="GamesGridView" AutoGenerateColumns="false" DataKeyNames="GameID"
                     AllowSorting="true" OnSorting="GamesGridView_Sorting" OnRowDataBound="GamesGridView_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="false" SortExpression="GameID" />
                        <asp:BoundField DataField="Week" HeaderText="Week" Visible="true" />
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" SortExpression="GameName" />
                        <asp:BoundField DataField="GameDescription" HeaderText="Description" Visible="true" SortExpression="GameDescription" />
                        <asp:BoundField DataField="NumberOfSpectators" HeaderText="Number of Spectators" Visible="true" SortExpression="NumberOfSpectators" />
                        <asp:BoundField DataField="TotalScore" HeaderText="Total Score" Visible="true" SortExpression="TotalScore" />
                        <asp:BoundField DataField="Winner" HeaderText="Winner" Visible="true" SortExpression="Winner" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
