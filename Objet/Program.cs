using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Objet
{ 
    class Program
    {
        static void Main(string[] args)
        {
            /*/ INSTANCE(S) des classes
            
            Contact enseignant = new Enseignant("Groot", "Je s'appele", "06363737364", "pereira.mickael1@gmail.com", "français");
            Contact contact = new Contact("jean", "NomDeFamille", "06363737364", "pereira.mickael1@gmail.com");
            //contact.EnregistrerContact();
            
            StreamReader fichier;
            string ligne;
            List<string> liste = new List<string>();

            // Lire le fichier
            fichier = new StreamReader("C:/Users/Mike/Documents/Visual Studio 2015/Projects/Objet/Contacts.txt", true);

            // system IO a convertir en string
            while ((ligne = fichier.ReadLine()) != null)
            {
                liste.Add(ligne); // ajouter ligne à la liste.
                Console.WriteLine(ligne); // écrire dans la console ligne par ligne.
            }
            fichier.Close();

            // DEBUG ///////////////////////////////       
            Console.WriteLine(contact);
            ////////////////////////////////////////

            // Se présenter
            /*
            bool versionCourte;

            versionCourte = true;

            contact.SePresenter(versionCourte);
            */

            /*
            // récupérer le numéro de téléphone du contact
            contact.GetTelephone();

            // Changer le numéro de téléphone
            Console.WriteLine("Changer de téléphone");

            string nouveau_telephone; 
       
            nouveau_telephone = Console.ReadLine();
            
            // enregistrer le nouveau numéro de télephone
            contact.SetTelephone(nouveau_telephone);
            */
            // Se présenter
            
           // enseignant.SePresenter(); // polymorphisme !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Contact nouvelEnseignant = new Enseignant("jean", "kader", "00000000", "llllf@ggr.com", "francais");
            bool versionCourte;

            versionCourte = true;
            nouvelEnseignant.SePresenter(versionCourte);
        }
    }
}
