using CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircustreinUnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void VleesetendDier_KanNietToegevoegdWordenAanWagon_MetVleesetendDier()
        {
            // Arrange
            Wagon wagon = new Wagon(new Dier(Voedsel.Vlees, Grootte.Groot));

            // Act
            bool added = wagon.TryAdd(new Dier(Voedsel.Vlees, Grootte.Klein));

            // Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void GrootVleesetendDier_KanNietToegevoegdWordenAanWagon_MetKleinPlantenetendDier()
        {
            // Arrange
            Wagon wagon = new Wagon(new Dier(Voedsel.Planten, Grootte.Klein));

            // Act
            bool added = wagon.TryAdd(new Dier(Voedsel.Vlees, Grootte.Groot));

            // Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void GrootPlantenetendDier_KanToegevoegdWordenAanWagon_MetKleinVleesetendDier()
        {
            // Arrange
            Wagon wagon = new Wagon(new Dier(Voedsel.Vlees, Grootte.Klein));

            // Act
            bool check = wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Groot));

            // Assert
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void KleinPlantenetendDier_KanNietToegevoegdWordenAanWagon_MetGrootVleesetendDier()
        {
            // Arrange
            Wagon wagon = new Wagon(new Dier(Voedsel.Vlees, Grootte.Groot));

            // Act
            bool added = wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Klein));

            // Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void Dier_KanToegevoegdWorden_AanLegeWagon()
        {
            // Arrange
            Wagon wagon = new Wagon();

            // Act
            bool added = wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Groot));

            // Assert
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void Dier_KanNietToegevoegdWorden_AanVolleWagon()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Groot));
            wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Groot));

            // Act
            bool added = wagon.TryAdd(new Dier(Voedsel.Planten, Grootte.Groot));

            // Assert
            Assert.IsFalse(added);
        }
    }
}
