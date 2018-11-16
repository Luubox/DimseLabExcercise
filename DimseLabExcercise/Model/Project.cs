using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Project
    {
        private string _projectName;
        private string _projectSummary;
        private List<Participant> _projectParticipants;

        public string ProjectName { get => _projectName; set => _projectName = value; }
        public string Summary { get => _projectSummary; set => _projectSummary = value; }
        public List<Participant> ProjectParticipants { get => _projectParticipants; set => _projectParticipants = value; }

        public Project(string projectName, string projectSummary, List<Participant> projectParticipants)
        {
            _projectName = projectName;
            _projectSummary = projectSummary;
            _projectParticipants = projectParticipants;
        }
    }
}
