using ClassLibraryBouteille;

namespace UnitTestsBouteille
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OuvrirLaBouteilleSiElleEstFermee()
        {
            // Arrange
            Bouteille maBouteille1 = new(false, 1, 1);

            // Act
            bool ouvrirBouteille = maBouteille1.Ouvrir();

            //Assert
            Assert.IsTrue(ouvrirBouteille);
        }

        [TestMethod]
        public void OuvrirLaBouteilleSiElleEstDejaOuverte()
        {
            // Arrange
            Bouteille maBouteille2 = new(true, 1, 1);

            // Act
            bool ouvrirBouteille = maBouteille2.Ouvrir();

            //Assert
            Assert.IsFalse(ouvrirBouteille);
        }
    }
}