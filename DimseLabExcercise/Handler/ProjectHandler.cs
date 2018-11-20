using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DimseLabExcercise.Model;
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
            // ProjectViewModel.Newproject.name (unikt)
            // 1 ansvarlig
            // easj email
            // beskrivelse mindst 5 ord
            foreach (var project in ProjectViewModel.ProjectCatalog.Projects)
            {
                if (project.Name == ProjectViewModel.NewProject.Name)
                {
                    Debug.WriteLine("Error");
                }
                else
                {
                    //ProjectViewModel.NewProject.Participants.Add(ProjectViewModel.NewParticipant);
                    // Husk at når du arbejder med Singleton så brug ikke andre lister hvis muligt.
                    ParticipantCatalog.Instance.Participants?.Add(ProjectViewModel.NewParticipant);
                    ProjectViewModel.ProjectCatalog.Projects.Add(
                        ProjectViewModel.NewProject);
                    break;
                }

            }
        }

        public void DeleteProject()
        {

        }

        public void UpdateProject()
        {

        }
    }
}
