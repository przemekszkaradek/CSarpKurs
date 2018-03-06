using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A14.Typy.Tests
{
    //Testowane klasy muszą w testach jednostkowych być ozdobione atrybutem  [TestClass] - ten atrybut mówi kazdy element klasy będzie testem.
    [TestClass]
    public class DzienniczekTest
    {
        [TestMethod]
        public void WartosciTest()
        {
           // bool wartosc = false;
              bool wartosc = true;
            // Assert - na tej podstawie tworzymy różne rodzaje asercji czyli sprawdzeń. po kropce mamy dostęp do szeregu metod np czy coś jest równe Assert.AreEqual  lub np jest nullem Assert.IsNull itp.
            // zwykle w takim pojednynczym teście mamy jedną instrukcję testującą i jest ona zawsze na końcu metody.
            // Sprawdzamy czy wartość jest true.
            Assert.IsTrue(wartosc);
            //Aby przeestować wybieramy Test nastepnie Run i All Tests
            // nastepnie wystarczy po prawej stronie Run All
            // Twierdzenie okazało sie fałszywe bo mamy wartośc ustawioną false nie powiodło się .
        }

        // Sprawdzamy czy maksymalna ocena z klasy dzienniczka jest liczona poprawnie.

        //Debugowanie kodu zaznaczamy prawym myszy i dajemy Debug Tests
        [TestMethod]
        public void KalkulacjaMaksymalnejOceny()
        {
            //Aby Dzienniczek był widoczny należy dodać projekt A14.Typy w References oraz zmienć modyfikator dostępu w dzienniczku na public.
            Dzienniczek dzienniczek = new Dzienniczek();
            dzienniczek.DodajOcene(9f);
            dzienniczek.DodajOcene(8f);
            dzienniczek.DodajOcene(7f);
            dzienniczek.DodajOcene(3f);
            dzienniczek.DodajOcene(4f);
            dzienniczek.DodajOcene(2f);
            dzienniczek.DodajOcene(10f);
            //Obliczamy statystyki.
            StatystykiDzienniczka statystyki = dzienniczek.CompletneStatystyki();
            //Sprawdzamy czy 9 jest zwracana jako maksymalna wartość. Max to 10 bo takie są założenia w klasie Dzienniczek
            //Assert.AreEqual(11f, statystyki.maxOcena); - ten test sie nie powiedzie
            Assert.AreEqual(10f, statystyki.maxOcena);
        }
        //Sprawdzamy przekazywanie przez wartość.
        [TestMethod]
        public void PrzekazywaniePrzezWartosc()
        {
            Dzienniczek dzienniczek = new Dzienniczek();
            dzienniczek.Nazwa = "Jacek";

            UstawImie(dzienniczek);

            Assert.AreEqual("Marcin", dzienniczek.Nazwa);
        }

        private void UstawImie(Dzienniczek dzienniczek)
        {
            dzienniczek.Nazwa = "Marcin";
        }

        [TestMethod]
        public void PrzekazywaniePrzezWartoscInta()
        {
            int x1 = 5;
            ZwiekszNumer(x1);

            Assert.AreEqual(5, x1);
        }

        private void ZwiekszNumer(int numer)
        {
            numer = 15;
        }

        //Sprawdzamy przekazywanie przez referencje.
        [TestMethod]
        public void PrzekazywaniePrzezReferencje()
        {

            int x1 = 5;
            ZwiekszNumer(ref x1);

            Assert.AreEqual(15, x1);
        }

        private void ZwiekszNumer(ref int numer)
        {
            numer = 15;
        }

        //Testami sprawdzamy czy mamy rację czy nie mamy racji.
    }
}
