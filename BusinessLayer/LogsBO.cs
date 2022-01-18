using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class LogsBO
    {
        public int uzivatelID { get; set; }
        public String duvod { get; set; }
        /// <summary>
        /// Převod to DTO
        /// </summary>
        /// <returns></returns>
        public LogsDTO ToDTO()
        {
            LogsDTO logs = new LogsDTO()
            {
                uzivatelID = uzivatelID,
                duvod = duvod
            };
            return logs;
        }
    }
}
