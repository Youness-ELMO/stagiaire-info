using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagiaire
{
    public class stagiaire
    {
        int code;
        string nom;
        int age;
        string filiere;


        public stagiaire(int code, string nom, int age, string filiere)
        {
            if (age < 0) throw new ageexception("l'age doit etre entre positive");
            else
            {
                this.age = age;
                this.filiere = filiere;
                this.code = code;
                this.nom = nom;


            }

        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Filiere
        {
            get { return filiere; }
            set { filiere = value; }
        }

        public string afficher()
        {
            return "le code est :" + code + "le nom est: " + nom + "l'age est: " + age + "la filiere est: " + filiere;
        }
    }
}

