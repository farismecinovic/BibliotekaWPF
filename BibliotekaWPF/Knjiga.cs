using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaWPF
{
    public class Knjiga
    {
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public int BrojPrimeraka { get; set; }

        public ObservableCollection<Knjiga> Knjige = new ObservableCollection<Knjiga>();
    }
}
