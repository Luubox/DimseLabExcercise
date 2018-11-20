using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Participant
    {
        private string _firstFirstName;
        private string _lastName;
        private string _email;

        public string FirstName { get => _firstFirstName; set => _firstFirstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }

        public Participant(string firstFirstName, string lastName, string email)
        {
            _firstFirstName = firstFirstName;
            _lastName = lastName;
            _email = email;
        }
    }
}
