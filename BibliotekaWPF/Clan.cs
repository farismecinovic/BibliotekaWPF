using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaWPF
{
    public class Clan
    {
        public string BrojClanske { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set;}
        public DateTime ZadnjaClanarina { get; set; } = DateTime.Now;

        public ObservableCollection<Clan> Clanovi = new ObservableCollection<Clan>();

    }

   
}
