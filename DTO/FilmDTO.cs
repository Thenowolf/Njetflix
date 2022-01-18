using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DTO
{
    public class FilmDTO
    {
        public int id { get; set; }
        public String nazev { get; set; }
        public int rok { get; set; }
        public String zanr { get; set; }
        public String popis { get; set; }
        public bool zamek { get; set; }
        public int zhlednuto { get; set; }
        public List<UcinkujiciDTO> ucinkujici {get; set;}
    }
}
