using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class inv : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string userid = Request.QueryString["id"];
            int uid = Convert.ToInt32(userid);
            StringBuilder sb = new StringBuilder();
            sb.Append("<header class='clearfix'>");
            sb.Append("<h1>INVOICE</h1>");
            sb.Append("<div id='company' class='clearfix'>");
            sb.Append("<div>StudentXchange</div>");
            sb.Append("<div>AUCKLAND PARK,<br />RSA</div>");
            sb.Append("<div>(011) 519-0450</div>");
            sb.Append("<div><a href='mailto:studentxchange@outlook.com'>studentxchange@outlook.com</a></div>");
            sb.Append("</div>");
            sb.Append("<div id='project'>");
            sb.Append("<div><span>CLIENT</span> "+client.getUser(uid).Name+" "+client.getUser(uid).LastName+"</div>");
            sb.Append("<div><span>ADDRESS</span> "+client.getUserAddress(uid).Address+","+ client.getUserAddress(uid).Address2+"," + client.getUserAddress(uid).Province + "</div>");
            sb.Append("<div><span>EMAIL</span> <a href='mailto:john@example.com'>"+ client.getUser(uid).Email+ "</a></div>");
            sb.Append("<div><span>DATE</span> "+ DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "</div>");
            sb.Append("</div>");
            sb.Append("</header>");
            sb.Append("<main>");
            sb.Append("<table>");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th class='service'>Product Name</th>");
            sb.Append("<th class='desc'>DESCRIPTION</th>");
            sb.Append("<th>PRICE</th>");
            sb.Append("<th>QTY</th>");
            sb.Append("<th>TOTAL</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody>");
            sb.Append("<tr>");
            double sum = 0;
            
            
                foreach (var o in client.getOrdersUserIsBought(uid))
                {
                    
                        sb.Append("<td class='service'>" + client.getProduct(o.ProductId).Name + "</td>");
                        sb.Append("<td class='desc'>" + client.getProduct(o.ProductId).Name + "</td>");
                        sb.Append("<td class='unit'>R" + Math.Round(Convert.ToDouble(client.getProduct(o.ProductId).Price), 2) / o.Quantity + "</td>");
                        sb.Append("<td class='qty'>" + o.Quantity + "</td>");
                        sb.Append("<td class='total'>R" + Math.Round(Convert.ToDouble(client.getProduct(o.ProductId).Price), 2) + "</td>");
                        sum = sum + Convert.ToDouble(client.getProduct(o.ProductId).Price);
                    
                  
                }
            
           
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4'>SUBTOTAL</td>");
            sb.Append("<td class='total'>R"+Math.Round(sum,2)+"</td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4'>TAX 15%</td>");
            sb.Append("<td class='total'>R"+Math.Round(Convert.ToDouble(sum)*0.15,2)+"</td>");
            sb.Append("<td colspan='4'>DELIVERY FEE</td>");
            if (sum >= 1000)
            {
                sb.Append("<td class='total'>R" + 50 + "</td>");
                sum += 50;
            }
              
            if (sum < 500)
            {
                sb.Append("<td class='total'>R" + 100 + "</td>");
                sum += 100;
            }
               
            var Gtotal = (Convert.ToDouble(sum) * 0.15) + Convert.ToDouble(sum);
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4' class='grand total'>GRAND TOTAL</td>");
            sb.Append("<td class='grand total'>R"+Math.Round(Gtotal,2)+"</td>");
            sb.Append("</tr>");
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append("<div id='notices'>");
            sb.Append("<div>NOTICE:</div>");
            sb.Append("<div class='notice'>A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>");
            sb.Append("</div>");
            sb.Append("</main>");
            sb.Append("<footer>");
            sb.Append("Invoice was created on a computer and is valid without the signature and seal.");
            sb.Append("</footer>");

            StringReader sr = new StringReader(sb.ToString());

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                htmlparser.Parse(sr);
                pdfDoc.Close();

                byte[] bytes = memoryStream.ToArray();
                memoryStream.Close();

                // Clears all content output from the buffer stream                 
                Response.Clear();
                // Gets or sets the HTTP MIME type of the output stream.
                Response.ContentType = "application/pdf";
                // Adds an HTTP header to the output stream
                Response.AddHeader("Content-Disposition", "attachment; filename=Invoice.pdf");

                //Gets or sets a value indicating whether to buffer output and send it after
                // the complete response is finished processing.
                Response.Buffer = true;
                // Sets the Cache-Control header to one of the values of System.Web.HttpCacheability.
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                // Writes a string of binary characters to the HTTP output stream. it write the generated bytes .

                Response.BinaryWrite(bytes);
                // Sends all currently buffered output to the client, stops execution of the
                // page, and raises the System.Web.HttpApplication.EndRequest event.

                Response.End();
                // Closes the socket connection to a client. it is a necessary step as you must close the response after doing work.its best approach.
                Response.Close();
                //foreach (var o in client.getOrdersUserIsBought(Convert.ToInt32(Session["userid"].ToString())))
                //{
                //    client.updateOrderIsAlreadyBought(Convert.ToInt32(Session["userid"].ToString()), o.ProductId);
                //}
                Response.Redirect("change.aspx");
            }

        }
    }
}