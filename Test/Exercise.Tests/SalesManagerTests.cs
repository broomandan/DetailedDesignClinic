using IDesign.Contract.Online.Sales;
using IDesign.Manager.Sales;
using NUnit.Framework;
using ItemCriteria = IDesign.Contract.Online.Sales.ItemCriteria;

namespace Exercise.Tests
{
    [TestFixture]
    public class SalesManagerTests
    {
        private ISalesManager _sut;

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            AutoMapper.Mapper.Initialize(cfg => { cfg.AddProfile<MappingProfile>(); });
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
        }

        [Test]
        public void ShouldFindAnOrderItem()
        {
            _sut = new SalesManager();
            var criteria = new ItemCriteria();
            var actual = _sut.FindItem(criteria);
            Assert.That(actual, Is.TypeOf<Item>());
        }
    }
}