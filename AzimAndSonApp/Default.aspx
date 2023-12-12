﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AzimAndSonApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        $(document).ready(function () {
            var maxlen = 15;
            $('#First_Name_Txt').keypress(function (k) {
                if ($(this).val().length >= maxlen) {
                    k.preventdefault();
                    alert('Character should be between 3 to 15 characters');
                }
            });
        });
    </script>
    <div>
        <div style="font-size:x-large" align="center">
            <br />
            <span style="color: #000000; font-family: 'Segoe UI Variable Text Semibold'; background-color: #9999FF"><strong>User Registration Form</strong></span><br />
            <br />
        </div>
        <table class="nav-justified" style="width: 90%; margin-left: 191px">
            <tr>
                <td class="modal-lg" style="width: 313px; height: 25px; color: #3366FF;"><strong>User ID :</strong></td>
                <td style="height: 25px">
                    <asp:TextBox ID="User_ID_Txt" runat="server" Font-Size="Medium" Width="226px"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">* 
                    <asp:RequiredFieldValidator ID="User_ID_RequiredFieldValidator" runat="server" ControlToValidate="User_ID_Txt" ErrorMessage="Please Enter User ID" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
&nbsp;</span>&nbsp;
                    <asp:Button ID="Get_Button" runat="server" BackColor="#9933FF" BorderColor="#999999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Get_Button_Click" Text="Get" Width="87px" />
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; color: #3366FF;"><strong>First Name :</strong></td>
                <td>
                    <asp:TextBox ID="First_Name_Txt" runat="server" Font-Size="Medium" Width="226px"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">* </span>
                    <asp:RequiredFieldValidator ID="First_Name_RequiredFieldValidator" runat="server" ControlToValidate="First_Name_Txt" ErrorMessage="Please Enter First Name" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; height: 20px; color: #3366FF;"><strong>Last Name :</strong></td>
                <td style="height: 20px">
                    <asp:TextBox ID="Last_Name_Txt" runat="server" Font-Size="Medium" Width="226px" style="margin-left: 0"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">* </span>
                    <asp:RequiredFieldValidator ID="last_Name_RequiredFieldValidator" runat="server" ControlToValidate="Last_Name_Txt" ErrorMessage="Please Enter Last Name" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; height: 24px; color: #3366FF;"><strong>E<span style="color: #0066FF">mail :</span></strong></td>
                <td style="height: 24px">
                    <asp:TextBox ID="Email_Txt" runat="server" Font-Size="Medium" Width="226px"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">* </span>
                    <asp:RequiredFieldValidator ID="Email_RequiredFieldValidator" runat="server" ControlToValidate="Email_Txt" ErrorMessage="Please Enter Email" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
&nbsp;
                    <asp:RegularExpressionValidator ID="Email_RegularExpressionValidator" runat="server" ErrorMessage="Email is not correct format" Font-Bold="True" Font-Size="Large" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email_Txt" SetFocusOnError="True"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; color: #3366FF; height: 30px;"><strong>Password :</strong></td>
                <td style="height: 30px">
                    <asp:TextBox ID="Password_Txt" runat="server" Font-Size="Medium" Width="226px"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">*&nbsp;</span>
                    <asp:RequiredFieldValidator ID="Password_RequiredFieldValidator" runat="server" ControlToValidate="Password_Txt" ErrorMessage="Please Enter Password" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; color: #3366FF;"><strong>Confirm Password :</strong></td>
                <td>
                    <asp:TextBox ID="Confirm_Password_Txt" runat="server" Font-Size="Medium" Width="226px"></asp:TextBox>
                &nbsp; <span style="color: #FF0000; font-family: Arial; font-size: x-large">* </span>
                    <asp:RequiredFieldValidator ID="Confirm_Password_RequiredFieldValidator" runat="server" ControlToValidate="Confirm_Password_Txt" ErrorMessage="Please Enter Confirm Password" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationGroup="insert"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px; height: 20px;"></td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px">&nbsp;</td>
                <td>
                    <asp:Button ID="Insert_Button" runat="server" BackColor="#9933FF" BorderColor="#999999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Insert_Button_Click" Text="Insert" Width="87px" ValidationGroup="insert" />
&nbsp;
                    <asp:Button ID="Update_Button" runat="server" BackColor="#9933FF" BorderColor="#999999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Update_Button_Click" Text="Update" Width="87px" />
&nbsp;
                    <asp:Button ID="Delete_Button" runat="server" BackColor="#9933FF" BorderColor="#999999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Delete_Button_Click" OnClientClick="return confirm('Are you sure to delete?');" Text="Delete" Width="87px" />
&nbsp;
                    <asp:Button ID="Search_Button" runat="server" BackColor="#9933FF" BorderColor="#999999" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="Search_Button_Click" Text="Search" Width="87px" />
                </td>
            </tr>
            <tr>
                <td class="modal-lg" style="width: 313px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" BackColor="#9999FF" BorderColor="#6600FF" BorderStyle="Solid" ForeColor="Black" style="margin-left: 0px" Width="1141px" HorizontalAlign="Center">
                        <HeaderStyle BackColor="#990099" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <br />
    </div>
    </asp:Content>
