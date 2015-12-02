using System.Collections;
using System.Collections.Generic;
using System.Windows.Markup;
using NUnit.Framework;

namespace ClamCardKata
{
    [TestFixture]
    public class ClamCardTests
    {
        [Test]
        public void Single_Journey_In_Zone_A_Correctly_Charged(
            [Values("Asterisk", "Antelope", "Aldgate", "Angel")] string originStation,
            [Values("Asterisk", "Antelope", "Aldgate", "Angel")] string destinationStation)
        {
            var card = new ClamCard();
            card.AddJourney(originStation, destinationStation);

            Assert.That(card.Total, Is.EqualTo(2.5));
        }

        [Test]
        public void Single_Journey_In_Zone_B_Correctly_Charged(
            [Values("Bison", "Bugel", "Balham", "Bullhead", "Barbican")] string originStation, 
            [Values("Bison", "Bugel", "Balham", "Bullhead", "Barbican")] string destinationStation)
        {
            var card = new ClamCard();
            card.AddJourney(originStation, destinationStation);

            Assert.That(card.Total, Is.EqualTo(3));
        }

        [Test]
        public void Single_Journey_From_Zone_A_to_Zone_B_Correctly_Charged(
            [Values("Asterisk", "Antelope", "Aldgate", "Angel")] string originStation,
            [Values("Bison", "Bugel", "Balham", "Bullhead", "Barbican")] string destinationStation)
        {
            var card = new ClamCard();
            card.AddJourney(originStation, destinationStation);

            Assert.That(card.Total, Is.EqualTo(3));
        }

        [Test]
        public void Single_Journey_From_Zone_B_to_Zone_A_Correctly_Charged(
            [Values("Bison", "Bugel", "Balham", "Bullhead", "Barbican")] string originStation,
            [Values("Asterisk", "Antelope", "Aldgate", "Angel")] string destinationStation)
        {
            var card = new ClamCard();
            card.AddJourney(originStation, destinationStation);

            Assert.That(card.Total, Is.EqualTo(3));
        }
    }

    public class ClamCard
    {
        public double Total;

        public void AddJourney(string originStation, string destinationStation)
        {
            IList<string> zoneAStations = new List<string> { "Asterisk", "Antelope", "Aldgate", "Angel" };

            if (zoneAStations.Contains(originStation) && zoneAStations.Contains(destinationStation))
                Total = 2.5;
            else Total = 3;
        }
    }
}
