using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BusinessLayer
{
    public class HodnoceniBO
    {
        public int? id { get; set; }
        public int hodnoceni { get; set; }
        public String komentar { get; set; }
        public int uzivatelID { get; set; }
        public int filmID { get; set; }

        public HodnoceniBO()
        {
        }
        public HodnoceniBO(HodnoceniDTO hodnoceni)
        {
            id = hodnoceni.id;
            this.hodnoceni = hodnoceni.hodnoceni;
            komentar = hodnoceni.komentar;
            uzivatelID = hodnoceni.uzivatelID;
            filmID = hodnoceni.filmID;
        }
        /// <summary>
        /// Převod to DTO
        /// </summary>
        /// <returns></returns>
        public HodnoceniDTO ToDTO()
        {
            HodnoceniDTO hodnoceni = new HodnoceniDTO()
            {
                id = id,
                hodnoceni = this.hodnoceni,
                komentar = komentar,
                uzivatelID = uzivatelID,
                filmID = filmID
            };
            return hodnoceni;
        }
        /// <summary>
        /// Kontroluje jestli text neobsahuje sprostá slova
        /// </summary>
        /// <param name="hodnoceniStr"></param>
        /// <returns></returns>
        public static bool InappropiateLang(String hodnoceniStr)
        {
            List<String> ForbiddenWords = new List<String>() { "kokot", "mrd", "homoš", "pič" };

            foreach (string v in ForbiddenWords)
            {
                if (hodnoceniStr.Contains(v))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
