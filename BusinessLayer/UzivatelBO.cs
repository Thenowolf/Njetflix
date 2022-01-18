using DTO;
using System;

namespace BusinessLayer
{
    public class UzivatelBO
    {
        public int ?id { get; set; }
        public String jmeno { get; set; }
        public String prijmeni { get; set; }
        public String email { get; set; }
        public String heslo { get; set; }
        public bool aktivni_predplatne { get; set; }
        public bool spravce { get; set; }

        //private 
        public UzivatelBO(UzivatelDTO uzivatel)
        {
                id = uzivatel.id;
                jmeno = uzivatel.jmeno;
                prijmeni = uzivatel.prijmeni;
                email = uzivatel.email;
                heslo = uzivatel.heslo;
                aktivni_predplatne = uzivatel.aktivni_predplatne;
                spravce = uzivatel.spravce;
        }
        /// <summary>
        /// Převod to DTO
        /// </summary>
        /// <returns></returns>
        public UzivatelDTO ToDTO()
        {
            UzivatelDTO uzivatel = new UzivatelDTO()
            {
                id = id,
                jmeno = jmeno,
                prijmeni = prijmeni,
                email = email,
                heslo = heslo,
                aktivni_predplatne = aktivni_predplatne,
                spravce = spravce
            };
            return uzivatel;
        }

        /*public bool Login(String jmeno, String heslo)
        {
            uzivatel = UzivatelHandler.Login(textBox1.Text, textBox2.Text);
            if (uzivatel.id != null)
            {
                label1.Text = "Přihlášení v pořádku";
            }
            else label1.Text = "Neplatné přihlášení";
        }*/
    }
}
