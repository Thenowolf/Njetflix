using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class Filmdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FilmBO Item = FilmHandler.SelectID(Convert.ToInt32(Request.QueryString["id"]));
            nazev.Text = Item.nazev;
            popis.Text = Item.popis;
            rok.Text = Item.rok.ToString();
            zanr.Text = Item.zanr;
            vek.Text = Item.zamek.ToString();
            for (int i = 0; i < Item.ucinkujici.Count(); i++)
            {
                if (i < Item.ucinkujici.Count() - 1)
                {
                    UcinkujiciBO ele = Item.ucinkujici.ElementAt(i);
                    ucinkujici.Text = ucinkujici.Text + ele.jmeno + " " + ele.prijmeni + ",";
                }
                else
                {
                    UcinkujiciBO ele = Item.ucinkujici.ElementAt(i);
                    ucinkujici.Text = ucinkujici.Text + ele.jmeno + " " + ele.prijmeni;
                }
            }
            //filmDetail.DataSource = FilmHandler.SelectID(1);
            //filmDetail.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!HodnoceniBO.InappropiateLang(TextArea1.InnerText))
            {
                HodnoceniBO hodnoceni = new HodnoceniBO();
                hodnoceni.hodnoceni = Convert.ToInt32(DropDownList1.SelectedValue);
                hodnoceni.komentar = TextArea1.InnerText;
                hodnoceni.filmID = Convert.ToInt32(Request.QueryString["id"]);
                hodnoceni.uzivatelID = Convert.ToInt32(_Default.uzivatel.id);
                HodnoceniHandler.Insert(hodnoceni);
                upozorneni.Text = "Váš komentář byl úspěšně přidán: " + TextArea1.InnerText;
            }
            else
            {
                upozorneni.Text = "Váš komentář obsahuje nekorektní jazyk. Dodržujte naše zásady používání.";
                LogsHandler.SaveJSON(new LogsBO { duvod = "Pouziti nevhodneho jazyka v komentarich", uzivatelID = Convert.ToInt32(_Default.uzivatel.id)});
            }
        }
    }
}