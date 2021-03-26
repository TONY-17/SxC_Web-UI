 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editprod.aspx.cs" Inherits="webapp_ui.editprod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, shrink-to-fit=9">	
		<title>Edit Product</title>
		
		<!-- Favicon Icon -->
		<link rel="icon" type="image/png" href="assets/images/logo.png" />
		
		<!-- Stylesheets -->
		<link href='http://fonts.googleapis.com/css?family=Roboto:400,700,500' rel='stylesheet'>
		<link href='asssets/vendor/unicons-2.0.1/css/unicons.css' rel='stylesheet'>
		<link href="assets/css/vertical-responsive-menu1.min.css" rel="stylesheet">
		<link href="assets/css/instructor-dashboard.css" rel="stylesheet">
		<link href="assets/css/instructor-responsive.css" rel="stylesheet">
		<link href="assets/css/night-mode.css" rel="stylesheet">
		
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
		
</head>
<body>
        	<!-- Header Start -->
		<header class="header clearfix">
			<div class="main_logo" id="logo">
				<a href="Index.aspx"><img src="assets/images/logo.png" height="60px" alt=""></a>
			</div>
			<div class="header_right">
				<ul>
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
					</li>
					<li class="ui dropdown">

						<div class="menu dropdown_account" id="AuthenUser" runat="server">
														
						</div>
					</li>
				</ul>
			</div>
		</header>
		<!-- Left Sidebar Start -->
		<nav class="vertical_nav">
			<div class="left_section menu_left" id="js-menu" >
				<div class="left_section">
					<ul>
						<li class="menu--item">
							<a href="dashboard.aspx" class="menu--link" title="dashboard">
								<i class='uil uil-analysis menu--icon'></i>
								<span class="menu--label">Dashboard</span>
							</a>
						</li>
						<li class="menu--item">
							<a href="createdProducts.aspx" class="menu--link active" title="Products">
								<i class='uil uil-book-alt menu--icon'></i>
								<span class="menu--label">Products</span>
							</a>
						</li>
						<li class="menu--item">
							<a href="createProducts.aspx" class="menu--link" title="Create Products">
								<i class='uil uil-plus-circle menu--icon'></i>
								<span class="menu--label">Create Products</span>
							</a>
						</li>
						<li class="menu--item">
							<a href="profile.aspx" class="menu--link" title="Profile">
								<i class='uil uil-comments menu--icon'></i>
								<span class="menu--label">My Profile</span>
							</a>
						</li>
						<li class="menu--item">
							<a href="createdProducts.aspx" class="menu--link" title="Reviews">
							  <i class='uil uil-star menu--icon'></i>
							  <span class="menu--label">Reviews</span>
							</a>
						</li>
						<li class="menu--item">
							<a href="invoices.aspx" class="menu--link" title="Invoices">
							  <i class='uil uil-file-alt menu--icon'></i>
							  <span class="menu--label">Invoice</span>
							</a>
						</li>
					</ul>
				</div>
			</div>
		</nav>
		<!-- Left Sidebar End -->
		<!-- Body Start -->
		<form  runat="server">
			<div class="wrapper">
			<div class="sa4d25">
				<div class="container">						
					<div class="row">
						<div class="col-12">
							<div class="course_tabs_1">
								<div id="add-course-tab" class="step-app">
									<div class="step-content">
										<div class="step-tab-panel step-tab-info active" id="tab_step1"> 
											<div class="tab-from-content">
												<div class="title-icon">
													<h3 class="title"><i class="uil uil-info-circle"></i>Edit Product</h3>
												</div>
											</div>
										</div>
										<div class="step-tab-panel step-tab-gallery" id="tab_step2">
											<div class="tab-from-content">
												<div class="course__form">
													<div class="view_info10">
														<div class="row">
															<div class="col-lg-12">	
																<div class="view_all_dt">	
																	<div class="view_img_left">	
																		<div class="view__img">	
																			<asp:Image ID="Image1" runat="server"/>
																		</div>
																	</div>
																	<div class="view_img_right">	
																		<h4>Cover Image</h4>
																		<p>Upload your product image here. It must meet our course image quality standards to be accepted. Important guidelines: .jpg, .jpeg,. gif, or .png. no text on the image.</p>
																		<div class="upload__input">
																			<div class="input-group">
																				<div class="col-md-8">
																					<div class="custom-file">
																						<asp:FileUpload ID="FileUpload1" runat="server"/>
																					</div>
																				</div>
																			</div>
																		</div>
																	</div>
																</div>
																<div class="view_all_dt">	
																	<div class="general_info10">
																		<div class="row">
																			 <div class="col-lg-4 col-md-4">
																				<div class="card" style="width: 20rem; margin:25px;">
																					<asp:Image class="card-img-top" ID="Image2" runat="server"/>
																					<div class="card-body">
																					  <asp:FileUpload ID="FileUpload2" runat="server" />	 
																					</div>
																				</div>	
																			 </div> 
																			 <div class="col-lg-4 col-md-4">
																				<div class="card" style="width: 20rem; margin:25px;">
																					  <asp:Image class="card-img-top" ID="Image3" runat="server"/>																					
																					<div class="card-body">
																					  <asp:FileUpload ID="FileUpload3" runat="server" />
																					</div>
																				</div>	
																			 </div> 
																			 <div class="col-lg-4 col-md-4">
																				<div class="card" style="width: 20rem; margin:25px;">
																				    <asp:Image class="card-img-top" ID="Image4" runat="server" />																					
																					<div class="card-body">
																					  <asp:FileUpload ID="FileUpload4" runat="server" />
																					</div>
																				</div>	
																			 </div> 
																			<div class="col-lg-12 col-md-12">
																				<div class="save_content">
																					<asp:Button  class="upload_btn" title="create  products" style="width: 250px; margin-top:12px; color: #fff; background-color:#fc5f45;" onMouseOver="this.style.background='#333333'" onMouseOut="this.style.background='#fc5f45'" ID="Button1" Text="Upload" runat="server" OnClick="UploadFile" />
																				</div>
																			</div>
																		</div>
																	</div>
																</div>
															</div>
															
															<div class="col-lg-12">
																<div class="view_info10">
																	<div class="row">
																		<div class="col-lg-12 col-md-12">															
																			<div class="ui search focus mt-30 lbel25">
																				<label>Product Name*</label>
																				<div class="ui left icon input swdh19">
																					 <input type="text" class="form-control" id="inputName" placeholder="Enter Product Name" runat="server" />
																				</div>
																			</div>									
																		</div>
																		<div class="col-lg-12 col-md-12">	
																			<div class="lecture_title">
																				<h4>Add Product Details</h4>
																			</div>
																		</div>
																		<div class="col-lg-6 col-md-6">															
																			<div class="ui search focus mt-30 lbel25">
																				<label>Category*</label>
																				<div class="ui left icon input swdh19">
																					<asp:DropDownList ID="CategoryDropDownList" class="form-control" runat="server">
																					</asp:DropDownList>
																				</div>
																			</div>									
																		</div>
																		<div class="col-lg-6 col-md-6">
																			<div class="part_input mt-30 lbel25">
																				<label>Price*</label>
																				<div class="input-group">
																				  <input type="number" class="form-control" id="price" aria-label="Dollar amount (with dot and two decimal places)" runat="server"/>
																				  <div class="input-group-append">
																					<span class="input-group-text">ZAR</span>
																				  </div>
																				</div>
																			</div>
																		</div>
																		<div class="col-lg-12 col-md-12">	
																			<div class="course_des_textarea mt-30 lbel25">
																				<label>Description*</label>
																				<div class="course_des_bg">
																					<div class="textarea_dt">															
																						<div class="ui form swdh339">
																							<div class="field">
																								<textarea rows="5" name="description" id="id_part_description" placeholder="Insert your product description" runat="server"></textarea>
																							</div>
																						</div>										
																					</div>
																				</div>
																			</div>
																		</div>
																		<div class="col-lg-6 col-md-6">															
																			<div class="ui search focus mt-30 lbel25">
																				<label>Status*</label>
																				<div class="ui left icon input swdh19">
																					<asp:DropDownList ID="StatusDropDownList" class="form-control" runat="server">
																					</asp:DropDownList>
																				</div>
																			</div>									
																		</div>
																		<div class="col-lg-12 col-md-12">
																			<div class="save_content">
                                                                                <asp:Button class="upload_btn" style="width: 250px; margin-top:12px; color: #fff; background-color:#fc5f45;" onMouseOver="this.style.background='#333333'" onMouseOut="this.style.background='#fc5f45'" Text="Update Product" OnClick="EditProduct"
																				runat="server" />
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
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		</form>	
			<footer class="footer mt-40">
				<div class="container-fluid">
					<div class="row">					
						<div class="col-lg-12">
							<div class="item_f1">
								<a href="terms_of_use.html">Copyright Policy</a>
								<a href="terms_of_use.html">Terms</a>
								<a href="terms_of_use.html">Privacy Policy</a>
							</div>
						</div>
						<div class="col-lg-12">
							<div class="footer_bottm">
								<div class="row">
									<div class="col-md-6">
										<ul class="fotb_left">
											<li>
												<a href="index.html">
													<div class="footer_logo">
														<img src="images/logo1.svg" alt="">
													</div>
												</a>
											</li>
											<li>
												<p>© 2020 <strong>Cursus</strong>. All Rights Reserved.</p>
											</li>
										</ul>
									</div>
									<div class="col-md-6">
										<div class="edu_social_links">
											<a href="#"><i class="fab fa-facebook-f"></i></a>
											<a href="#"><i class="fab fa-twitter"></i></a>
											<a href="#"><i class="fab fa-google-plus-g"></i></a>
											<a href="#"><i class="fab fa-linkedin-in"></i></a>
											<a href="#"><i class="fab fa-instagram"></i></a>
											<a href="#"><i class="fab fa-youtube"></i></a>
											<a href="#"><i class="fab fa-pinterest-p"></i></a>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</footer>
		</div>
		<!-- Body End -->

	<script src="assets/js/vertical-responsive-menu.min.js"></script>
	<script src="assets/js/jquery-3.3.1.min.js"></script>
	<script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
	<script src="assets/vendor/OwlCarousel/owl.carousel.js"></script>
	<script src="assets/vendor/semantic/semantic.min.js"></script>
	<script src="assets/js/custom1.js"></script>
</body>
</html>
