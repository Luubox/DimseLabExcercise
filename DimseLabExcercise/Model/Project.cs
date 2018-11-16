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

        public string ProjectName { get => _projectName; set => _projectName = value; }
        public string Summary { get => _projectSummary; set => _projectSummary = value; }

        public Project(string projectName, string projectSummary)
        {
            _projectName = projectName;
            _projectSummary = projectSummary;
        }
    }
}
