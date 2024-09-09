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
        public string Godina { get; set; }
        public int Trajanje { get; set; }
        public string Redatelj {  get; set; }
        public decimal Ocjena { get; set; }
        public int BrojKopija {  get; set; }
        public bool Dostupan { get; set; }
    }
}
