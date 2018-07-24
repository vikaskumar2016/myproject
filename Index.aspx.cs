using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lblinsert_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["Name"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("txtname")).Text;

        SqlDataSource1.InsertParameters["Gender"].DefaultValue =
            ((DropDownList)GridView1.FooterRow.FindControl("DropDownList2")).Text;

        SqlDataSource1.InsertParameters["Salary"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("txtsalary")).Text;

        SqlDataSource1.Insert();
    }
}