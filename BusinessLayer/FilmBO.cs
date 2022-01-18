using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BusinessLayer
{
    public class FilmBO
    {
        public int id { get; set; }
        public String nazev { get; set; }
        public int rok { get; set; }
        public String zanr { get; set; }
        public String popis { get; set; }
        public bool zamek { get; set; }
        public int zhlednuto { get; set; }
        public Collection<UcinkujiciBO> ucinkujici { get; set; }

        public FilmBO()
        {
        }

        public FilmBO(FilmDTO film)
        {
            id = film.id;
            nazev = film.nazev;
            rok = film.rok;
            zanr = film.zanr;
            popis = film.popis;
            zamek = film.zamek;
            zhlednuto = film.zhlednuto;
            ucinkujici = UcinkujiciHandler.SelectCOL(id);
        }
        /// <summary>
        /// Převod to DTO
        /// </summary>
        /// <returns></returns>
        public FilmDTO ToDTO()
        {
            FilmDTO uzivatel = new FilmDTO()
            {
                id = id,
                nazev = nazev,
                rok = rok,
                zanr = zanr,
                popis = popis,
                zamek = zamek,
                zhlednuto = zhlednuto
            };
            return uzivatel;
        }
        /// <summary>
        /// Ze Stringu jmen a příjmení vrací pole jmen
        /// </summary>
        /// <param name="jmena"></param>
        /// <returns></returns>
        public static String[] ConvertNames(String jmena)
        {
            int count = 0;
            foreach (char c in jmena)
            {
                if (c == ',') count++;
            }
            String[] jmenaArray = new string[count + 1];
            //String[] prijmeni = new string[count + 1];

            for (int i = 0; i <= count; i++)
            {
                jmenaArray[i] = jmena.Split(',')[i].Split(' ')[0];
                //prijmeni[i] = textBox1.Text.Split(",")[i].Split(" ")[1];
            }
            //zanr = textBox2.Text;
            return jmenaArray;

        }
        /// <summary>
        /// Ze Stringu jmen a příjmení, vrací pole příjmení
        /// </summary>
        /// <param name="prijmeni"></param>
        /// <returns></returns>
        public static String[] ConvertSurnames(String prijmeni)
        {
            int count = 0;
            foreach (char c in prijmeni)
            {
                if (c == ',') count++;
            }
            //String[] jmenaArray = new string[count + 1];
            String[] prijmeniArray = new string[count + 1];

            for (int i = 0; i <= count; i++)
            {
                //jmenaArray[i] = textBox1.Text.Split(",")[i].Split(" ")[0];
                prijmeniArray[i] = prijmeni.Split(',')[i].Split(' ')[1];
            }
            return prijmeniArray;
        }
        /// <summary>
        /// Přijímá stringy pro změnu informací o filmu
        /// </summary>
        /// <param name="nazev"></param>
        /// <param name="rok"></param>
        /// <param name="zanr"></param>
        /// <param name="popis"></param>
        /// <param name="zamek"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FilmBO ChangeInfo(String nazev, int rok, String zanr, String popis, bool zamek, int id)
        {
            FilmBO film = new FilmBO();
            film.nazev = nazev;
            film.rok = rok;
            film.zanr = zanr;
            film.popis = popis;
            film.zamek = zamek;
            film.id = id;
            return film;
        }
    }
}
