using System;
namespace DemoGit
{
    public class Personne
    {
        private string _Nom;
        private int _Age;
        public string Nom
        {
            get
            {
                return _Nom;
            }

            set
            {
                _Nom = value;
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
            }
        }

        public Personne() : this("Personne de test", 18) { }
        
        public Personne(string nom, int age)
        {
            this.Nom = nom;
            this.Age = age;
        }

        
        public override string ToString()
        {
            return String.Format("Nom={0}, Age={1}", _Nom, _Age);
        }
              

    }
}
