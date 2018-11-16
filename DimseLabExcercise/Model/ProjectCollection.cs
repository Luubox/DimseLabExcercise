using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ProjectCollection
    {
        private static ProjectCollection _instance = new ProjectCollection();

        public static ProjectCollection Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Project> Projects { get; set; }

        public ProjectCollection()
        {
            Projects = new ObservableCollection<Project>();
        }

        public void Add(string projectName, string projectSummary)
        {
            Projects.Add(new Project(projectName, projectSummary));
        }
    }
}
