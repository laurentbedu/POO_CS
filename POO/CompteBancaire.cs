using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Sub;

namespace POO
{
    public class CompteBancaire
    {
        private readonly ClasseDansSub subCls;
        private string titulaire;
        private double solde;
        private string devise;
        private string interne;

        protected int MyProperty { get; private set; }

        public string Titulaire { get => titulaire; }
        public string Interne { get => interne; private set => interne = value; }
        public string Devise { get; set; }

        public string getTitulaire()
        {
            return this.titulaire;
        }
        public bool setTitulaire(string newValue)
        {
            try
            {
                this.titulaire = newValue;
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public CompteBancaire()
        {
            titulaire = "";
            solde = 0;
            Devise = "€";
            subCls = new ClasseDansSub();
            Interne = "";
        }

        public CompteBancaire(string _titulaire, double _solde, string _devise)
        {
            titulaire = _titulaire;
            solde = _solde;
            Devise = _devise;
        }

        

        public void Crediter(double montant)
        {
            solde = solde + montant;
            Interne = "";


        }
        public void Debiter(double montant)
        {
            solde = solde - montant;
        }
    }
}
