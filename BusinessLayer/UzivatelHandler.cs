using DataLayer.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class UzivatelHandler
    {
        /// <summary>
        /// Vrací uživatele
        /// </summary>
        /// <param name="email"></param>
        /// <param name="heslo"></param>
        /// <returns></returns>
        public static UzivatelBO Login(String email, String heslo)
        {
            UzivatelBO uzivatel = new UzivatelBO(UzivatelDAO.Login(email, heslo));
            return uzivatel;
        }
    }
}
