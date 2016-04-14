using System;

namespace DemoGit
{
    public class Salarie : Personne
    {
        private int _Salaire;

        public int Salaire
        {
            get
            {
                return _Salaire;
            }

            set
            {
                _Salaire = value;
            }
        }

        public Salarie(string nom,int age, int salaire) : base (nom, age)
        {
            this.Salaire = salaire;
        }
        public Salarie() : base()
        {
            this.Salaire = 1000;
        }



    }
}
