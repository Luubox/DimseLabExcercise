using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DimseLabExcercise.Annotations;
using DimseLabExcercise.Handler;
using DimseLabExcercise.Model;
using GalaSoft.MvvmLight.Command;

namespace DimseLabExcercise.ViewModel
{
    class ProjectViewModel : INotifyPropertyChanged
    {
        public ProjectHandler ProjectHandler { get; set; }
        public ProjectCatalog ProjectCatalog { get; set; }
        public ParticipantCatalog ParticipantCatalog { get; set; }

        public ICommand CreateProjectCommand { get; set; }
        public ICommand DeleteProjectCommand { get; set; }
        public ICommand UpdateProjectCommand { get; set; }

        private Project _newProject;
        public Project NewProject
        {
            get { return _newProject; }
            set
            {
                _newProject = value;
                OnPropertyChanged();
            }
        }

        public ProjectViewModel()
        {
            ProjectCatalog = ProjectCatalog.Instance;
            ParticipantCatalog = ParticipantCatalog.Instance;
            ProjectHandler = new Handler.ProjectHandler(this);

            CreateProjectCommand =
                new RelayCommand(ProjectHandler.CreateProject);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
