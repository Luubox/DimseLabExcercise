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
            Participants = new ObservableCollection<Participant>
            {
                new Participant("Jonas", "Rasmussen", "bhui@gnraeoi.com"),
                new Participant("bjarne", "ingels", "bhasdui@gnraeoi.com"),
                new Participant("ole", "minet", "asdada@gnraeoi.com"),
                new Participant("lars", "minet", "asdada@gnraeoi.com"),
                new Participant("bente", "minet", "asdada@gnraeoi.com"),
                new Participant("lotte", "minet", "asdada@gnraeoi.com")
            };
        }

        public void Add(string firstName, string lastName, string email)
        {
            Participants.Add(new Participant(firstName, lastName, email));
        }
    }
}
