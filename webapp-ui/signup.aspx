<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="webapp_ui.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<meta charset="utf-8">		
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, shrink-to-fit=9">
		<title>Sign-Up</title>

		<!-- Favicon Icon -->
		<link rel="icon" type="image/png" href="assets/images/logo.png">
		<!-- Stylesheets -->
		<link href='http://fonts.googleapis.com/css?family=Roboto:400,700,500' rel='stylesheet'>
		<link href='assets/vendor/unicons-2.0.1/css/unicons.css' rel='stylesheet'>
		<link href="assets/css/vertical-responsive-menu.min.css" rel="stylesheet">
		<link href="assets/css/style.css" rel="stylesheet">
		<link href="assets/css/responsive.css" rel="stylesheet">
		
		<!-- Vendor Stylesheets -->
		<link href="assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet">
		<link href="assets/vendor/OwlCarousel/assets/owl.carousel.css" rel="stylesheet">
		<link href="assets/vendor/OwlCarousel/assets/owl.theme.default.min.css" rel="stylesheet">
		<link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
		<link rel="stylesheet" type="text/css" href="assets/vendor/semantic/semantic.min.css">	
</head>
<body>
       	<!-- Signup Start -->
		<div class="sign_in_up_bg">
			<div class="container">
				<div class="row justify-content-lg-center justify-content-md-center">
					<div class="col-lg-12">
						<div class="main_logo25" id="logo">
						</div>
					</div>
			
					<div class="col-lg-6 col-md-8">
						<div class="sign_form">
							<h3>Welcome to <img src="assets/images/logo.png" width="230px" height="90px" alt="" /></h3>
							<p>Sign Up and Start <b>xchanging</b> with other students!</p>
							<form  runat="server">
								<div class="ui search focus">
									<div class="ui left icon input swdh11 swdh19">
										<input type="text" class="form-control"  name="fullname" value="" id="id_fullname" required="" maxlength="64" placeholder="Full Name" runat="server" />															
									</div>
								</div>
								<div class="ui search focus mt-15">
									<div class="ui left icon input swdh11 swdh19">
									    <input type="text" class="form-control"   name="lastname" value="" id="LastName" required="" maxlength="64" placeholder="LastName" runat="server" />															
									</div>
								</div>
								<div class="ui search focus mt-15">
									<div class="ui left icon input swdh11 swdh19">
									    <input type="email" class="form-control"   name="emailaddress" value="" id="id_email" required="" maxlength="64" placeholder="Email Address" runat="server" />															
									</div>
								</div>
								<div class="ui search focus mt-15">
									<div class="ui left icon input swdh11 swdh19">
										<input class="form-control" type="password" name="password" value="" id="id_password" required="" maxlength="64" placeholder="Password" runat="server" />															
									</div>
								</div>
                                <asp:Button class="btn btn-lg btn-block" Text="Next" style="margin-top:12px; color: #fff; background-color:#fc5f45;" onMouseOver="this.style.background='#333333'" onMouseOut="this.style.background='#fc5f45'"   type="submit" runat="server" OnClick="Register" />
							</form>
							<p class="sgntrm145">By signing up, you agree to our <a href="terms_of_use.html">Terms of Use</a> and <a href="terms_of_use.html">Privacy Policy</a>.</p>
							<p class="mb-0 mt-30">Already have an account? <a href="signin.aspx"  style="color:#fc5f45;">Log In</a></p>
						</div>
						<div class="sign_footer"><img src="assets/images/logo.png" width="100px" alt="">© 2020 <strong>studentXchange</strong>. All Rights Reserved.</div>
					</div>				
				</div>				
			</div>				
		</div>
		<!-- Signup End -->	
	<script src="assets/js/jquery-3.3.1.min.js"></script>
	<script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
	<script src="assets/vendor/OwlCarousel/owl.carousel.js"></script>
	<script src="assets/vendor/semantic/semantic.min.js"></script>
	<script src="assets/js/custom.js"></script>
</body>
</html>
