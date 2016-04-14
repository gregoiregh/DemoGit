using System;

namespace DemoGit
{
    public class Salarie : Personne
    {
        
        private int _Salaire;
        private string _Service;

        public string Service
        {
            get { return _Service; }
            set { _Service = value; }
        }

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

        public Salarie(string nom,int age, int salaire, string service) : base (nom, age)
        {
            this.Salaire = salaire;
            this.Service = service;
        }
        public Salarie() : base()
        {
            this.Salaire = 1000;
        }
        
        
    }
}
