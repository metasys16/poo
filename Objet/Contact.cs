using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Objet
{
    class Contact
    {
        // attributs !!!!!!!!!!!!!! PRIVES !!!!!!!!!!!!!!!
        private String nom;
        private String prenom;
        private String telephone;
        private String mail;
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

        // Constructeur
        public Contact(String nom, String prenom, String telephone, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
        }

        // Méthodes
        public void SePresenter()
        {
            String message;

            message = "COUCOU je suis : ";

            Console.WriteLine(message + prenom + " " + nom + " telephone : " + telephone);
        }

        public void SetTelephone(String nouveau_telephone)
        {
            this.telephone = nouveau_telephone;
        }

        public String GetTelephone()
        {
            return this.telephone;
        }

        public void EnregistrerContact()
        {
            StreamWriter file;

            // instance de la classe StreamWriter
            file = new StreamWriter("C:/Users/Mike/Documents/Visual Studio 2015/Projects/Objet/Contacts.txt", true);
            
            //file.Write(nom + " " + prenom + " " + mail + " " + telephone);
            file.WriteLine(nom + " " + prenom + " " + mail + " " + telephone);

            // fermer le flux 
            file.Close();
        }
    }
}
