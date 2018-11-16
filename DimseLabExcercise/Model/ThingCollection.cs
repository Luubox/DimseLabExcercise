using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ThingCollection
    {
        private static ThingCollection _instance = new ThingCollection();

        public static ThingCollection Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Thing> Things { get; set; }

        public ThingCollection()
        {
            Things = new ObservableCollection<Thing>();
        }

        public void Add(string thingName, DateTime lendOutDate, DateTime handInDate, List<string> keywords)
        {
            Things.Add(new Thing(thingName,lendOutDate,handInDate, keywords));
        }
    }
}
