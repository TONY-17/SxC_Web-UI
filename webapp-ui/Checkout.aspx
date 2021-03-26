<%@ Page Title="" Language="C#" MasterPageFile="~/App.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="webapp_ui.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="wrapper _bg4586 _new89">		
		<div class="_215b15">
			<div class="container">
				<div class="row">
					<div class="col-lg-12">						
						<div class="title126">	
							<h2>Checkout</h2>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class="mb4d25" style="margin-top:0px">
			<div class="container">			
				<div class="row">
					<div class="col-lg-8">
						<div class="membership_chk_bg">
							<div class="checkout_title">
								<h4>Billing Details</h4>
								<img src="images/line.svg" alt="">
							</div>
							<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="false">
								<div class="panel panel-default">
									<div class="panel-heading" role="tab" id="address1">
										<div class="panel-title">
											<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseaddress1" aria-expanded="false" aria-controls="collapseaddress1">
												Edit Address
											</a>
										</div>
									</div>
									<div id="collapseaddress1" class="panel-collapse collapse" role="tabpanel" aria-labelledby="address1">
										<div class="panel-body">
											<form>
												<div class="row">
													<div class="col-lg-6">
														<div class="ui search focus mt-30 lbel25">
															<label>First Name*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="name" value="" id="id_name" required="" maxlength="64" placeholder="First Name" runat="server">															
															</div>
														</div>
													</div>
													<div class="col-lg-6">
														<div class="ui search focus mt-30 lbel25">
															<label>Last Name*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="surname" value="" id="id_surname" required="" maxlength="64" placeholder="Last Name" runat="server">															
															</div>
														</div>
													</div>										
													<div class="col-lg-12">
														<div class="ui search focus mt-30 lbel25">
															<label>Address1*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="addressname" value="" id="id_address1" required="" maxlength="300" placeholder="Address Line 1" runat="server">															
															</div>
														</div>
													</div>
													<div class="col-lg-12">
														<div class="ui search focus mt-30 lbel25">
															<label>Address2*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="addressname2"  value="" id="id_address2" required="" maxlength="300" placeholder="Address Line 2" runat="server">															
															</div>
														</div>
													</div>
													<div class="col-lg-6">
														<div class="ui search focus mt-30 lbel25">
															<label>City*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="city" value="" id="id_city" required="" maxlength="64" placeholder="City" runat="server">															
															</div>							
														</div>
													</div>
													<div class="col-lg-6">
														<div class="ui search focus mt-30 lbel25">
															<label>State / Province / Region*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="state" value="" id="id_state" required="" maxlength="64" placeholder="State / Province / Region" runat="server">															
															</div>
														</div>
													</div>
													<div class="col-lg-6">
														<div class="ui search focus mt-30 lbel25">
															<label>Zip/Postal Code*</label>
															<div class="ui left icon input swdh11 swdh19">
																<input class="form-control" type="text" name="zip" value="" id="id_zip" required="" maxlength="64" placeholder="Zip / Postal Code" runat="server">															
															</div>
														</div>
													</div>
													<div class="col-lg-6">
														
															 <asp:Button Text="Save Changes" class="upload_btn" OnClick="save_changes" style="margin-top: 46px; color: rgb(255, 255, 255); background: rgb(252, 95, 69);" onmouseover="this.style.background='#333333'" onmouseout="this.style.background='#fc5f45'" runat="server" />
														
													</div>												
												</div>
											</form>
										</div>
									</div>
								</div>
							</div>
							<div class="address_text" id="address" runat="server">
								
							</div>
						</div>							
					</div>
					<div class="col-lg-4">
						<div class="membership_chk_bg rght1528">
								<div class="checkout_title">
									<h4>Order Summary</h4>
									<img src="images/line.svg" alt="">
								</div>
								<div class="order_dt_section">
                                    <div id="orderid" runat="server">
										
                                    </div>
									<div class="scr_text"><a href="thankyou.aspx" class="upload_btn"  style="margin-top: 12px; color: rgb(255, 255, 255); background: rgb(252, 95, 69);" onmouseover="this.style.background='#333333'" onmouseout="this.style.background='#fc5f45'">confirm checkout</a></div>
								</div>
						</div>
					</div>								
				</div>				
			</div>
		</div>
	</div>

</asp:Content>
