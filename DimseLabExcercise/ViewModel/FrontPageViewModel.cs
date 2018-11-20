using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DimseLabExcercise.Annotations;
using DimseLabExcercise.Model;

namespace DimseLabExcercise.ViewModel
{
    class FrontPageViewModel : INotifyPropertyChanged
    {
        public ThingCatalog ThingCatalog { get; set; }
        public ProjectCatalog ProjectCatalog { get; set; }
        public ParticipantCatalog ParticipantCatalog { get; set; }

        public Project _selectedProject;
        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;
                OnPropertyChanged();
            }
        }



        public FrontPageViewModel()
        {
            ThingCatalog = ThingCatalog.Instance;
            ProjectCatalog = ProjectCatalog.Instance;
            ParticipantCatalog = ParticipantCatalog.Instance;

            SelectedProject = ProjectCatalog.Projects[0];
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
