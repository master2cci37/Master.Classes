// * ==========================================================================
// Application : Master.Classes 
// Classe : Comptabilite 
// Fonctions : Classe de tests de la classe de gestion de normes comptables 
// License:  License LGPL 
// Version :  0.01 du 12/02/2010 
// Lien : http://masterclasses.codeplex.com 
// Auteur(s) : Fuchsia
// CopyLeft  :  CopyRight (C) 2010 Master 2 CCI Tours <master2cci@laposte.net>
// Création : 12/02/2010
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
using System.Linq;
using System.Text;
using Master.Classes.Divers;

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

namespace Master.Classes.ComptabiliteTest
{
    /// <summary>
    /// Classe de tests des méthodes de la classe Comptabilite.
    /// </summary>
    [TestClass]
    public class Comptabilite
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
        }
#else
        /// <summary>
        /// Utilisez Initialisation pour exécuter du code avant d'exécuter.
        /// le premier test de la classe.
        /// </summary>  
        [ClassInitialize()]
        public static void Initialisation()
        {         
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

        #region Tests de la classe Comptabilite.

        /// <summary>
        /// Test de la méthode ToString de la classe Comptabilite.
        /// </summary>
        [TestMethod()]
        public void ComptabiliteToStringTest()
        {
            Comptabilite target = new Comptabilite();
            string expected = "Master.Classes.ComptabiliteTest.Comptabilite";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual, "ComptabiliteToStringTest");
        }

        /// <summary>
        /// Test du constructeur sans paramètre de la classe Comptabilite.
        /// </summary>
        [TestMethod()]
        public void ComptabiliteConstructorTest()
        {
            Comptabilite target = new Comptabilite();
            Assert.IsNotNull(target, "ComptabiliteConstructorTest");
        }

        #endregion

        #region Initialisation, finalisation

        #region Constructeurs

        /// <summary>
        ///	Initialise une nouvelle instance de la classe <see cref="Comptabilite"/>.	
        /// </summary>
        public Comptabilite()
        {
            // TODO: Constructeur de la classe Comptabilite
        }

        #endregion

        #endregion
    }
}