using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DimseLabExcercise.ViewModel;

namespace DimseLabExcercise.Handler
{
    class ProjectHandler
    {
        public ProjectViewModel ProjectViewModel { get; set; }

        public ProjectHandler(ProjectViewModel projectViewModel)
        {
            ProjectViewModel = projectViewModel;
        }

        public void CreateProject()
        {
            Debug.WriteLine("Its Working_starwarsprequelmeme.gif");
        }

        public void DeleteProject()
        {

        }

        public void UpdateProject()
        {

        }
    }
}
