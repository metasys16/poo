using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class Contact
    {
        // attributs !!!!!!!!!!!!!! PRIVES !!!!!!!!!!!!!!!
        protected String nom;
        protected String prenom;
        protected String telephone;
        protected String mail;
        private DateTime dateDeNaissance;

        // Accesseur get , accesseur set
        public string Nom  // propriété Nom
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

        public string Prenom  // propriété Nom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public string Mail  // propriété Nom
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

        public string Telephone  // propriété Nom
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }

        // Constructeur
        public Contact(String nom, String prenom, String telephone, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
        }

        public Contact(String prenom, String nom)
        {
            this.prenom = prenom;
            this.nom = nom;
        }

        // Méthodes
        public string SePresenter()
        {
            String message;

            message = "COUCOU je suis : ";

            return message + prenom + " " + nom + " telephone : " + telephone;
        }

        public string SePresenter(bool versionCourte)
        {
            String message;

            if (versionCourte == true)
            { 
                message = "Version courte : ";
                message = message + prenom + " " + nom;
            }

            else
            {
                message = SePresenter();
            }

            return message;
        }

        public void SetTelephone(String nouveau_telephone)
        {
            this.telephone = nouveau_telephone;
        }

        public String GetTelephone()
        {
            return this.telephone;
        }
    }
}
