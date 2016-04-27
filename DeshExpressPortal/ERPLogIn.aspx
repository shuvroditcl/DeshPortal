<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ERPLogIn.aspx.cs" Inherits="DeshExpressPortal.ERPLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="google-site-verification" content="i1cJwNs32U9WjDXwI8rl-R1q8F7Iw_FUKlg_Z1kDkxA" />
    <meta name="author" content="" />

    <title>Sign-In </title>

    <link href="CSS/bootstrapV3_2013.css" rel="stylesheet" />

    <link href="CSS/signin.css" rel="stylesheet" />
</head>
<body>

    <div id="bg"></div>

    <div id="userbox">

        <form id="Form1" class="form-signin" runat="server">
            <div class="sonaliSigninImgDiv">
                <img class="sonaliSigninImg" src="img/icon/logo.png" />
            </div>
            <%--<h2 class="sonaliH2">IMPREIAL STUDIO INC</h2>--%>
            <h4 class="form-signin-heading" style="color:#FFE290">Please sign in</h4>

            <asp:TextBox ID="txtusername" class="form-control" placeholder="Username" x-moz-errormessage="User Name Required" required runat="server"></asp:TextBox>
            <asp:TextBox ID="txtuserpass" TextMode="Password" class="form-control" placeholder="Password" x-moz-errormessage="Password Required" required runat="server"></asp:TextBox>
            <label class="checkbox" style="color:#FFE290">
                <asp:CheckBox ID="chkRememberMe" runat="server" />
                Remember me
            </label>
            <asp:Button ID="btnSingIn" runat="server" class="btn btn-lg btn-warning btn-block" Text="Sign-In" OnClick="btnSingIn_Click" />
        </form>

    </div>
    <div class="modal-custom-footer">
        <p style="text-align: center;">Desh Express <span class="footerIndent">&copy; DITCL, Dragon Information Technology and Communication Limited, 2016.</span></p>
    </div>


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
</body>
</html>
