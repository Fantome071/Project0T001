using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibliotheque;

namespace TestUnitairePrincipal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CartesObjectifs()
        {
            PackCartesObjectifs pack01 = new PackCartesObjectifs();
        }

        [TestMethod]
        public void Couleur()
        {
            Couleur bleu = new Couleur(1);
            string testBleu = bleu.GetNomCouleur();
            Assert.AreEqual("Bleu", testBleu);
        }

        [TestMethod]
        public void EmplacementCoordonnee()
        {
            Emplacement temp = new Emplacement();
            temp._coordonnee.SetNull();
            temp._coordonnee.SetCoordonnee(3, 3);
            temp._tuileFantome = true;

            Emplacement test = new Emplacement();
            test._coordonnee.SetCoordonnee(3, 3);

            Assert.AreEqual(test._coordonnee._x, temp._coordonnee._x);
            Assert.AreEqual(test._coordonnee._y, temp._coordonnee._y);
            Assert.AreEqual(test._tuilePiece, temp._tuilePiece);
            Assert.AreNotEqual(test._tuileFantome, temp._tuileFantome);
        }

        [TestMethod]
        public void Tuiles()
        {
            Couleur rouge = new Couleur(2);
            TuileFantome ghost = new TuileFantome(rouge);
            TuilePiece chambre01 = new TuilePiece(rouge, 5000);
            ghost._emplacement._coordonnee.SetNull();
        }

        [TestMethod]
        public void ThePhantomSociety()
        {
            ThePhantomSociety thePhantomSociety = new ThePhantomSociety(4, 1, true);

            string[] nomJoueur = new string[4];
            CreationNomJoueur(nomJoueur);
            bool[] roleJoueur = new bool[4];
            thePhantomSociety.GetRoleAleatoire(roleJoueur);

            thePhantomSociety.DefinitionDesJoueurs(nomJoueur, roleJoueur);

            int compteurFantome = 0;
            int compteurChasseur = 0;
            for (int i = 0; i < 4; i++)
            {
                if (thePhantomSociety._JoueursJeu[i]._role == true)
                    compteurFantome = compteurFantome + 1;
                else
                    compteurChasseur = compteurChasseur + 1;
            }

            Assert.AreEqual(2, compteurFantome);
            Assert.AreEqual(2, compteurChasseur);
        }

        public void CreationNomJoueur(string[] nom)
        {
            for (int i = 0; i < nom.Length; i++)
                nom[i] = "Name 0" + (i + 1).ToString();
        }
    }
}
