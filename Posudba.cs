using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotekaApp
{

    public class Posudba
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public int FilmId { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public DateTime? DatumVracanja { get; set; }

    }
}
