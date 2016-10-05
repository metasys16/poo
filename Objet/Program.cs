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
            // INSTANCE(S) de la classe contact
            Contact contact = new Contact("Moulhoud", "Jean", "06363737364", "pereira.mickael1@gmail.com");
            Contact contact2 = new Contact("Groot", "Je s'appele", "06363737364", "pereira.mickael1@gmail.com");

            // Se présenter
            contact.SePresenter();
             
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
        }
    }
}
