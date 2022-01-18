using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.DAO;

namespace BusinessLayer
{
    public class HodnoceniHandler
    {
        /// <summary>
        /// Vkládá záznam hodnocení do DB
        /// </summary>
        /// <param name="hodnoceni"></param>
        /// <returns></returns>
        public static int Insert(HodnoceniBO hodnoceni)
        {
            return HodnoceniDAO.Insert(hodnoceni.ToDTO());
        }
    }
}
