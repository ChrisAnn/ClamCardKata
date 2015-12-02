using NUnit.Framework;

namespace ClamCardKata
{
    [TestFixture]
    public class ClamCardTests
    {
        [Test]
        public void Single_Journey_In_Zone_A_Correctly_Charged()
        {
            var card = new ClamCard();
            card.AddJourney("Asterisk", "Aldgate");

            Assert.That(card.Total, Is.EqualTo(2.5));
        }

        [Test]
        public void Single_Journey_In_Zone_B_Correctly_Charged()
        {
            var card = new ClamCard();
            card.AddJourney("Barbican", "Balham");

            Assert.That(card.Total, Is.EqualTo(3));
        }
    }

    public class ClamCard
    {
        public double Total;

        public void AddJourney(string originStation, string destinationStation)
        {
            if (originStation == "Asterisk" && destinationStation == "Aldgate")
                Total = 2.5;
            else Total = 3;
        }
    }
}
