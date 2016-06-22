<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-07-2016
   File Description: This is the date input form for game and team statistics 
    
    --%>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InputForm.aspx.cs" Inherits="EnterpriseComputingTeamProject1.InputForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Game Details</h1>
                <asp:ValidationSummary runat=server HeaderText="There were Errors on the page:" ForeColor="Red"/>
                <h5>All Fields are Required</h5>
                <br />
                <%-- Drop Down List for Week Selection--%>
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

                <div class="form-group">
                    <label class="control-label" for="LastNameTextBox">Game Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameNameTextBox" placeholder="Game Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameDescriptionTextBox">Short Description</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameDescriptionTextBox" placeholder="Game Description" required="true"></asp:TextBox>
                </div>

                <%-- Drop Down List for Team 1 Selection--%>
                <div class="form-group">
                    <label for="Team1DropDownList">Team 1 Name: </label>
                    <asp:DropDownList ID="Team1DropDownList" runat="server" CssClass="btn btn-default bt-sm dropdown-toggle">
                        <asp:ListItem Text="Baltimore Orioles" Value="100000" />
                        <asp:ListItem Text="Boston Red Sox" Value="100001" />
                        <asp:ListItem Text="Chicago White Sox" Value="100002" />
                        <asp:ListItem Text="Cleveland Indians" Value="100003" />
                        <asp:ListItem Text="Detroit Tigers" Value="100004" />
                        <asp:ListItem Text="Houston Astros" Value="100005" />
                        <asp:ListItem Text="Kansas City Royals" Value="100006" />
                        <asp:ListItem Text="Los Angeles Angels" Value="100007" />
                    </asp:DropDownList>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="Team1ScoreTextBox">Team 1 Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team1ScoreTextBox" placeholder="Team 1 Score" required="true"></asp:TextBox>
                </div>
                <asp:RangeValidator ID="Team1ScoreRangeValidator" ControlToValidate="Team1ScoreTextBox" Type="Integer" MinimumValue="0" MaximumValue="100" runat="server" ErrorMessage="Team 1 Socre Needs To Be An Integer (0 - 100)" ForeColor="White" BackColor="Red"></asp:RangeValidator>

                <%-- Drop Down List for Week Selection--%>
                <div class="form-group">
                    <label for="Team2DropDownList" >Team 2 Name: </label>
                    <asp:DropDownList ID="Team2DropDownList" runat="server" CssClass="btn btn-default bt-sm dropdown-toggle">
                        <asp:ListItem Text="Boston Red Sox" Value="100001" />
                        <asp:ListItem Text="Baltimore Orioles" Value="100000" />
                        <asp:ListItem Text="Chicago White Sox" Value="100002" />
                        <asp:ListItem Text="Cleveland Indians" Value="100003" />
                        <asp:ListItem Text="Detroit Tigers" Value="100004" />
                        <asp:ListItem Text="Houston Astros" Value="100005" />
                        <asp:ListItem Text="Kansas City Royals" Value="100006" />
                        <asp:ListItem Text="Los Angeles Angels" Value="100007" />
                    </asp:DropDownList>
                </div>              
                <asp:CompareValidator runat="server" ID="compareTeamNames" ErrorMessage="A Team CANNOT Play Against Itself" ControlToValidate="Team2DropDownList" ControlToCompare="Team1DropDownList" Operator="NotEqual" Display="Dynamic" BackColor="Red" ForeColor="White" />
                
                <div class="form-group">
                    <label class="control-label" for="Team2ScoreTextBox" >Team 2 Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Team2ScoreTextBox" placeholder="Team 2 Score" required="true"></asp:TextBox>
                </div>
                <asp:RangeValidator ID="Team2ScoreRangeValidator" ControlToValidate="Team2ScoreTextBox" Type="Integer" MinimumValue="0" MaximumValue="100" runat="server" ErrorMessage="Team 2 Score Needs To Be An Integer (0 - 100)" ForeColor="White" BackColor="Red"></asp:RangeValidator>

                <div class="form-group">
                    <label class="control-label" for="NumberOfSpectatorsTextBox">Number Of Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="NumberOfSpectatorsTextBox" placeholder="Number Of Spectators" required="true"></asp:TextBox>
                </div>
                <asp:RangeValidator ID="NumberOfSpectatorsRangeValidator" ControlToValidate="NumberOfSpectatorsTextBox" Type="Integer" MinimumValue="0" MaximumValue="200000" runat="server" ErrorMessage="Number of Spectators Needs To Be An Integer (0 - 200,000)" BackColor="Red" ForeColor="White"></asp:RangeValidator>

                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" Onclick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

