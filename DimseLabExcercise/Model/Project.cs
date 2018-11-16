using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Project
    {
        private string _name;
        private string _summary;
        private List<Participant> _participants;

        public string Name { get => _name; set => _name = value; }
        public string Summary { get => _summary; set => _summary = value; }
        public List<Participant> Participants { get => _participants; set => _participants = value; }

        public Project(string name, string summary, List<Participant> participants)
        {
            _name = name;
            _summary = summary;
            _participants = participants;
        }
    }
}
