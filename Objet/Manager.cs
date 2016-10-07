using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Objet
{
    class Manager
    {
        private String path;

        public Manager(string path)
        {
            this.path = path;
        }

        public void EnregistrerContact(Contact contact)
        {
            StreamWriter fichier;

            // instance de la classe StreamWriter
            fichier = new StreamWriter(path, true);

            //file.Write(nom + " " + prenom + " " + mail + " " + telephone);
            fichier.WriteLine(contactString);

            // fermer le flux
            fichier.Close();
        }

        private String ContactToCSV(Contact contact)
        {
            string contactString;

            contactString = contact.Nom + ";" + contact.Prenom + ";" + contact.Mail + ";" + contact.Telephone;

            return contactString;
        }

        public List<Contact> ManagerListe()
        {
            StreamReader fichier;
            List<Contact> listeContact = new List<Contact>();

            // Lire le fichier
            fichier = new StreamReader(path);

            while (fichier.EndOfStream != true)
            {
                string[] element = fichier.ReadLine().Split(';');

                Contact contact = new Contact(element[0], element[1], element[2], element[3]);
                listeContact.Add(contact); // ajouter ligne courante à la liste.
            }

            fichier.Close();
            return listeContact;
        }
    }
}
