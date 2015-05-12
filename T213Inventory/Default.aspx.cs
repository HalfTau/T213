using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Web;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    public void btnSearch_onClick(Object sender, EventArgs e)
    {
        Response.BufferOutput = true;
        Response.Redirect("Search.aspx?query=" + TextBox1.Text);
    }
}