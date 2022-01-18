using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
namespace DataLayer.DAO
{
    public class HodnoceniDAO
    {
        public static string SqlInsert =
                            "INSERT INTO Hodnoceni(hodnoceni, komentar, uzivatel_id, film_id) " +
                            "VALUES(@hodnoceni, @komentar, @uzivatel_id, @film_id) ";
        /// <summary>
        /// Vkládá záznam hodnocení do DB
        /// </summary>
        /// <param name="hodnoceni"></param>
        /// <returns></returns>
        public static int Insert(HodnoceniDTO hodnoceni)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlInsert);
            PrepareCommand(command, hodnoceni);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }
        /// <summary>
        /// Přiřazení proměn
        /// </summary>
        /// <param name="command"></param>
        /// <param name="hodnoceni"></param>
        private static void PrepareCommand(SqlCommand command, HodnoceniDTO hodnoceni)
        {
            command.Parameters.AddWithValue("@hodnoceni", hodnoceni.hodnoceni);
            command.Parameters.AddWithValue("@komentar", hodnoceni.komentar);
            command.Parameters.AddWithValue("@uzivatel_id", hodnoceni.uzivatelID);
            command.Parameters.AddWithValue("@film_id", hodnoceni.filmID);
        }
    }
}
