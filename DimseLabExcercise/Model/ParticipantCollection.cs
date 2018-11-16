using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class ParticipantCollection
    {
        private static ParticipantCollection _instance = new ParticipantCollection();

        public static ParticipantCollection Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Participant> Participants { get; set; }

        public ParticipantCollection()
        {
            Participants = new ObservableCollection<Participant>();
        }

        public void Add(string participantName, string participantEmail)
        {
            Participants.Add(new Participant(participantName, participantEmail));
        }
    }
}
