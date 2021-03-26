<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="webapp_ui.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<nav  class="d-none d-lg-block navbar navbar-expand navbar-light bg-light" style="font-size: 120%;color:darkorange">
			<div class="nav1" id="Div1" style="margin-left:2% !important;" runat="server">
				<div class="nav">

				</div>
			</div>
		</nav>
	
               <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
				<div class="carousel-inner">
				<div class="carousel-item active">
				  <img class="d-block w-100" src="assets/images/razerbg.jpg" alt="First slide">
					<div class="carousel-caption text-center">
							<h3>
								<span>Almost everyone in college need a laptop we have the best deals</span>
							</h3>
					</div>
				</div>
			  </div>
	</div> 
	
	
	
		<div class="container-fluid">			
		   <div class="row">
			    <div class="col-xl-12 col-lg-12">
					<div class="section3125 mt-50">
						<h4 style="color:dimgrey; text-align:center;font-size: 23px;";">Recommendations</h4>	
						<div class="product_grid">
							<div class="product_grid_border"></div>

							<div class="col-md-12">
								<div class="_14d25">
								<div class="row" id="carid" runat="server">
								
								</div>				
							</div>				
							</div>	

						</div>
					</div>	
				</div>
			    <div class="col-xl-12 col-lg-12">
				     <div class="trends">
							<div class="trends_background" style="background-image:url(assets/images/trends_background.jpg)"></div>
							<div class="trends_overlay"></div>
							<div class="container">
								<div class="row">

									<div class="bottom-sub-grid-content py-lg-5 py-3">
					<div class="row">
						<div class="col-lg-4 bottom-sub-grid text-center">
							<div class="bt-icon" style="font-size:60px;">

								<span class="far fa-hand-paper"></span>
							</div>

							<h4 class="sub-tittle-w3layouts my-lg-4 my-3">Satisfaction Guaranteed</h4>
							<p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.</p>
						</div>
						<!-- /.col-lg-4 -->
						<div class="col-lg-4 bottom-sub-grid text-center">
							<div class="bt-icon"  style="font-size:60px;">
								<span class="fas fa-rocket"></span>
							</div>

							<h4 class="sub-tittle-w3layouts my-lg-4 my-3">Fast Shipping</h4>
							<p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.</p>
						</div>
						<!-- /.col-lg-4 -->
						<div class="col-lg-4 bottom-sub-grid text-center">
							<div class="bt-icon"  style="font-size:60px;">
								<span class="far fa-sun"></span>
							</div>

							<h4 class="sub-tittle-w3layouts my-lg-4 my-3">Return Back</h4>
							<p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.</p>
						</div>
						<!-- /.col-lg-4 -->
					</div>
				</div>

								</div>
							</div>
						</div>
               </div>
			   <!--
			     <div class="col-xl-12 col-lg-12">
					<div class="section3125 mt-50">
						<h4 class="item_title"><a href="" style="color:#333">Explore popular categories</a></h4>	
						<div class="la5lo1">
							<div class="row" id="catid" runat="server">
							</div>
						</div>
					</div>	
				</div>
			   
			   <div class="col-xl-12 col-lg-12">
				   <div class="adverts">
		<div class="container">
			
			<div class="row">
				<div class="owl-carousel featured_courses owl-theme">
					
									<div class="item">
										<div class="advert_col">
											<div class="advert d-flex flex-row align-items-center">
												<div class="advert_content">
													<div class="advert_title"><a href="#">University of Capetown</a></div>
													<div class="advert_text">Lorem ipsum dolor sit amet, consectetur adipiscing Donec et.</div>
												</div>
											<div class="ml-auto"><div class="advert_image"><img src="assets/images/adv_1.png" alt=""></div></div>
											</div>
										</div>
									</div>
									<div class="item">
										<div class="advert_col">
											<div class="advert d-flex flex-row align-items-center">
												<div class="advert_content">
													<div class="advert_title"><a href="#">University of Johannesburg</a></div>
													<div class="advert_text">Lorem ipsum dolor sit amet, consectetur adipiscing Donec et.</div>
												</div>
													<div class="ml-auto"><div class="advert_image"><img src="assets/images/adv_2.jpg"  alt=""></div></div>
										    </div>
										</div>
									</div>
									<div class="item">
										<div class="advert_col">
                                           <div class="advert d-flex flex-row align-items-center">
												<div class="advert_content">
													<div class="advert_title"><a href="#">Wits University</a></div>
													<div class="advert_text">Lorem ipsum dolor sit amet, consectetur adipiscing Donec et.</div>
												</div>
												<div class="ml-auto"><div class="advert_image"><img src="assets/images/adv_3.png" alt=""></div></div>
											</div>
										</div>
									</div>
									<div class="item">
										<div class="advert_col">	
											<div class="advert d-flex flex-row align-items-center">
												<div class="advert_content">
													<div class="advert_title"><a href="#">University of Pretoria</a></div>
													<div class="advert_text">Lorem ipsum dolor sit amet, consectetur adipiscing Donec et.</div>
												</div>
												<div class="ml-auto"><div class="advert_image"><img src="assets/images/adv_4.jpg" alt=""></div></div>
											</div>
										</div>
								</div>
						</div>
					</div>
				</div>
			   </div>   
			   </div>
		   </div>
				-->
	  </div>
	
    </form>
</asp:Content>

