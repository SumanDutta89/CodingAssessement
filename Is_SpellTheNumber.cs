using NUnit.Framework;

namespace SpellTheNumber.Tests
{
    [TestFixture]
    public class Is_SpellTheNumber
    {
        private Program _spellTheNumber;
        [SetUp]
        public void Setup()
        {
            _spellTheNumber = new Program();
        }

        [Test]
        public void SpellTheNumber_IsFalse()
        {
            var result = _spellTheNumber.convertToWord(1000340);

            Assert.AreEqual(result, "Ten Lakh Three Hundred and Forty");
        }
    }
}