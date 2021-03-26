<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="sortcategory.aspx.cs" Inherits="webapp_ui.sortcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="assets/css/category_responsive.css" rel="stylesheet">
		<link href="assets/css/category_styles.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		<div class="home">
			<div class="home_background parallax-window" data-parallax="scroll" data-image-src="assets/images/shop_background.jpg">
                <img src="assets/images/shop_background.jpg" alt="Alternate Text" />
			</div>
			<div class="home_overlay"></div>
			<div class="home_content d-flex flex-column align-items-center justify-content-center" id="title" runat="server">
			</div>
		</div>
		<div class="shop">
		<div class="container">
			<div class="row">
				<div class="col-lg-3">
					<div class="shop_sidebar">
						<div class="sidebar_section">
							<div class="sidebar_title" id="div2" runat="server">Categories</div>
						</div>
						<div class="sidebar_section">
							<div class="sidebar_subtitle brands_subtitle">other categories</div>
							<ul class="brands_list" id="div3" runat="server">
								
							</ul>
						</div>
					</div>
				</div>
				<div class="col-lg-9">
					<div class="shop_content">
						<div class="shop_bar clearfix">
							<div class="shop_product_count" id="prodcount" runat="server"></div>
							<div class="shop_sorting">
								<span>Sort by:</span>
								<ul>
									<li>
										<span class="sorting_text">select sorting option<i class="fas fa-chevron-down"></span></i>
										<ul>
											<li class="shop_sorting_button" data-isotope-option='{ "sortBy": "original-order" }'><a href="sortcategory.aspx?id=1">High-Low price</a></li>
											<li class="shop_sorting_button" data-isotope-option='{ "sortBy": "name" }'><a href="sortcategory.aspx?id=2">Low-High price</a></li>
										</ul>
									</li>
								</ul>
							</div>
						</div>

						<div class="product_grid">
							<div class="product_grid_border"></div>

							<div class="col-md-12">
								<div class="_14d25">
								<div class="row" id="Divv1" runat="server">
								
								</div>				
							</div>				
							</div>	

						</div>
					</div>

				</div>
			</div>
		</div>
	</div>
</asp:Content>
