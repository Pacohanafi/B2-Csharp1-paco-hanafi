﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("re World!");

            List<Commune> listeCommune = new List<Commune>();

            while (true)
            {
                string choix_util = Menu_com();

                if (choix_util == "1")
                {
                    Commune com = creerCommune();
                    listeCommune.Add(com);
                }
                else if (choix_util == "2")
                {
                    afficheCommune(listeCommune);
                }
                else
                {
                    Console.WriteLine("Veiller saisir un chiffre valide.");
                }
            }
        }

        public static string Menu_com()
        {
            string choix_util;
            Console.WriteLine("1 Créer une nouvelle ville");
            Console.WriteLine("2 Afficher l'ensemble des villes");
            choix_util = Console.ReadLine();

            return choix_util;
        }

        public static Commune creerCommune()
        {
            Commune com = new Commune();
            com.nom = demandeNom();
            com.code_postale = demandeEntier("Quel est le code postale?");
            com.nb_habitant = demandeEntier("Quel est le nombre d'habitant?");
            return com;
        }

        public static string demandeNom()
        {
            Console.WriteLine("Nom de la commune?");
            string nom = Console.ReadLine();
            return nom;
        }

        public static int demandeEntier(string mess)
        {
            Console.WriteLine(mess);
            string entier = Console.ReadLine();
            int valeurConvert;

            while (!int.TryParse(entier, out valeurConvert))
            {
                Console.WriteLine("Entrez un nombre valide svp");
                entier = Console.ReadLine();
            }

            return valeurConvert;
        }

        public static void afficheCommune(List<Commune> listeCommune)
        {
            foreach(Commune com in listeCommune)
            {
                Console.WriteLine("Nom : "+ com.nom + ", CodePostal : "+ com.code_postale);
                Console.WriteLine("Nombre d'habitants : "+ com.nb_habitant);
                Console.WriteLine("-----------------------------------------------------------------");
            }


        }


    }
}