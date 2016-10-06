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
            // INSTANCE(S) des classes
            
            Contact enseignant = new Enseignant("Groot", "Je s'appele", "06363737364", "pereira.mickael1@gmail.com");
            Contact contact = new Contact("jean", "NomDeFamille", "06363737364", "pereira.mickael1@gmail.com");
            //contact.EnregistrerContact();
            
            StreamReader file;
            string line;

            // Lire le fichier
            file = new StreamReader("C:/Users/Mike/Documents/Visual Studio 2015/Projects/Objet/Contacts.txt", true);

            // system IO a convertir en string
            line = file.ReadLine();

            file.Close();

            Console.WriteLine(line);

            // Se présenter
            bool versionCourte;

            versionCourte = true;

            contact.SePresenter(versionCourte);
             
            /*
            // récupérer le numéro de téléphone du contact
            contact.GetTelephone();

            // Changer le numéro de téléphone
            Console.WriteLine("Changer de téléphone");

            string nouveau_telephone; 
       
            nouveau_telephone = Console.ReadLine();
            
            // enregistrer le nouveau numéro de télephone
            contact.SetTelephone(nouveau_telephone);

            // Se présenter
            contact.SePresenter();
            enseignant.SePresenter(); // polymorphisme !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            */
        }
    }
}
