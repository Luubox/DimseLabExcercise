using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Thing
    {
        private string _name;
        private DateTime _lendOutDate;
        private DateTime _handInDate;
        private List<String> _keywords;

        public string Name { get => _name; set => _name = value; }
        public DateTime LendOutDate { get => _lendOutDate; set => _lendOutDate = value; }
        public DateTime HandInDate { get => _handInDate; set => _handInDate = value; }
        public List<string> Keywords { get => _keywords; set => _keywords = value; }

        public Thing(string name, DateTime lendOutDate, DateTime handInDate, List<string> keywords)
        {
            _name = name;
            _lendOutDate = lendOutDate;
            _handInDate = handInDate;
            _keywords = keywords;
        }
    }
}
