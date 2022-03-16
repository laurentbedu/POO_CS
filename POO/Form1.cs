namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TestRef();
            CompteBancaire comptePierre;          // déclaration d'un nouvel objet
            comptePierre = new CompteBancaire(); // instanciation de cet objet
            CompteBancaire compteRoger = new CompteBancaire(); //initialisation d'un nouvel objet

            // affectations de valeurs aux attributs
            //comptePierre.titulaire = "Pierre";
            //comptePierre.solde = 0;
            //comptePierre.devise = "euros";

            // appels des méthodes
            comptePierre.Crediter(300);
            comptePierre.Debiter(500);
            string titulaire = comptePierre.Titulaire;
            comptePierre.Interne = "Pierre";

            //string description = "Le solde du compte de " + comptePierre.titulaire +
            //    " est de " + comptePierre.solde + " " + comptePierre.devise;
            
            //label1.Text = description;
        }

        private void TestRef()
        {
            //CompteBancaire comptePierre = new CompteBancaire();
            //CompteBancaire compteRobert = comptePierre;
            //comptePierre.solde = 100;
            //compteRobert.solde = 200;

            //int a = 10;
            //int b = a;
            //a = 20;

            //comptePierre.interne = "";

        }
    }
}