using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Contact
    {
        // attributs
        private String nom;
        private String prenom;
        private String telephone;
        private String mail;
        private DateTime dateDeNaissance;

        // getter et setter
        public string Nom    // the Name property
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        // Constructeur
        public Contact(String nom, String prenom, String telephone, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;

            Console.WriteLine("coucou je suis dans le constructeur de la classe contact");
            Console.WriteLine(this.nom);
            Console.WriteLine(this.prenom);
            Console.WriteLine(this.telephone);
            Console.WriteLine(this.mail);
        }
    }
}
