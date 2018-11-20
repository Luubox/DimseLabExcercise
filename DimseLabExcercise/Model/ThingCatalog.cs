using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ThingCatalog
    {
        private static ThingCatalog _instance = new ThingCatalog();

        public static ThingCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Thing> Things { get; set; }

        public ThingCatalog()
        {
            Things = new ObservableCollection<Thing>();

            Things.Add(new Thing("Raspberry Pi", new List<string>(){"Halløjsa", "noget andet", "æblemos", "keyword", "telefonboks", "burde have en dictionary til det her.keyword" }));
            Things.Add(new Thing("Arduino Nano", new List<string>(){"Halløjsa", "noget andet", "æblemos", "keyword", "telefonboks", "burde have en dictionary til det her.keyword" }));
            Things.Add(new Thing("3D Printer", new List<string>(){"Halløjsa", "noget andet", "æblemos", "keyword", "telefonboks", "burde have en dictionary til det her.keyword" }));
        }

        public void Add(string name, DateTime lendOutDate, DateTime handInDate, List<string> keywords)
        {
            Things.Add(new Thing(name, keywords));
        }
    }
}
