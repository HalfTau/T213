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

    public void btnWrite_onClick(Object sender, EventArgs e)
    {
        string ConStr = "";  
        //getting the path of the file     
        string path = Server.MapPath("Book2.xlsx");  
        //connection string for that file which extantion is .xlsx    
        ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";  
        //making query    
        string query = "INSERT INTO [Sheet1$] ([Name]) VALUES('" + TextBox1.Text + "')";  
        //Providing connection    
        OleDbConnection conn = new OleDbConnection(ConStr);  
        //checking that connection state is closed or not if closed the     
        //open the connection    
        if (conn.State == ConnectionState.Closed)  
        {  
            conn.Open();  
        }  
        //create command object    
        OleDbCommand cmd = new OleDbCommand(query, conn);  
        int result = cmd.ExecuteNonQuery();  
        if (result > 0)  
        {  
            Response.Write("<script>alert('Sucessfully Data Inserted Into Excel')</script>");  
        }  
        else  
        {  
            Response.Write("<script>alert('Sorry!\n Insertion Failed')</script>");  
        }  
        conn.Close();  
          
    }

    public void btnSearch_onClick(Object sender, EventArgs e)
    {
        //Response.BufferOutput = true;
        //Response.Redirect("Search.aspx?query=" + TextBox1.Text);
        Label2.Text = TextBox1.Text;
    }
}