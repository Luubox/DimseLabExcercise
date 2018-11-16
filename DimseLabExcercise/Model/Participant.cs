using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Participant
    {
        private string _participantName;
        private string _participantEmail;

        public string Name { get => _participantName; set => _participantName = value; }
        public string Email { get => _participantEmail; set => _participantEmail = value; }

        public Participant(string participantName, string participantEmail)
        {
            _participantName = participantName;
            _participantEmail = participantEmail;
        }
    }
}
