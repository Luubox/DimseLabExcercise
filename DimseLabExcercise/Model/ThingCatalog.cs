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
        }

        public void Add(string name, DateTime lendOutDate, DateTime handInDate, List<string> keywords)
        {
            Things.Add(new Thing(name, lendOutDate, handInDate, keywords));
        }
    }
}
