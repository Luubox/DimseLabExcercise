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
        }

        public void Add(string name, string summary, List<Participant> participants)
        {
            Projects.Add(new Project(name, summary, participants));
        }
    }
}
