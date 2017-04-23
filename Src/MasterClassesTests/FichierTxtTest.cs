// * ==========================================================================
// Application : Master.Classes 
// Classe : FichierTxt 
// Fonctions : Classe de tests de la classe de gestion FichierTxt 
// License:  License LGPL 
// Version :  0.01 du 18/02/2010 
// Lien : http://masterclasses.codeplex.com 
// Auteur(s) : Olivier
// CopyLeft  :  CopyRight (C) 2010 Master 2 CCI Tours <master2cci@laposte.net>
// Création : 18/02/2010
// Etat : en cours
// Controle du :
// Licence : 
// L'autorisation est accordée, à titre gratuit, à toute personne d'obtenir une copie 
// de ce logiciel et de ses fichiers de documentation, pour pouvoir utiliser 
// ce logiciel sans restriction, y compris, sans s'y limiter, les droits 
// d'utiliser, de copier, de modifier, de fusionner, de publier, de distribuer, 
// de sous-licence, et / ou de vendre les copies du Logiciel, et d'autoriser les 
// personnes auxquelles le logiciel est livré de le faire, sous réserve des 
// conditions suivantes:
// 
// Les avis de droit d'auteur et la présente autorisation doivent être inclus dans 
// toutes les copies ou parties substantielles du Logiciel.
// 
// LE LOGICIEL EST FOURNI "TEL QUEL", SANS GARANTIE DE QUELQUE NATURE QUE CE SOIT, 
// EXPLICITE OU  IMPLICITE, Y COMPRIS, MAIS SANS Y LIMITER LES GARANTIES DE QUALITE 
// MARCHANDE, D'ADEQUATION A UN USAGE PARTICULIER ET D'ABSENCE DE CONTREFAÇON. EN 
// AUCUN CAS LES AUTEURS OU LES TITULAIRES DE DROITS D'AUTEUR POURRONT ETRE TENUE 
// RESPONSABLES DE TOUT DOMMAGE,  RÉCLAMATION OU AUTRE  RESPONSABILITE, DANS LE 
// CADRE D'UNE ACTION DE CONTRAT, UN DELIT OU AUTRE, DÉCOULANT DE, OU EN RELATION 
// AVEC LE LOGICIEL OU DE SON UTILISATION OU AUTRES EN RELATION AVEC LE LOGICIEL.
// Licence LGPL : http://commonlibrarynet.codeplex.com/license 
// *---------------------------------------------------------------------------
//
// * ==========================================================================

#region Références

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Master.Classes.Fichiers;

#if !NUNIT
using Microsoft.VisualStudio.TestTools.UnitTesting;
#else
using NUnit.Framework;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestContext = NUnit.Framework.Text;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
#endif

#endregion

namespace Master.Classes.FichierTxtTest
{
    /// <summary>
    /// Classe de tests des méthodes de la classe FichierTxt.
    /// </summary>
    [TestClass]
    public class FichierTxtTest
    {
        #region Attributs

#if !NUNIT
        /// <summary>
        /// Instance de contexte de test.
        /// </summary>
        private TestContext testContexteInstance;
#endif

        #endregion

        #region Propriétés

#if !NUNIT
        /// <summary>
        /// Obtient ou définit le contexte de test qui fournit des informations 
        /// sur la série de tests active ainsi que ses fonctionnalités.
        /// </summary>
        /// <value>Instance de contexte de test.</value>
        public TestContext TestContexte
        {
            get
            {
                return this.testContexteInstance;
            }
            set
            {
                this.testContexteInstance = value;
            }
        }
#endif

        #endregion

        #region Attributs de tests supplémentaires

#if !NUNIT
        /// <summary>
        /// Utilisez Initialisation pour exécuter du code avant d'exécuter.
        /// le premier test de la classe.
        /// </summary> 
        /// <param name="testContext">Contexte de test.</param>
        [ClassInitialize()]
        public static void Initialisation(TestContext testContext)
        {
            Directory.SetCurrentDirectory("Donnees");
        }
#else
        /// <summary>
        /// Utilisez Initialisation pour exécuter du code avant d'exécuter.
        /// le premier test de la classe.
        /// </summary>  
        [ClassInitialize()]
        public static void Initialisation()
        {       
            Directory.SetCurrentDirectory("Donnees");
        }
#endif

        /// <summary> 
        /// Utilisez NettoyageFinal pour exécuter du code une fois que tous 
        /// les tests d'une classe ont été exécutés.
        /// </summary>
        [ClassCleanup()]
        public static void NettoyageFinal()
        {
        }

        /// <summary> 
        /// Utilisez InitialisationTest pour exécuter du code avant d'exécuter 
        /// chaque test.
        /// </summary>
        [TestInitialize()]
        public void InitialisationTest()
        {
        }

        /// <summary> 
        /// Utilisez NettoyageTest pour exécuter du code après que chaque test 
        /// a été exécuté.
        /// </summary>
        [TestCleanup()]
        public void NettoyageTest()
        {
        }

        #endregion

        #region Tests de la classe FichierTxt.
        /// <summary>
        /// Test de la methode LectureFichier de la classe FichierTxt
        /// </summary>
        [TestMethod()]
        public void FichierTxtLectureFichier()
        {
            FichierTxt target = new FichierTxt();
            List<string> expected = new List<string>() { "ligne1", "ligne2", "ligne3", "ligne4", "ligne5" };
            List<string> actual = target.LectureFichier("test.txt");
            Assert.AreEqual(expected, actual, "FichierTxtLectureFichier");
        }

        /// <summary>
        /// Test de la méthode NombreLigne de la classe FichierTxt
        /// </summary>
        [TestMethod()]
        public void FichierTxtNombreLigneTest()
        {
            FichierTxt target = new FichierTxt();
            int expected = 5;
            int actual;
            actual = target.NombreLigne("test.txt");
            Assert.AreEqual(expected, actual, "FichierTxtNombreLigneTxt");
        }

        /// <summary>
        /// Test de la méthode difference de la classe FichierTxt.
        /// </summary>
        [TestMethod()]
        public void FichierTxtdifferenceTest()
        {
            FichierTxt target = new FichierTxt();
            List<List<string>> expected = new List<List<string>>() { new List<string>() { "ligne1" }, new List<string>() { "list1" } };
            List<List<string>> actual = target.difference("text.txt", "text2.txt");
            Assert.AreEqual(expected, actual, "FichierTxtNombreLigneTest");
        }

        /// <summary>
        /// Test de la méthode Supprimer de la classe FichierTxt.
        /// </summary>
        [TestMethod()]
        public void FichierTxtSupprimerTest()
        {
            FichierTxt target = new FichierTxt();
            List<string> actual = new List<string>();
            List<string> expected = new List<string>();
            using (StreamReader SR = new StreamReader("testAvantSuppression.txt"))
            {
                string ligne;

                while ((ligne = SR.ReadLine()) != null)
                {
                    expected.Add(ligne);
                }
            }
            target.SupprimerLigne(new int[] { 1 }, "testAvantSuppression.txt");
            using (StreamReader SR = new StreamReader("testApresSuppression.txt"))
            {
                string ligne;

                while ((ligne = SR.ReadLine()) != null)
                {
                    actual.Add(ligne);
                }
            }
            Assert.AreEqual(actual, expected, "FichierTxtSupprimerTest");
        }

        /// <summary>
        /// Test de la méthode ToString de la classe FichierTxt.
        /// </summary>
        [TestMethod()]
        public void FichierTxtToStringTest()
        {
            FichierTxt target = new FichierTxt();
            string expected = "Master.Classes.FichierTxtTest.FichierTxt";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual, "FichierTxtToStringTest");
        }

        /// <summary>
        /// Test du constructeur sans paramètre de la classe FichierTxt.
        /// </summary>
        [TestMethod()]
        public void FichierTxtConstructorTest()
        {
            FichierTxt target = new FichierTxt();
            Assert.IsNotNull(target, "FichierTxtConstructorTest");
        }

        #endregion

        #region Initialisation, finalisation

        #region Constructeurs

        /// <summary>
        ///	Initialise une nouvelle instance de la classe <see cref="FichierTxt"/>.	
        /// </summary>
        public FichierTxtTest()
        {
            // TODO: Constructeur de la classe FichierTxtTest
        }

        #endregion

        #endregion
    }
}
