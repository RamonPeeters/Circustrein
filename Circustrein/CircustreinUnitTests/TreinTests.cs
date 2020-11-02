using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircustreinUnitTests
{
    [TestClass]
    public class TreinTests
    {
        [TestMethod]
        public void Trein_MoetTweeWagonsHebben()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>()
            {
                new Dier(Voedsel.Vlees, Grootte.Klein),
                new Dier(Voedsel.Planten, Grootte.Groot),
                new Dier(Voedsel.Planten, Grootte.Groot),
                new Dier(Voedsel.Planten, Grootte.Middelmatig),
                new Dier(Voedsel.Planten, Grootte.Middelmatig),
                new Dier(Voedsel.Planten, Grootte.Middelmatig)
            };
            trein.Verdeel(dieren);
            Assert.AreEqual(2, trein.GetWagons().Count);
        }

        [TestMethod]
        public void Trein_MoetEvenveelWagonsHebben_AlsVleesetendeDierenInTrein()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>()
            {
                new Dier(Voedsel.Vlees, Grootte.Klein),
                new Dier(Voedsel.Vlees, Grootte.Klein),
                new Dier(Voedsel.Vlees, Grootte.Klein),
                new Dier(Voedsel.Vlees, Grootte.Klein),
                new Dier(Voedsel.Vlees, Grootte.Klein)
            };
            trein.Verdeel(dieren);
            Assert.AreEqual(dieren.Count, trein.GetWagons().Count);
        }

        [TestMethod]
        public void Trein_MoetVijfKleinePlantenetendeDieren_InEenWagonZetten()
        {
            Trein trein = new Trein();
            List<Dier> dieren = new List<Dier>()
            {
                new Dier(Voedsel.Planten, Grootte.Klein),
                new Dier(Voedsel.Planten, Grootte.Klein),
                new Dier(Voedsel.Planten, Grootte.Klein),
                new Dier(Voedsel.Planten, Grootte.Klein),
                new Dier(Voedsel.Planten, Grootte.Klein)
            };
            trein.Verdeel(dieren);
            Assert.AreEqual(1, trein.GetWagons().Count);
        }
    }
}
