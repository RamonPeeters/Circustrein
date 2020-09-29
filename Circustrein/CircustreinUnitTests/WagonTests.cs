using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CircustreinUnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void PlantenetendDierBijVleesetendDier()
        {
            Wagon wagon = new Wagon();
            wagon.Add(new Dier(Voedsel.Vlees, Grootte.Groot));

            bool check = wagon.CanAdd(new Dier(Voedsel.Planten, Grootte.Klein));
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void VleesetendDierBijVleesetendDier()
        {
            Wagon wagon = new Wagon();
            wagon.Add(new Dier(Voedsel.Vlees, Grootte.Groot));

            bool check = wagon.CanAdd(new Dier(Voedsel.Vlees, Grootte.Klein));
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void GrootPlantenetendDierBijKleinVleesetendDier()
        {
            Wagon wagon = new Wagon();
            wagon.Add(new Dier(Voedsel.Vlees, Grootte.Klein));

            bool check = wagon.CanAdd(new Dier(Voedsel.Planten, Grootte.Groot));
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void DierToevoegenAanVolleWagon()
        {
            Wagon wagon = new Wagon();
            wagon.Add(new Dier(Voedsel.Planten, Grootte.Groot));
            wagon.Add(new Dier(Voedsel.Planten, Grootte.Groot));

            bool check = wagon.CanAdd(new Dier(Voedsel.Planten, Grootte.Groot));
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void OptimaalBenutteTrein()
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
    }
}
