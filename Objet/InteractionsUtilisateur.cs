using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{
    class InteractionsUtilisateur
    {
        public InteractionsUtilisateur()
        {

        }

        public void affichageListeContacts(List<Contact> listeContact)
        {
            // parcourir ma listeContact avec foreach
            
            foreach (Contact contact in listeContact)
            {
                // afficher dans la console la liste
                Console.WriteLine(contact.SePresenter(true));
            }
        }

        // méthode pour afficher à l'utilisateur le moyen d'enregistrer un contact
        public Contact SaisirContact()
        {
            string prenom;
            string nom;
            string mail;
            string telephone;
            

            Console.WriteLine("prenom ?");
            prenom = Console.ReadLine();

            Console.WriteLine("nom ?");
            nom = Console.ReadLine();

            Console.WriteLine("mail ?");
            mail = Console.ReadLine();

            Console.WriteLine("telephone ?");
            telephone = Console.ReadLine();

            Contact contact = new Contact(prenom, nom, mail, telephone);
            return contact;
        }
    }
}
