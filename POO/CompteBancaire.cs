using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class CompteBancaire
    {
        public string titulaire;
        public double solde;
        public string devise;

        public void Crediter(double montant)
        {
            solde = solde + montant;
        }
        public void Debiter(double montant)
        {
            solde = solde - montant;
        }
    }
}
