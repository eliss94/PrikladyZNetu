using PrikladyZNetu;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SpecFlowTestyNaReseni
{
    [Binding]
    public class ScenareTestuSteps
    {
        public string _vysledekstring;
        [Then(@"dostanu (.*)")]
        public void ThenDostanuVysledek(string vysledek)
        {
            Assert.That(_vysledekstring == vysledek);
        }

        #region Obsah trojuhelniku
        int _vyska;
        int _zakladna;
        int _vysledek;
        
        [Given(@"zakladna trojuhelniku je (.*)")]
        public void GivenZakladnaTrojuhelnikuJe(int zakladna)
        {
            _zakladna = zakladna;
        }


        [Given(@"vyska trojuhelniku je (.*)")]
        public void GivenVyskaTrojuhelnikuJe(int vyska)
        {
            _vyska = vyska;
        }

        [When(@"na nich spocitam obsah")]
        public void WhenNaNichSpocitamObsah()
        {
            _vysledek = Reseni.Obsah(_zakladna, _vyska);
        }

        [Then(@"obsah trojuhelniku je (.*)")]
        public void ThenObsahTrojuhelnikuJe(int vysledek)
        {
            Assert.That(_vysledek == vysledek);
        }
        #endregion

        #region Mensi z obou cisel
        string _prvniCislo;
        string _druheCislo;
      
        [Given(@"prvni cislo je (.*)")]
        public void GivenPrvniCisloJeCislo(string prvniCislo)
        {
            _prvniCislo = prvniCislo;
        }

        [Given(@"druhe cislo je (.*)")]
        public void GivenDruheCisloJeCislo(string druheCislo)
        {
            _druheCislo = druheCislo;
        }

        [When(@"vyberu mensi z obou")]
        public void WhenVyberuMensiZObou()
        {
            _vysledekstring = Reseni.MensiCislo(_prvniCislo, _druheCislo);
            
        }

        #endregion

        #region Obracec a zadavac
        int _zadaneCislo;

        [Given(@"zadane cislo je (.*)")]
        public void GivenZadaneCisloJe(int zadaneCislo)
        {
            _zadaneCislo = zadaneCislo;
        }
        [When(@"ho otocim a pridam puvodni cislo")]
        public void WhenHoOtocimAPridamPuvodniCislo()
        {
            _vysledekstring = Reseni.ObracecAPridavac(_zadaneCislo);
        }

        #endregion

        #region Posouvani kelimku
        string[] _poleTahu;
        [Given(@"dostanu zadane (.*)")]
        public void GivenDostanuZadane(string zadaneTahy)
        {
            _poleTahu = zadaneTahy.Split(' ');
        }
        [When(@"aplikuju tahy na kelimky")]
        public void WhenAplikujuTahyNaKelimky()
        {
            _vysledekstring = Reseni.PosouvaniKelimku(_poleTahu);
        }
        #endregion

        

        #region Hexcode
        string _kod;
        bool _jeHexcode;
        [Given(@"je zadany (.*)")]
        public void GivenJeZadany(string kod)
        {
            _kod = kod;
        }
        [When(@"otestuji je-li to hexcode")]
        public void WhenOtestujiJe_LiToHexcode()
        {
            _jeHexcode = Reseni.Hexcode(_kod);
        }
        [Then(@"vysledek je (.*)")]
        public void ThenVysledekJe(bool boolean)
        {
            Assert.That(_jeHexcode == boolean);
        }
        #endregion

        #region Vymena promennych
        int _promennaA;
        int _promennaB;
        [Given(@"je dana promenna (.*) a promenna (.*)")]
        public void GivenJeDanaPromennaAPromenna(int a, int b)
        {
            _promennaA = a;
            _promennaB = b;
        }

        [When(@"je vymenim")]
        public void WhenJeVymenim()
        {
            Reseni.VymenaPromennych(ref _promennaA, ref _promennaB);
        }
        [Then(@"promenna a obsahuje (.*) promenna b obsahuje (.*)")]
        public void ThenPromennaAObsahujePromennaBObsahuje(int hodnotaB, int hodnotaA)
        {
            Assert.That((_promennaA == hodnotaB) && (_promennaB == hodnotaA));
        }
        #endregion

        #region Faktorial
        int _cislo;
        float _faktorial;
        [Given(@"je zadane cislo (.*)")]
        public void GivenJeZadaneCislo(int j)
        {
            _cislo = j;
        }
        [When(@"na nem vypoctu faktorial")]
        public void WhenNaNemVypoctuFaktorial()
        {
            _faktorial = Reseni.Faktorial(_cislo);
        }
        [Then(@"vysledek vypoctu je (.*)")]
        public void ThenVysledekVypoctuJe(int faktorial)
        {
            Assert.That(_faktorial == faktorial);
        }
        #endregion

        #region Vraceni max a min cisla
        string _zadanaCisla;
        [Given(@"mame zadany string cisel (.*)")]
        public void GivenMameZadanyStringCisel(string zadanaCisla)
        {
            _zadanaCisla = zadanaCisla;
        }
        [When(@"vybereme nejmensi a nejvetsi cislo")]
        public void WhenVyberemeNejmensiANejvetsiCislo()
        {
            _vysledekstring = Reseni.NejmensiANejvetsi(_zadanaCisla);
        }
        #endregion

        int _cisloKNasobeni;
        int _delkaPole;
        string vysledekString = "";
        [Given(@"mame zadane (.*) a (.*)")]
        public void GivenMameZadaneA(int cislo, int delkaPole)
        {
            _cisloKNasobeni = cislo;
            _delkaPole = delkaPole;
        }

        [When(@"vypocteme pole nadobku")]
        public void WhenVypoctemePoleNadobku()
        {
            vysledekString = Reseni.PoleNasobku(_cisloKNasobeni, _delkaPole);
        }

        [Then(@"dostaneme (.*)")]
        public void ThenDostaneme(string poleNasobku)
        {
            Assert.That(poleNasobku + " " == vysledekString);
        }

        string _zadanyString;
        [Given(@"string (.*)")]
        public void GivenString(string zadani)
        {
            _zadanyString = zadani;
        }
        [When(@"otocime velikost pismen")]
        public void WhenOtocimeVelikostPismen()
        {
            _vysledekstring = Reseni.MenicVelikostiPismen(_zadanyString);
        }
        

    }
}
