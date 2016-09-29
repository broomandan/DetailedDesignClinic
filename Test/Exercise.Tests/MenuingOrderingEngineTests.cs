using IDesign.Engine.Sales;
using NUnit.Framework;

namespace Exercise.Tests
{
    [TestFixture]
    public class MenuingOrderingEngineTests
    {
        private IMenuingEngine _sut;

        [Test]
        public void ShouldMatchItem()
        {
            _sut = new OrderingEngine();

            IDesign.Engine.Sales.ItemCriteria criteria = null;
            var actual = _sut.MathItem(criteria);
            Assert.That(actual, Is.TypeOf<IDesign.Engine.Sales.Item>());
        }
    }
}