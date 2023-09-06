using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests
{
    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FormatoCorrecto()
        {
            string input= "10/11/1997";
            string expected= "1997-11-10";

            string actual = DateFormatter.ChangeFormat(input);
            Assert.That(actual,Is.EqualTo(expected));
        }

        [Test]
        public void FormatoIncorrecto()
        {
            string input= "10.11.1997";
            string expected= "";

            string actual = DateFormatter.ChangeFormat(input);
            Assert.That(actual,Is.EqualTo(expected));
        }
        [Test]
        public void FormatoVacio()
        {
            string input= "";
            string expected= "";

            string actual = DateFormatter.ChangeFormat(input);
            Assert.AreEqual(actual, expected);
        }
    }
}