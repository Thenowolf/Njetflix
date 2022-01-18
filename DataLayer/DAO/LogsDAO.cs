using DTO;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataLayer.DAO
{
    public class LogsDAO
    {
        /// <summary>
        /// Ukládá objekt do JSONu
        /// </summary>
        /// <param name="log"></param>
        public static void SaveJSON(LogsDTO log)
        {
            string url = @"C:\Users\Denis\source\repos\NjetflixFormUI\WebUI\logs.json";
            string jsonString = JsonSerializer.Serialize(log);
            jsonString = jsonString + ",";
            File.AppendAllText(url, jsonString);
        }
    }
}
