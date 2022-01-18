using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLayer.DAO;
using DTO;

namespace BusinessLayer
{
    public class UcinkujiciHandler
    {
        /// <summary>
        /// Vloží nového účinkujícího do DB
        /// </summary>
        /// <param name="ucinkujici"></param>
        /// <returns></returns>
        public static void Insert(UcinkujiciBO ucinkujici)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            UcinkujiciDAO.Insert(ucinkujici.ToDTO());
        }
        /// <summary>
        /// Vytvoří propojení mezi účinkujícím a filmem
        /// </summary>
        /// <param name="film_id"></param>
        /// <param name="ucinkujici_id"></param>
        /// <returns></returns>
        public static void InsertDependency(int film_id, int ucinkujici_id)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            UcinkujiciDAO.InsertDependency(film_id, ucinkujici_id);
        }
        /// <summary>
        /// Vrací účinkujícího podle jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <returns></returns>
        public static UcinkujiciBO Select(String jmeno, String prijmeni)
        {
            //FilmDTO filmy = FilmDAO.SelectID(id);
            UcinkujiciBO ret = new UcinkujiciBO(UcinkujiciDAO.Select(jmeno, prijmeni));
            return ret;
        }
        /// <summary>
        /// Vrací kolekci účinkujících podle ID filmu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Collection<UcinkujiciBO> SelectCOL(int id)
        {
            Collection<UcinkujiciDTO> ucinkujiciDTO = UcinkujiciDAO.SelectCOL(id);
            Collection<UcinkujiciBO> ret = new Collection<UcinkujiciBO>();
            foreach (var ucinkujici in ucinkujiciDTO)
            {
                ret.Add(new UcinkujiciBO(ucinkujici));
            }
            return ret;
        }

    }
}
