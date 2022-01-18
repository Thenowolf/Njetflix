using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using DTO;

namespace DataLayer.DAO
{
    public class UcinkujiciDAO
    {
        public static String SQL_SELECT = "SELECT id, jmeno, prijmeni, role from UCINKUJICI where jmeno = @jmeno and prijmeni = @prijmeni" ;
        public static String SQL_INSERT = "INSERT INTO UCINKUJICI(jmeno, prijmeni, role) " + "VALUES(@jmeno, @prijmeni, @role)";
        public static String SQL_INSERT_DEPENDENCY = "INSERT INTO UCINKUJICI_FILM(film_id, ucinkujici_id) " + "VALUES(@film_id, @ucinkujici_id)";
        public static String SQL_SELECT_COL = "SELECT ucinkujici.id, jmeno, prijmeni, role FROM ucinkujici JOIN ucinkujici_film uf on ucinkujici.id = uf.ucinkujici_id JOIN film f on uf.film_id = f.id where film_id = @id";

        /// <summary>
        /// Vrací účinkujícího podle jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <returns></returns>
        public static UcinkujiciDTO Select(String jmeno, String prijmeni)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT);
            cmd.Parameters.AddWithValue("@jmeno", jmeno);
            cmd.Parameters.AddWithValue("@prijmeni", prijmeni);
            SqlDataReader reader = db.Select(cmd);

            UcinkujiciDTO ucinkujici = ReadSingle(reader);
            reader.Close();
            db.Close();
            return ucinkujici;
        }
        /// <summary>
        /// Vrací kolekci účinkujících podle ID filmu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Collection<UcinkujiciDTO> SelectCOL(int id)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT_COL);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = db.Select(cmd);

            Collection<UcinkujiciDTO> ucinkujici = Read(reader);
            reader.Close();
            db.Close();
            return ucinkujici;
        }
        /// <summary>
        /// Vloží nového účinkujícího do DB
        /// </summary>
        /// <param name="ucinkujici"></param>
        /// <returns></returns>
        public static int Insert(UcinkujiciDTO ucinkujici)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, ucinkujici);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }
        /// <summary>
        /// Vytvoří propojení mezi účinkujícím a filmem
        /// </summary>
        /// <param name="film_id"></param>
        /// <param name="ucinkujici_id"></param>
        /// <returns></returns>
        public static int InsertDependency(int film_id, int ucinkujici_id)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT_DEPENDENCY);
            command.Parameters.AddWithValue("@film_id", film_id);
            command.Parameters.AddWithValue("@ucinkujici_id", ucinkujici_id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }
        /// <summary>
        /// Přiřazení proměn
        /// </summary>
        /// <param name="command"></param>
        /// <param name="ucinkujici"></param>
        private static void PrepareCommand(SqlCommand command, UcinkujiciDTO ucinkujici)
        {
            command.Parameters.AddWithValue("@jmeno", ucinkujici.jmeno);
            command.Parameters.AddWithValue("@prijmeni", ucinkujici.prijmeni);
            command.Parameters.AddWithValue("@role", ucinkujici.role);
        }
        /// <summary>
        /// Čte data z DB, vrací kolekci
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Collection<UcinkujiciDTO> Read(SqlDataReader reader)
        {
            Collection<UcinkujiciDTO> ucinkujicicol = new Collection<UcinkujiciDTO>();
            while (reader.Read())
            {
                UcinkujiciDTO ucinkujici = new UcinkujiciDTO();

                int i = -1;
                ucinkujici.id = reader.GetInt32(++i);
                ucinkujici.jmeno = reader.GetString(++i);
                ucinkujici.prijmeni = reader.GetString(++i);
                ucinkujici.role = reader.GetString(++i);

                ucinkujicicol.Add(ucinkujici);
            }
            return ucinkujicicol;
        }
        /// <summary>
        /// Čte data z DB, vrací jeden záznam
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static UcinkujiciDTO ReadSingle(SqlDataReader reader)
        {
            UcinkujiciDTO ucinkujici = new UcinkujiciDTO();
            while (reader.Read())
            {
                int i = -1;
                ucinkujici.id = reader.GetInt32(++i);
                ucinkujici.jmeno = reader.GetString(++i);
                ucinkujici.prijmeni = reader.GetString(++i);
                ucinkujici.role = reader.GetString(++i);

            }
            return ucinkujici;
        }
    }
}
