using DataLayer.DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BusinessLayer
{
    public class FilmHandler
    {
        /// <summary>
        /// Vrátí filmy podle názvu
        /// </summary>
        /// <param name="nazev"></param>
        /// <returns></returns>
        public static Collection<FilmBO> Select(String nazev)
        {
            Collection<FilmDTO> filmy = FilmDAO.Select(nazev);
            Collection<FilmBO> ret = new Collection<FilmBO>();
            foreach (var film in filmy)
            {
                ret.Add(new FilmBO(film));
            }
            return ret;
        }
        /// <summary>
        /// Vrátí kolekci všech filmů
        /// </summary>
        /// <returns></returns>
        public static Collection<FilmBO> SelectAll()
        {
            Collection<FilmDTO> filmy = FilmDAO.SelectAll();
            Collection<FilmBO> ret = new Collection<FilmBO>();
            foreach (var film in filmy)
            {
                ret.Add(new FilmBO(film));
            }
            return ret;
        }
        /// <summary>
        /// Inkrementuje zhlédnutí danému filmu
        /// </summary>
        /// <param name="filmid"></param>
        /// <returns></returns>
        public static void Update(int id)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            FilmDAO.Update(id);
        }
        /// <summary>
        /// Aktualizuje základní informace o filmu
        /// </summary>
        /// <param name="film"></param>
        /// <returns></returns>
        public static void UpdateInfo(FilmBO film)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            FilmDAO.UpdateINFO(film.ToDTO());
        }
        /// <summary>
        /// Vrátí film s konkrétním ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static FilmBO SelectID(int id)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            FilmBO ret = new FilmBO(FilmDAO.SelectID(id));
            return ret;
        }
        /// <summary>
        /// Vyhledá film podle účinkujících a žánru
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="zanr"></param>
        /// <returns></returns>
        public static Collection<FilmBO> SelectDetailed(String[] jmeno, String[] prijmeni, String zanr)
        {
            Collection<FilmDTO> filmy = FilmDAO.SelectDetailed(jmeno, prijmeni, zanr);
            Collection<FilmBO> ret = new Collection<FilmBO>();
            foreach (var film in filmy)
            {
                ret.Add(new FilmBO(film));
            }
            return ret;
        }
    }
}
