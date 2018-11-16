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
        private string _summary;

        public string ProjectName { get => _projectName; set => _projectName = value; }
        public string Summary { get => _summary; set => _summary = value; }

        public Project(string projectName, string summary)
        {
            _projectName = projectName;
            _summary = summary;
        }
    }
}
