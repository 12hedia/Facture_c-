using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCour
{
    class Element_int
    {
        private int id;
        private string nom;
        public int Identifiant
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
