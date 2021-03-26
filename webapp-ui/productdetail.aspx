<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="productdetail.aspx.cs" Inherits="webapp_ui.productdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="assets/css/product_styles.css" rel="stylesheet" />
    <link href="assets/css/product_responsive.css" rel="stylesheet" />
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Single Product -->
	<div class="single_product">
		<div class="container">
			<div class="row">
					<!-- Images -->
					<div class="col-lg-2 order-lg-1 order-2" id="imglist" runat="server">
					</div>
					<!-- Selected Image -->
					<div class="col-lg-5 order-lg-2 order-1">
						<div class="image_selected" id="imgselect" runat="server"></div>
				    </div>
			        <!-- Description -->
					<div class="col-lg-5 order-3">
					<div class="product_description">
                        <div id="descrptid" runat="server">

                        </div>
						<div class="order_info d-flex flex-row">
								<div class="clearfix" style="z-index: 1000;">
									<div class="container">
										<div class="row">
											<div class="col-md-12">
													<div class="input-group mb-3" style="max-width: 120px;">
														<div class="input-group-prepend">
														  <button  class="btn btn-outline-primary js-btn-minus" style="border-color:rgb(252, 95, 69)!important;color:rgb(252, 95, 69)!important;background:transparent!important;" onmouseover="this.style.background='#333333';this.style.color:white;this.style.border:none" onmouseout="this.style.background='transparent'" onclick="decrease()" type="button">&minus;</button>
														</div>
														<input type="text" id="quantity_input"  class="form-control text-center" value="1" aria-label="Example text with button addon" aria-describedby="button-addon1" runat="server">
														<div class="input-group-append">
														  <button  class="btn btn-outline-primary js-btn-plus" style="border-color:rgb(252, 95, 69)!important;color:rgb(252, 95, 69)!important;background:transparent!important;"  onmouseover="this.style.background='#333333';this.style.color:white;this.style.border:none"  onmouseout="this.style.background='transparent'" onclick="increase()" type="button">&plus;</button>
														</div>
													</div>
											</div>
											<div class="col-md-12" id="price" runat="server">
												
											</div>
										</div>
										<div class="row">
											<div class="col-md-12">
												<div class="button_container">
                                                    <asp:Button text="Add to Cart" class="upload_btn" style="margin-top:12px; border:none; color: #fff; background-color:#fc5f45;" onMouseOver="this.style.background='#333333'" onMouseOut="this.style.background='#fc5f45'" OnClick="addtocart" runat="server"/>
												</div>
											</div>
										</div>
									</div>
								</div>
						</div>
					</div>
				</div>
			</div>
		<script type="text/javascript" src="assets/js/quantity.js"></script>
		</div>
</asp:Content>
