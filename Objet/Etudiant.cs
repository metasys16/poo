﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Etudiant : Contact
    {
        private String cursus;

        // Constructeur de la classe fille Etudiant
        public Etudiant(string nom, string prenom, string telephone, string mail, string cursus) : base(nom, prenom, telephone, mail)
        {
            this.cursus = cursus;
        }

        // mutateur 
        public void SetCursus(String cursus)
        {
            this.cursus = cursus;
        }

        public void SePresenter(bool versionCourte)
        {
            String message;
            base.SePresenter(versionCourte);
            message = "j'apprends le " + cursus;
            Console.WriteLine(message);
        }
    }
}
