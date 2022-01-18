
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UzivatelDTO
    {
        public int ?id { get; set; }
        public String jmeno { get; set; }
        public String prijmeni { get; set; }
        public String email { get; set; }
        public String heslo { get; set; }
        public bool aktivni_predplatne { get; set; }
        public bool spravce { get; set; }

    }
}
