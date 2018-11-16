using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Thing
    {
        private string _thingName;
        private DateTime _lendOutDate;
        private DateTime _handInDate;
        private List<String> _keywords;

        public string ThingName { get => _thingName; set => _thingName = value; }
        public DateTime LendOutDate { get => _lendOutDate; set => _lendOutDate = value; }
        public DateTime HandInDate { get => _handInDate; set => _handInDate = value; }
        public List<string> Keywords { get => _keywords; set => _keywords = value; }

        public Thing(string thingName, DateTime lendOutDate, DateTime handInDate, List<string> keywords)
        {
            _thingName = thingName;
            _lendOutDate = lendOutDate;
            _handInDate = handInDate;
            _keywords = keywords;
        }
    }
}
