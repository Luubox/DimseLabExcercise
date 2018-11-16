using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ParticipantCatalog
    {
        private static ParticipantCatalog _instance = new ParticipantCatalog();

        public static ParticipantCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Participant> Participants { get; set; }

        public ParticipantCatalog()
        {
            Participants = new ObservableCollection<Participant>();
        }

        public void Add(string name, string email)
        {
            Participants.Add(new Participant(name, email));
        }
    }
}
