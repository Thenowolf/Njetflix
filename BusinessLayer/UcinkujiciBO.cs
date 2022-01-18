using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class UcinkujiciBO
    {
        public int id { get; set; }
        public String jmeno { get; set; }
        public String prijmeni { get; set; }
        public String role { get; set; }

        public UcinkujiciBO(UcinkujiciDTO ucinkujici)
        {
            id = ucinkujici.id;
            jmeno = ucinkujici.jmeno;
            prijmeni = ucinkujici.prijmeni;
            role = ucinkujici.role;
        }

        public UcinkujiciBO()
        {
        }
        /// <summary>
        /// Převod to DTO
        /// </summary>
        /// <returns></returns>
        public UcinkujiciDTO ToDTO()
        {
            UcinkujiciDTO uzivatel = new UcinkujiciDTO()
            {
                id = id,
                jmeno = jmeno,
                prijmeni = prijmeni,
                role = role
            };
            return uzivatel;
        }

      /*  public static void CreateNew(UcinkujiciBO ucinkujici, int film_id, String herciText, String reziserText)
        {
            if (herciText != "")
            {
                for (int i = 0; i < FilmBO.ConvertNames(herciText.Text).Length; i++)
                {
                    //UcinkujiciBO ucinkujici = new UcinkujiciBO();
                    if (UcinkujiciHandler.Select(FilmBO.ConvertNames(herciText.Text)[i], FilmBO.ConvertSurnames(herciText.Text)[i]).id == 0)
                    {
                        label2.Visible = true;
                        ucinkujici = new UcinkujiciBO { jmeno = FilmBO.ConvertNames(herciText.Text)[i], prijmeni = FilmBO.ConvertSurnames(herciText.Text)[i], role = "herec" };
                        label2.Text = "Zadaný účinkující " + ucinkujici.jmeno + " " + ucinkujici.prijmeni + " neexistuje, bude proto vytvořen.";
                        UcinkujiciHandler.Insert(ucinkujici);
                        ucinkujici = UcinkujiciHandler.Select(ucinkujici.jmeno, ucinkujici.prijmeni);
                        UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                    }
                    else
                    {
                        ucinkujici = UcinkujiciHandler.Select(FilmBO.ConvertNames(herciText.Text)[i], FilmBO.ConvertSurnames(herciText.Text)[i]);
                        UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                    }
                }
            }
            if (reziserText.Text != "")
            {
                if (UcinkujiciHandler.Select(FilmBO.ConvertNames(reziserText.Text)[0], FilmBO.ConvertSurnames(reziser.Text)[0]).id == 0)
                {
                    label2.Visible = true;
                    ucinkujici = new UcinkujiciBO { jmeno = FilmBO.ConvertNames(reziserText.Text)[0], prijmeni = FilmBO.ConvertSurnames(reziserText.Text)[0], role = "reziser" };
                    label2.Text = "Zadaný režisér " + ucinkujici.jmeno + " " + ucinkujici.prijmeni + " neexistuje, bude proto vytvořen.";
                    UcinkujiciHandler.Insert(ucinkujici);
                    ucinkujici = UcinkujiciHandler.Select(ucinkujici.jmeno, ucinkujici.prijmeni);
                    UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                }
                else
                {
                    ucinkujici = UcinkujiciHandler.Select(FilmBO.ConvertNames(reziserText.Text)[0], FilmBO.ConvertSurnames(reziserText.Text)[0]);
                    UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                }
            } 
        } */
    }
}
