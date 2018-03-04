using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.HtmlControls;
using davidsp8.common.Security.Saml20;

namespace davidsp8.web.PostSamlAssertion {
    public partial class SSO : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            var postAction = "http://localhost/WebServiceProvider/SamlValidate";
            var binFolderPath = Server.MapPath("bin");
            
            // Set Relay State
            RelayState.Value = "http://localhost/WebServiceProvider";

            // Set Attrs
            Dictionary<string, string> attrs = new Dictionary<string, string>();
            attrs.Add("email", Session["email"].ToString());
            attrs.Add("firstname", Session["firstname"].ToString());
            attrs.Add("lastname", Session["lastname"].ToString());

            // Set SAML Response
            SAMLResponse.Value =
                SamlHelper.GetPostSamlResponse(
                    postAction, 
                    "LoanDepot.com:sp",
                    "LoanDepot.com", 
                    "localUseridToMapBack",
                    StoreLocation.LocalMachine, 
                    StoreName.Root, 
                    X509FindType.FindByThumbprint,
                    Path.Combine(binFolderPath, "modotech-test-cert.pfx"),
                    "123456789",
                    "", 
                    attrs);

            //Set Form Action
            this.frmSSO.Action = postAction;
            
            // Add OnLoad Logic so that form will be submitted.
            HtmlGenericControl body = (HtmlGenericControl)this.Page.FindControl("bodySSO");
            if (body != null) {
                body.Attributes.Add("onload", "document.forms.frmSSO.submit();");
            }
        }

        private void Original() {
            // Set Relay State
            RelayState.Value = "http://www.davidsp8.com";
            // Set Attrs
            Dictionary<string, string> attrs = new Dictionary<string, string>();
            attrs.Add("Email", Session["Email"].ToString());
            // Set SAML Response
            SAMLResponse.Value =
                SamlHelper.GetPostSamlResponse(
                    "http://www.davidsp8.com/SSO.asmx",
                    "davidsp8.com:sp",
                    "davidsp8.com",
                    "localuserid",
                    StoreLocation.LocalMachine, StoreName.Root, X509FindType.FindByThumbprint, null, null,
                    "41fe9204effd0d8c5e65a1de3a507da1383fd14f", attrs);

            //Set Form Action
            this.frmSSO.Action = "http://www.davidsp8.com/SSO.asmx";

            // Add OnLoad Logic so that form will be submitted.
            HtmlGenericControl body = (HtmlGenericControl)this.Page.FindControl("bodySSO");
            if (body != null)
            {
                body.Attributes.Add("onload", "document.forms.frmSSO.submit();");
            }
        }
    }
}
