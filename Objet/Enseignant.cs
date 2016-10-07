using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Enseignant : Contact
    {
        private String matiere;

        // Constructeur de la classe fille Enseignant
        public Enseignant(string nom, string prenom, string telephone, string mail, string matiere) : base(nom, prenom, telephone, mail)
        {
            this.matiere = matiere;
        }

        public void SetMatiere(String matiere)
        {
            this.matiere = matiere;
        }

        public void SePresenter(bool versionCourte)
        {
            String message;
            base.SePresenter(versionCourte);
            message = "j'enseigne le : " + matiere;
            Console.WriteLine(message);

        }
    }
}
