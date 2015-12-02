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

    }

    public class ClamCard
    {
        public void AddJourney(string FromStation, string ToStation)
        {
            
        }

        public double Total()
        {
            return 2.5;
        }
    }
}
