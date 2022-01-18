using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace WebUI
{
    public partial class Search : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(TextBox1.Text == "")
            {
                TextBox2.Visible = false;
                DropDownList1.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "")
            {
                TextBox2.Visible = true;
                DropDownList1.Visible = true;
                //Label1.Text = FilmHandler.SelectDetailed(FilmBO.ConvertNames(TextBox2.Text), FilmBO.ConvertSurnames(TextBox2.Text), DropDownList1.SelectedValue).Count.ToString();
                GridView1.DataSource = FilmHandler.SelectDetailed(FilmBO.ConvertNames(TextBox2.Text), FilmBO.ConvertSurnames(TextBox2.Text), DropDownList1.SelectedValue);

                GridView1.DataBind();
            }
            else
            {
                TextBox2.Visible = false;
                DropDownList1.Visible = false;
                GridView1.DataSource = FilmHandler.Select(TextBox1.Text);
                GridView1.DataBind();
                if (TextBox1.Text == "")
                {
                    TextBox2.Visible = true;
                    DropDownList1.Visible = true;
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox2.Visible = true;
            //DropDownList1.Visible = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            FilmHandler.Update(Convert.ToInt32(row.Cells[1].Text.Trim()));
            Response.Redirect("Filmdetail.aspx?id=" + Convert.ToInt32(row.Cells[1].Text.Trim()));
           //FilmHandler.Update(Convert.ToInt32(row.Cells[1].Text.Trim()));
        }
    }
}