using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ProjectCatalog
    {
        private static ProjectCatalog _instance = new ProjectCatalog();
        public static ProjectCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Project> Projects { get; set; }

        public ProjectCatalog()
        {
            Projects = new ObservableCollection<Project>();
            Projects.Add(new Project("build robot", "sdfghjkjhgfdertgv dfhvn",
                new List<Participant>(){new Participant("Ebbe", "ebva@easj.dk")
                    ,ParticipantCatalog.Instance.Participants[0]}));
            Projects.Add(new Project("RC CAR", "Lorem ipsum dfhvn",
                new List<Participant>() { ParticipantCatalog.Instance.Participants[0], ParticipantCatalog.Instance.Participants[1], ParticipantCatalog.Instance.Participants[2] }));
        }

        public void Add(string name, string summary, List<Participant> participants)
        {
            Projects.Add(new Project(name, summary, participants));
        }
    }
}
