
using DataLayer;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.DAO
{
    public class FilmDAO
    {
        public static String SQL_SELECT_NAME = "SELECT id, nazev, rok, zanr, zhlednuto, popis, zamek from FILM where nazev = @nazev";
        public static String SQL_SELECT_ID = "SELECT id, nazev, rok, zanr, zhlednuto, popis, zamek from FILM where id = @id";
        public static String SQL_UPDATE = "UPDATE film SET film.zhlednuto =  film.zhlednuto + 1 WHERE film.id = @id";
        public static String SQL_SELECT_ALL = "SELECT id, nazev, rok, zanr, zhlednuto, popis, zamek  from FILM";
        public static String SQL_UPDATE_INFO = "UPDATE film SET film.nazev = @nazev, film.rok = @rok, film.zanr = @zanr, film.popis = @popis, film.zamek = @zamek WHERE film.id = @id";
        //public static String SQL_SELECT_DETAILED = "SELECT film.id, nazev, rok, zanr, zhlednuto from FILM join ucinkujici_film on ucinkujici_film.film_id = film.id join ucinkujici on ucinkujici_film.ucinkujici_id = ucinkujici.id where jmeno in (" + jmeno + ") and prijmeni in (" + prijmeni + ") and zanr = @zanr";
        /// <summary>
        /// Vrátí filmy podle názvu
        /// </summary>
        /// <param name="nazev"></param>
        /// <returns></returns>
        public static Collection<FilmDTO> Select(String nazev)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT_NAME);
            cmd.Parameters.AddWithValue("@nazev", nazev);
            SqlDataReader reader = db.Select(cmd);

            Collection<FilmDTO> filmy = Read(reader);
            reader.Close();
            db.Close();
            return filmy;
        }
        /// <summary>
        /// Vrátí kolekci všech filmů
        /// </summary>
        /// <returns></returns>
        public static Collection<FilmDTO> SelectAll()
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(cmd);

            Collection<FilmDTO> filmy = Read(reader);
            reader.Close();
            db.Close();
            return filmy;
        }
        /// <summary>
        /// Inkrementuje zhlédnutí danému filmu
        /// </summary>
        /// <param name="filmid"></param>
        /// <returns></returns>
        public static int Update(int filmid)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            command.Parameters.AddWithValue("@id", filmid);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }
        /// <summary>
        /// Aktualizuje základní informace o filmu
        /// </summary>
        /// <param name="film"></param>
        /// <returns></returns>
        public static int UpdateINFO(FilmDTO film)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE_INFO);
            command.Parameters.AddWithValue("@nazev", film.nazev);
            command.Parameters.AddWithValue("@rok", film.rok);
            command.Parameters.AddWithValue("@zanr", film.zanr);
            command.Parameters.AddWithValue("@popis", film.popis);
            command.Parameters.AddWithValue("@zamek", film.zamek);
            command.Parameters.AddWithValue("@id", film.id);
            int ret = db.ExecuteNonQuery(command);

            db.Close();
            return ret;
        }
        /// <summary>
        /// Vrátí film s konkrétním ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FilmDTO SelectID(int id)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT_ID);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = db.Select(cmd);

            FilmDTO filmy = ReadSingle(reader);
            reader.Close();
            db.Close();
            return filmy;
        }
        /// <summary>
        /// Vyhledá film podle účinkujících a žánru
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="zanr"></param>
        /// <returns></returns>
        public static Collection<FilmDTO> SelectDetailed(String[] jmeno, String[] prijmeni, String zanr)
        {
            Database db = Database.GetInstance;
            db.Connect();

            SqlCommand cmd = db.CreateCommand(SQL_SELECT_NAME);
            String paramName;
            String paramSurname;
            String strAppend = "";
            String strAppend2 = "";
            //SqlCommand cmd = db.CreateCommand("SELECT film.id, nazev, rok, zanr, zhlednuto from FILM join ucinkujici_film on ucinkujici_film.film_id = film.id join ucinkujici on ucinkujici_film.ucinkujici_id = ucinkujici.id where jmeno in (" + strAppend + ") and prijmeni in (" + strAppend2 + ") and zanr = @zanr");
            int index = 1;
            foreach (String item in jmeno)
            {
                paramName = "@nameParam" + index;
                cmd.Parameters.AddWithValue(paramName, item); //Making individual parameters for every name  
                strAppend += paramName + ",";
                index += 1;
            }
            index = 1;
            foreach (String item in prijmeni)
            {
                paramSurname = "@surnameParam" + index;
                cmd.Parameters.AddWithValue(paramSurname, item); //Making individual parameters for every name  
                strAppend2 += paramSurname + ",";
                index += 1;
            }
            strAppend = strAppend.ToString().Remove(strAppend.LastIndexOf(","), 1); //Remove the last comma
            strAppend2 = strAppend2.ToString().Remove(strAppend2.LastIndexOf(","), 1);
            cmd.CommandText = "SELECT distinct film.id, nazev, rok, zanr, zhlednuto, popis from FILM join ucinkujici_film on ucinkujici_film.film_id = film.id join ucinkujici on ucinkujici_film.ucinkujici_id = ucinkujici.id where jmeno in (" + strAppend + ") and prijmeni in (" + strAppend2 + ") and zanr = @zanr";
            //string SQL_SELECT_DETAILED = "SELECT film.id, nazev, rok, zanr, zhlednuto from FILM join ucinkujici_film on ucinkujici_film.film_id = film.id join ucinkujici on ucinkujici_film.ucinkujici_id = ucinkujici.id where jmeno in (" + strAppend + ") and prijmeni in (" + strAppend2 + ") and zanr = @zanr";
            //SqlCommand cmd = db.CreateCommand(SQL_SELECT_DETAILED);
            //cmd.Parameters.AddWithValue("@jmeno", jmeno);
            //cmd.Parameters.AddWithValue("@prijmeni", prijmeni);
            cmd.Parameters.AddWithValue("@zanr", zanr);
            SqlDataReader reader = db.Select(cmd);

            Collection<FilmDTO> filmy = Read(reader);
            reader.Close();
            db.Close();
            return filmy;
        }
        /// <summary>
        /// Čte data z DB, vrací kolekci
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static Collection<FilmDTO> Read(SqlDataReader reader)
        {
            Collection<FilmDTO> filmy = new Collection<FilmDTO>();
            while(reader.Read())
            {
                FilmDTO film = new FilmDTO();

                int i = -1;
                film.id = reader.GetInt32(++i);
                film.nazev = reader.GetString(++i);
                film.rok = reader.GetInt32(++i);
                film.zanr = reader.GetString(++i);
                film.zhlednuto = reader.GetInt32(++i);
                film.popis = reader.GetString(++i);

                filmy.Add(film);
            }
            return filmy;
        }
        /// <summary>
        /// Čte data z DB, vrací jeden záznam
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static FilmDTO ReadSingle(SqlDataReader reader)
        {
           FilmDTO film = new FilmDTO();
            while (reader.Read())
            {
                int i = -1;
                film.id = reader.GetInt32(++i);
                film.nazev = reader.GetString(++i);
                film.rok = reader.GetInt32(++i);
                film.zanr = reader.GetString(++i);
                film.zhlednuto = reader.GetInt32(++i);
                film.popis = reader.GetString(++i);

            }
            return film;
        }
    }
}
