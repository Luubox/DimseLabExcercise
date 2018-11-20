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
        private DateTime _projectStartupDate;
        private DateTime _projectEndDate;

        public string Name { get => _name; set => _name = value; }
        public string Summary { get => _summary; set => _summary = value; }
        public List<Participant> Participants { get => _participants; set => _participants = value; }
        public DateTime ProjectStartupDate { get => _projectStartupDate; }
        public DateTime ProjectEndDate { get => _projectEndDate; set => _projectEndDate = value; }

        public Project(string name, string summary, List<Participant> participants)
        {
            _name = name;
            _summary = summary;
            _participants = participants;
            _projectStartupDate = DateTime.Now;
        }

        public Project()
        {
            
        }
    }
}
