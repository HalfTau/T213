using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load( object sender, EventArgs e )
    {
        
    }

    protected void TxtInput_TextChanged( object sender, EventArgs e )
    {
        
    }

    public void btnWrite_onClick( Object sender, EventArgs e )
    {
        //Local handle for the excel file path
        string path = Server.MapPath("Book2.xlsx");

        //String value used for opening the excel file connection
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                          path + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";

        //Canned query as a local string
        string query = "INSERT INTO [Sheet1$] ([Name]) VALUES('" + txtInput.Text + "')";

        OleDbConnection connDB = new OleDbConnection( connStr );

        if ( connDB.State == ConnectionState.Closed )
        {  connDB.Open();  }

        OleDbCommand cmdDB = new OleDbCommand( query, connDB );
        int result = cmdDB.ExecuteNonQuery();

        if ( result > 0 )
        {  Response.Write( "<script>alert('Sucessfully Data Inserted Into Excel')</script>" );  }
        else
        {  Response.Write( "<script>alert('Sorry!\n Insertion Failed')</script>" );  }

        connDB.Close();
    }

    public void btnSearch_onClick( Object sender, EventArgs e )
    {
        DataTable dt = new DataTable();

     /* string connectionString = 
        "Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\MySamplefile.xls; Extended Properties=Excel 8.0;";
 
        using( OleDbConnection Connection = new OleDbConnection(connectionString) )
        {
            Connection.Open();

            using( OleDbCommand command = new OleDbCommand() )
            { 
                command.Connection = Connection;
                command.CommandText = "SELECT * FROM [EmpTable]";

                using( OleDbDataAdapter adapter = new OleDbDataAdapter() )
                {
                    adapter.SelectCommand = command;
                    adapter.Fill( dt );
                }
            } 
        } */

        //Local handle for the excel file path
        string path = Server.MapPath( "Book2.xlsx" );

        //String value used for opening the excel file connection
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                          path + ";Extended Properties=\"Excel 12.0;ReadOnly=True;HDR=Yes;\"";

        //Canned query as a local string
        string query = "SELECT * FROM [Sheet1$]"; // ([Name]) VALUES('" + txtInput.Text + "')";

        OleDbConnection connDB = new OleDbConnection( connStr );

        if( connDB.State == ConnectionState.Closed )
        {  connDB.Open();  }

        OleDbCommand cmdDB = new OleDbCommand( query, connDB );
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        adapter.SelectCommand = cmdDB;
        int result = adapter.Fill( dt );

        //int result = cmdDB.ExecuteNonQuery();

        if( result > 0 )
        {  Response.Write( "<script>alert('Data Inserted Into Excel')</script>" );  }
        else
        {  Response.Write( "<script>alert('Sorry!\n Insertion Failed')</script>" );  }

        connDB.Close();

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}