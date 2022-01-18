using DataLayer.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class LogsHandler
    {
        /// <summary>
        /// Ukládá objekt do JSONu
        /// </summary>
        /// <param name="log"></param>
        public static void SaveJSON(LogsBO logs)
        {
            LogsDAO.SaveJSON(logs.ToDTO());
        }
    }
}
