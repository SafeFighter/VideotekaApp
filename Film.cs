using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaApp
{
    public class Film
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Zanr { get; set; }
        public int Godina { get; set; }
        public bool Dostupan { get; set; }
    }
}
