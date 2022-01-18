using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class HodnoceniDTO
    {
        public int? id { get; set; }
        public int hodnoceni { get; set; }
        public String komentar { get; set; }
        public int uzivatelID { get; set; }
        public int filmID { get; set; }
    }
}
