<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shoppingcart.aspx.cs" Inherits="webapp_ui.shoppingcart" %>
<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, shrink-to-fit=9">
		<meta name="description" content="Groupproject">
		<meta name="author" content="Groupproject">		
		<title>Home</title>
		
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
	<style>
		  .nav{
			  position:center;
		  }
		  .nav1{
			  color:#6C757D;
		  }

			.header clearfix{
				background-color:#6C757D;
			}
			.container1{
				background-color:#6C757D;
			}
		
			.button {
			  border: none;
			  color: white;
			  padding: 13px 32px;
			  text-align: center;
			  text-decoration: none;
			  display: inline-block;
			  font-size: 16px;
			  margin: 4px 2px;
			  transition-duration: 0.4s;
			  cursor: pointer;
			}
			
			.button1 {
			  background-color: white;
			  color: black;
			  
			  border: 2px solid #6C757D;
			}

			.button1:hover {
			  background-color:  #6C757D;
			  color: white;
			}

			.button2 {
			  background-color: white;
			  color: black;
			  border: 2px solid   #6C757D;
			}

			.button2:hover {
			  background-color:  #6C757D;
			  color: white;
			}

		/* Style The Dropdown Button */
		.dropbtn {
		  background-color:  #6C757D;
		  color: white;
		  padding: 16px;
		  font-size: 16px;
		  border: none;
		  cursor: pointer;
		}

		/* The container <div> - needed to position the dropdown content */
		.dropdown {
		  position: relative;
		  display: inline-block;
		}

		/* Dropdown Content (Hidden by Default) */
		.dropdown-content {
		  display: none;
		  position: absolute;
		  background-color:  #6C757D;
		  min-width: 160px;
		  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
		  z-index: 1;
		}

		/* Links inside the dropdown */
		.dropdown-content a {
		  color: black;
		  padding: 12px 16px;
		  text-decoration: none;
		  display: block;
		}

		/* Change color of dropdown links on hover */
		.dropdown-content a:hover {background-color: #f1f1f1}

		/* Show the dropdown menu on hover */
		.dropdown:hover .dropdown-content {
		  display: block;
		}

		/* Change the background color of the dropdown button when the dropdown content is shown */
		.dropdown:hover .dropbtn {
		  background-color: #6C757D;
		}



		#myInput {
		  background-image: url('/css/searchicon.png'); /* Add a search icon to input */
		  background-position: 10px 12px; /* Position the search icon */
		  background-repeat: no-repeat; /* Do not repeat the icon image */
		  width: 100%; /* Full-width */
		  font-size: 16px; /* Increase font-size */
		  padding: 12px 20px 12px 40px; /* Add some padding */
		  border: 1px solid #ddd; /* Add a grey border */
		  margin-bottom: 12px; /* Add some space below the input */
		}

		</style>
		 <script src="Store.js" async></script>
</head>
<body>
    <form id="form1" runat="server">
       	<!-- Header Start -->
			<header class="header clearfix">
			<div class="main_logo" id="logo">
					<!--image source assets/images/logo.png-->
				<a href="Index.aspx"><img src="assets/images/logo.png" height="60px;" alt=""></a>
			</div>  
			
			<div class="search120" style="margin-left:200px !important;">
                <div class="input-group mb-1" style="width:180% !important;">
				  <input type="text" class="form-control" id="id_search" placeholder="Search for Items you looking for" aria-label="Recipient's username" aria-describedby="basic-addon2" style="height:45px!important;" runat="server">
				  <div class="input-group-append">
                      <asp:Button class="btn btn-outline-secondary" Text="Search" OnClick="search" runat="server"/>
				  </div>
				</div>
           </div>
			
			<div class="header_right">
				<ul>
					<!--
					<li>
						<a href="createProducts.aspx" class="upload_btn" title="create  products" style="margin-top:12px; color: #fff; background-color:#fc5f45;" onMouseOver="this.style.background='#333333'" onMouseOut="this.style.background='#fc5f45'">Start Selling</a>
				    </li>
					-->
					<li id="signId" runat="server">
						<a href="signin.aspx" class="button button2" style="border-radius: 0;!important;background-color:white !important">Login</a>
						<!--<a href="signin.aspx"><button class="button button1" >Login</button></a>
						<button type="button" class="option_links" style="box-shadow: rgba(0, 0, 0, 0.5) 0px 2px 4px 0px;color:darkorange">Login</button>
						<a href="SignIn.aspx" class="option_links" style="font-size: 120%;color:darkorange";>Login  |</a>-->
					</li>

					<li id="sellerId" runat="server">
						<a href="createProducts.aspx" class="button button2" style="border-radius: 0;!important;background-color:white !important">Sell</a>		
					</li>

					<li id="myAccountId" runat="server">
							<div class="dropdown">
							  <button class="dropbtn">My Account</button>
							  <div class="dropdown-content">
								<a href="dashboard.aspx">My Account</a>
								<a href="invoices.aspx">Invoices</a>
								<a href="profile.aspx">Personal Details</a>
								<a href="#">Help</a>
								<a href="signout.aspx" id="logout" runat="server">Log Out</a>
							  </div>
							</div>
						<!--<a href="" class="option_links" style="font-size: 120%;color:darkorange">My Account  |</a>-->
					</li>

					<li id="count" runat="server">
					</li>
					
					
					<!--
					<li class="ui dropdown">
						<a href="#" class="opts_account">
							<img src="assets/images/hd_dp.jpg" alt="">
						</a>
						<div class="menu dropdown_account" id="AuthenUser" runat="server">
														
						</div>
					</li>

					-->
				</ul>
			</div>



		</header>
		<!-- Header End -->
		<!-- Body Start -->
		<div class="wrapper _bg4586 _new89">
				<div class="mb4d25">
				<div class="container">			
					<div class="row">
					<form method='post' name='test' action='/shoppingcart.aspx'>
						<div class="col-lg-8" id="carttid" runat="server">
							
						</div>
					</form>
						<div class="col-lg-4">
							<div class="membership_chk_bg rght1528">
									<div class="order_dt_section">
										<div class="order_title" id="ordertotal" runat="server">
										
										</div>
										<div class="coupon_code">
											<div class="coupon_input">
												<div class="ui search focus mt-15" style="margin-bottom: 20px;">
													<div class="ui left icon input swdh11 swdh19">
														<input class="prompt srch_explore" type="text" name="couponcode" value="" id="id_coupon_code"  maxlength="6" placeholder="Enter Coupon Code" runat="server">
													</div>
												</div>
											</div>
                                            <asp:Panel ID="pnlTextBoxes" runat="server" style="display:none;">
                                            </asp:Panel>
                                            <div class="container">
                                                <div class="row">
                                                    <div class="col-lg-6">
														<asp:Button style="width:150px;color:rgb(255, 255, 255);background:rgb(252, 95, 69);border-radius:6px;padding:9px 35px;font-family:'Roboto', sans-serif;font-size:16px;font-weight:500"  OnClick="Update_Cart" Text="update cart" runat="server" />
                                                    </div>
													<div class="col-lg-6">
														 <asp:Button style="width:150px;color:rgb(255, 255, 255);background:rgb(252, 95, 69);border-radius:6px;padding:9px 35px;font-family:'Roboto', sans-serif;font-size:16px;font-weight:500" OnClick="checkout" Text="checkout" runat="server" />
                                                    </div>
                                                </div>
                                            </div>
										</div>
									</div>								
								</div>			
							</div>
						</div>
					</div>
				</div>
	     </div>
			<!--footer -->
		 <footer class="py-lg-5 py-3">
		<div class="container-fluid px-lg-5 px-3">
			<div class="row footer-top-w3layouts" style="padding-top: 25px !important;">
				<div class="col-lg-3 footer-grid-w3ls">
					<div class="footer-title">
						<h3>About Us</h3>
					</div>
					<div class="footer-text">
						<p>Curabitur non nulla sit amet nislinit tempus convallis quis ac lectus. lac inia eget consectetur sed, convallis at
							tellus. Nulla porttitor accumsana tincidunt.</p>
						<ul class="footer-social text-left mt-lg-4 mt-3">

							<li class="mx-2">
								<a href="#">
									<span class="fab fa-facebook-f"></span>
								</a>
							</li>
							<li class="mx-2">
								<a href="#">
									<span class="fab fa-twitter"></span>
								</a>
							</li>
							<li class="mx-2">
								<a href="#">
									<span class="fab fa-google-plus-g"></span>
								</a>
							</li>
							<li class="mx-2">
								<a href="#">
									<span class="fab fa-linkedin-in"></span>
								</a>
							</li>
							<li class="mx-2">
								<a href="#">
									<span class="fas fa-rss"></span>
								</a>
							</li>
							<li class="mx-2">
								<a href="#">
									<span class="fab fa-vk"></span>
								</a>
							</li>
						</ul>
					</div>
				</div>
				<div class="col-lg-3 footer-grid-w3ls">
					<div class="footer-title">
						<h3>Get in touch</h3>
					</div>
					<div class="contact-info">
						<h4>Location :</h4>
						<p>0926k 4th block building, king Avenue, New York City.</p>
						<div class="phone">
							<h4>Contact :</h4>
							<p>Phone : +121 098 8907 9987</p>
							<p>Email :
								<a href="mailto:info@example.com">info@example.com</a>
							</p>
						</div>
					</div>
				</div>
				<div class="col-lg-3 footer-grid-w3ls">
					<div class="footer-title">
						<h3>Quick Links</h3>
					</div>
					<ul class="links">
						<li>
							<a href="index.html">Home</a>
						</li>
						<li>
							<a href="about.html">About</a>
						</li>
						<li>
							<a href="404.html">Error</a>
						</li>
						<li>
							<a href="shop.html">Shop</a>
						</li>
						<li>
							<a href="contact.html">Contact Us</a>
						</li>
					</ul>
				</div>
				<div class="col-lg-3 footer-grid-w3ls">
					<div class="footer-title">
						<h3>Sign up for your offers</h3>
					</div>
					<div class="footer-text">
						<p>By subscribing to our mailing list you will always get latest news and updates from us.</p>
						<form action="#" method="post">
							<input class="form-control" type="email" name="Email" placeholder="Enter your email..." >
							<button class="btn1">
								<i class="far fa-envelope" aria-hidden="true"></i>
							</button>
							<div class="clearfix"> </div>
						</form>
					</div>
				</div>
			</div>
			<div class="copyright-w3layouts mt-4">
				<p class="copy-right text-center ">&copy; 2020 <b>studentXchange</b> . All Rights Reserved |
					<img src="assets/images/logo.png" height="50px;" alt="">
				</p>
			</div>
		</div>
	</footer>
			<!--footer -->
    </form>
		<script type="text/javascript">
			var inputDiv = document.getElementById('pnlTextBoxes');
			var count = inputDiv.getElementsByTagName('input').length;
			for (var i = 1; i <= count; i++) {
                var value = document.getElementById('quantity_input' + i).value;
				document.getElementById('p' + i).value = value;
                function increase() {
                    var value = document.getElementById('quantity_input' +i).value;
                    value = isNaN(value) ? 1 : value;
                    value++;
                    document.getElementById('p' + i).value = value;
                }

                function decrease() {
                    var value = document.getElementById('quantity_input'+i).value;
                    value = isNaN(value) ? 1 : value;
                    value--;
                    value < 1 ? value = 1 : '';
                    document.getElementById('p' + i).value = value;
                }
            }
          
        </script>
    <script src="assets/js/vertical-responsive-menu.min.js"></script>
	<script src="assets/js/jquery-3.3.1.min.js"></script>
	<script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
	<script src="assets/vendor/OwlCarousel/owl.carousel.js"></script>
	<script src="assets/vendor/semantic/semantic.min.js"></script>
	<script src="assets/js/custom.js"></script>
    <script src="assets/js/product_custom.js"></script>
</body>
</html>
