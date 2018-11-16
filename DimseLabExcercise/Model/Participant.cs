﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimseLabExcercise.Model
{
    class Participant
    {
        private string _name;
        private string _email;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }

        public Participant(string name, string email)
        {
            _name = name;
            _email = email;
        }
    }
}
