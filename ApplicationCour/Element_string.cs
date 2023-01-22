using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCour
{
    class Element_string
    {
        private string id;
        private string nom;
        public string Identifiant
        {
            get { return id; }
            set { id = value; }
        }
        public string NomElement
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
