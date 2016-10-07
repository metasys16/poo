using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objet
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // INSTANCE(S) des classes
            // PRECISER LE TYPE !!!!!!!!! de la variable
            Manager ContactManager = new Manager("C:/Users/Mike/Documents/Visual Studio 2015/Projects/Objet/Contacts.txt");
            InteractionsUtilisateur ui = new InteractionsUtilisateur();

            // List<Contact> listeContact;


            //listeContact = listeContactsManager.ManagerListe();


            //ui.affichageListeContacts(listeContact);
            Contact nouveauContact;

            nouveauContact = ui.SaisirContact();
            ContactManager.EnregistrerContact(nouveauContact);
            // Se présenter
            /*
            
            // récupérer le numéro de téléphone du contact
            contact.GetTelephone();

            // Changer le numéro de téléphone
            Console.WriteLine("Changer de téléphone");

            string nouveau_telephone; 
       
            nouveau_telephone = Console.ReadLine();
            
            // enregistrer le nouveau numéro de télephone
            contact.SetTelephone(nouveau_telephone);
            
            // enseignant.SePresenter(); // polymorphisme !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Enseignant nouvelEnseignant = new Enseignant("jean", "kader", "00000000", "llllf@ggr.com", "francais");
            Etudiant nouvelEtudiant = new Etudiant("jean", "kader", "00000000", "llllf@ggr.com", "math");

            nouvelEnseignant.SePresenter(true);
            nouvelEtudiant.SePresenter(true);

    */
        }
    }
}
