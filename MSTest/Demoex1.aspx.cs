using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MSTest
{
    public partial class Demoex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLClass1 BL = new BLClass1();
            try
            {
                txtresult.Text =(BL.Divide (txtnumerator.Text , txtdenominator.Text).ToString());
            }
            catch(DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
            catch(FormatException E)
            {
                Response.Write(E.Message);
            }
           
        }
    }
}