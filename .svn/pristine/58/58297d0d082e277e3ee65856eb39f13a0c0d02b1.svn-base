<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="DeshExpressPortal.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <%--   <link href="CSS/bootstrap.css" rel="stylesheet" />--%>
    <%--  <link href="CSS/bootstrapV3_2013.css" rel="stylesheet" />--%>
    <link href="CSS/buttons.css" rel="stylesheet" />
    <link href="CSS/home_style.css" rel="stylesheet" />
    <link href="CSS/bootstrap2_3_2.css" rel="stylesheet" />
    <style type="text/css">
        .navbar-inner {
            margin-top: 20px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <%--  <div id="header">
            <div id="headerContainer">
                <div class="row">
                    <div class="span9">
                        <h2><b id="sli">Sonali Life Insurance Company Limited</b></h2>
                    </div>

                    <div class="span3">
                        <h5>
                            <asp:Label ID="lblTopdate" CssClass="TopdateCSS" runat="server"></asp:Label>
                        </h5>

                    </div>

                    <div class="span3">
                        <div id="userContainer">

                            <table id="topBarUserTable">
                                <tr>
                                    <td>
                                        <div id="userIcon">
                                            <img id="userIconImage" src="Images/icons/user.png" />
                                        </div>
                                    </td>
                                    <td>

                                        <span><i>welcome</i>
                                            <asp:LoginName ID="LoginName" runat="server" CssClass="username" />
                                            &nbsp;|&nbsp;
                                        </span>

          
                                    </td>
                                    <td>
                                        <asp:LoginStatus ID="LoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Logout" LogoutPageUrl="~/" />
                                      
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
        <div class="navbar navbar-inverse navbar-fixed-top" style="margin-top: -20px;">
            <div class="navbar-inner">
                <div class="container-fluid">
                    <%-- <asp:Button ID="Button1" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse" runat="server" Text="Button">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </asp:Button>--%>
                    <%--  <input type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse"> </input>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    --%>
                    <button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <%--<a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </a>--%>
                    <ul class="nav">
                        <h3 class="sonaliH3">
                            <img id="Img1" style="height: 60px; width: auto" src="img/icon/logo.png" />
                            <%--<span>Desh Express</span>--%>
                        </h3>
                    </ul>
                    <div class="nav-collapse collapse">
                        <ul class="nav">

                            <span class="time">
                                <asp:Label ID="lblTopdate" runat="server"></asp:Label></span>

                        </ul>

                        <ul class="navbar-text pull-right">
                            <div class="userContainer">
                                <table class="topBarUserTable">
                                    <tr>
                                        <td>
                                            <div id="userIcon">
                                                <img id="userIconImage" src="img/icon/user.png" />
                                            </div>
                                        </td>
                                        <td>
                                            <span><i>welcome</i>
                                                <asp:LoginName ID="LoginName" runat="server" />
                                                &nbsp;|&nbsp;
                                            </span>
                                        </td>
                                        <td>
                                            <asp:LoginStatus ID="LoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Logout" LogoutPageUrl="~/" OnLoggedOut="LoginStatus_LoggedOut" />
                                             &nbsp;&nbsp; 

                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ul>
                    </div>

                </div>
            </div>
        </div>

        <div id="logo">
            <img id="logoImg" src="img/icon/logo.png" style="padding-top: 50%"/>
        </div>
        <div class="clear-fix"></div>

        <div id="home_body">
            <!--start of home body -->

            <div class="row">
                <!--row 1 -->
              <%--  <div class="span2">
                    <div class="btn_custom" id="policyBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=1">
                                <img class="icons" src="img/icon/policy.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Policy</h4>
                    </div>
                    <div class="custom_divider">
                    </div>

                </div>--%>

              
                <div class="span2">
                    <div class="btn_custom" id="approvalBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=13">
                                <img class="icons" src="img/icon/approvalIcon.png" /></a>
                        </div>
                        <%--<div class="circle">1</div>--%>
                        <asp:Label ID="lbCircleNotification" runat="server" Text=" "></asp:Label>
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Approval</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>
                 <div class="span2">
                    <div class="btn_custom" id="UtilitiesBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=10">
                                <img class="icons" src="img/icon/Utilities_icon.png" /></a>
                        </div>
                        
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Utilities</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>
                
                 <div class="clearfix"></div>
                

               <%-- <div class="span2">
                    <div class="btn_custom" id="accountsBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=3">
                                <img class="icons" src="img/icon/accounts.png" /></a>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Accounts</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="HRBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=4">
                                <img class="icons" src="img/icon/HR.png" />
                            </a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">HR</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="agentBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=5">
                                <img class="icons" src="img/icon/agents.png" /></a>
                        </div>
                        
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Agency</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="PaymentBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=6">
                                <img class="icons" src="img/icon/payments.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Payments</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="AgentComBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=7">
                                <img class="icons" src="img/icon/agentCom.png" /></a>
                        </div>
                        
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Commission</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>


                <div class="span2">
                    <div class="btn_custom" id="MisBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=8">
                                <img class="icons" src="img/icon/mis.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">MiS</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>
               

                <div class="span2">
                    <div class="btn_custom" id="polScheduleBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=9">
                                <img class="icons" src="img/icon/policySchedule_icon.png" /></a>
                        </div>
                      
                        <asp:Label ID="lblPolServ" runat="server" Text=" "></asp:Label>
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Policy Services</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="claimBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=11">
                                <img class="icons" src="img/icon/claimIcon.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Claims</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="chatBtn">
                        <div class="boxIcon">
                            <a target="_blank" href="../Utilities/ChatRoomUI.aspx">
                                <img class="icons" src="img/icon/chatIcon.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Chat Room</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="assetManagementBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=14">
                                <img class="icons" src="img/icon/assetManagementIcon.png" /></a>
                        </div>
                        
                        <asp:Label ID="lblExpNotification" runat="server" Text=" "></asp:Label>
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Asset Management</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="reInsuranceBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=15">
                                <img class="icons" src="img/icon/reInsurrance_icon.png" /></a>
                        </div>
                       
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Reinsurance</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>


               <div class="span2">
                    <div class="btn_custom" id="expenses">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=16">
                                <img class="icons" src="img/icon/expensesIcon.png" /></a>
                        </div>
                        
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Expenses</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>--%>
                <div class="clearfix"></div>

              <%--  <div class="span2">
                    <div class="btn_custom" id="userActBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=17">
                                <img class="icons" src="img/icon/userActivityIcon.png" /></a>
                        </div>
                        <asp:Label ID="lbUserNotification" runat="server" Text=""></asp:Label>
                   
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">User Activity</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="grpPolBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=18">
                                <img class="icons" src="img/icon/groupIcon.png" /></a>
                        </div>
                    
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Group Policy</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="invShareBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=19">
                                <img class="icons" src="img/icon/investmentShare.png" /></a>
                        </div>
                   
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Investment</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="cardMgBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=20">
                                <img class="icons" src="img/icon/AttendanceIcon.png" /></a>
                        </div>
                   
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Attendance</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="maturityClaimBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=21">
                                <img class="icons" src="img/icon/maturityIcon.png" /></a>
                        </div>
                   
                        <asp:Label ID="lblMatClaim" runat="server" Text=" "></asp:Label>
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Maturity Claim</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="PageAccessBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=22">
                                <img class="icons" src="img/icon/PageAccesIicon.png" /></a>
                        </div>
                  
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Page Access</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="TrainingBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=23">
                                <img class="icons" src="img/icon/Training_icon.png" /></a>
                        </div>
                  
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Training</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>

                <div class="span2">
                    <div class="btn_custom" id="LoanBtn">
                        <div class="boxIcon">
                            <a href="SiteMasterEntrypage.aspx?q=24">
                                <img class="icons" src="img/icon/loanIcon.png" /></a>
                        </div>
                   
                    </div>
                    <div class="capDiv">
                        <h4 class="caption">Loan</h4>
                    </div>
                    <div class="custom_divider"></div>
                </div>--%>

            </div>
            <!-- end of row -->

        </div>
        <!-- end of home body -->






        <div id="footer">
            <%-- <div id="frameContainer" style="overflow: hidden; width: 300px; height: 45px;  margin-top: -40px;">
             <iframe src="../Utilities/ChatContain.aspx" scrolling=no style="width: 300px; height: 60px;margin-left:0px; margin-top: -16px; padding-left: 0px;border-left-width: 0px; border-right-width: 0px;"></iframe>
               </div>--%>
            <asp:Label ID="lbchat" runat="server" Text="  "></asp:Label>
            <pre> Desh Express. 		&copy; DITCL, Dragon Information Technology and Communication Limited, 2016.</pre>            
            <script src="/JS/jquery.js"></script>
            <script src="/JS/buttons.js"></script>
        </div>


        <%-- <script type="text/javascript" src="js/jquery.js"></script>
        <script type="text/javascript" src="js/buttons.js"></script>--%>
    </form>

</body>
</html>
