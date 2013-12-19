using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace csWTFs
{
    [TestFixture]
    public class SchrodingerMu
    {
        [Test]
        public void IsMuEqualMu_WhenMµ()
        {
            Assert.That("μ".Equals("µ"), Is.False);
        }

        [Test]
        public void IsMuEqualMu_WhenMμ()
        {
            Assert.That("μ".Equals("μ"), Is.True);
        }

        [Test]
        public void IsMuEqualUpperCaseMu_WhenMμ()
        {
            Assert.That("μ".ToUpper().Equals("µ".ToUpper()), Is.True);
        }

        [Test]
        public void IsMuEqualLowerCaseMu_WhenMµ()
        {
            Assert.That("μ".ToLower().Equals("μ".ToLower()), Is.True);
        }

        [Test]
        public void IsMuEqualLowerCaseMu_WhenMμ()
        {
            Assert.That("μ".ToLower().Equals("μ"), Is.True);
        }

        [Test]
        public void IsMuEqualMu_WhenComparedInvariant()
        {
            Assert.That("μ".Equals("µ", StringComparison.InvariantCultureIgnoreCase), Is.False);            
        }


    }
}
