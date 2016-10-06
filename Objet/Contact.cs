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

        public Contact(String ligne)
        {
            // decouper la chaine de caractere en mot
           // string[] personData = File.ReadAllLines(ligne);

            // premier mot chaine de caractere
            //   this.prenom =            
            // this.nom = 
            //this.mail = 
            //this.telephone = 
        }

        // Méthodes
        public void SePresenter()
        {
            String message;

            message = "COUCOU je suis : ";

            Console.WriteLine(message + prenom + " " + nom + " telephone : " + telephone);
        }

        public void SePresenter(bool versionCourte)
        {
            String message;

            if (versionCourte == true)
            { 
                message = "Version courte : ";
                Console.WriteLine(message + prenom + " " + nom);
            }

            else
            {
                SePresenter();
            }
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
