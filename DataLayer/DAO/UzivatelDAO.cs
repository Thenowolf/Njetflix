using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.DAO
{
    public class UzivatelDAO
    {
        public static String SQL_SELECT = "SELECT id, jmeno, prijmeni, email, heslo, aktivni_predplatne, spravce from UZIVATEL where email = @email and heslo = @heslo";
        /// <summary>
        /// Vrací uživatele
        /// </summary>
        /// <param name="email"></param>
        /// <param name="heslo"></param>
        /// <returns></returns>
        public static UzivatelDTO Login(string email, string heslo)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@heslo", heslo);
            SqlDataReader reader = db.Select(cmd);

            UzivatelDTO uzivatel = Read(reader);
            reader.Close();
            db.Close();
            return uzivatel;
        }
        /// <summary>
        /// Čte daza z DB, vrací jeden záznam
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static UzivatelDTO Read(SqlDataReader reader)
        {
            UzivatelDTO uzivatel = new UzivatelDTO();
            while (reader.Read())
            {
                /*if (!reader.IsDBNull(++i))
                {
                    avgrating = reader.GetInt32(i);
                } */
                int i = -1;
                /*if (reader.IsDBNull(++i))
                {
                    uzivatel.id = null;
                    return uzivatel;
                }
                else*/
                {
                    uzivatel.id = reader.GetInt32(++i);
                    uzivatel.jmeno = reader.GetString(++i);
                    uzivatel.prijmeni = reader.GetString(++i);
                    uzivatel.email = reader.GetString(++i);
                    uzivatel.heslo = reader.GetString(++i);
                    uzivatel.aktivni_predplatne = reader.GetBoolean(++i);
                    uzivatel.spravce = reader.GetBoolean(++i);
                }
            }
            return uzivatel;
        }
    }
}
