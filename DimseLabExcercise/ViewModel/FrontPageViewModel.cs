using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public FrontPageViewModel()
        {
            ThingCatalog = ThingCatalog.Instance;
            ProjectCatalog = ProjectCatalog.Instance;
            ParticipantCatalog = ParticipantCatalog.Instance;
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
