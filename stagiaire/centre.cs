using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace stagiaire
{
    class centre
    {
        string nom;
        string adresse;
        public static int cpt = 0;


        public static List<stagiaire> l = new List<stagiaire>();

        public static void ajouter(stagiaire s, int cod)
        {
            if ( s.Code != cod )
            {
                l.Add(s);
            }
            else
            {
                Console.WriteLine("erreur");
            }
            
        }

        public static void supprimer(int co)
        {

            foreach (stagiaire s in l)
            {
                if (s.Code == co)
                {
                    l.Remove(s);
                    break;
                }
            }


        }
        public static void modifier(int cod)
        {

            foreach (stagiaire s in l)
            {
                if (s.Code == cod)
                {
                    Console.WriteLine("entrer le code");
                    s.Code = int.Parse(Console.ReadLine());
                    Console.WriteLine("entrer la nom");
                    s.Nom = Console.ReadLine();
                    Console.WriteLine("entrer la filier");
                    s.Filiere = Console.ReadLine();
                    Console.WriteLine("entrer la age");
                    s.Age = int.Parse(Console.ReadLine());

                }
            }
        }

        public static void retourne_nombre(string fili)
        {
            foreach (stagiaire s in l)
            {
                if (fili == s.Filiere)
                {
                    cpt++;
                }
            }
        }
        public void exoporter()
        {
            string y= "fichier";
            FileStream f = File.Open(y, FileMode.OpenOrCreate);
            XmlSerializer p = new XmlSerializer(typeof(List<stagiaire>));
            p.Serialize(f, l);

            f.Close();
           
        }
    }
}
