using IDesign.Contract.Online.Sales;
using IDesign.Engine.Sales;
using IDesign.Framework.Proxy;
using Moq;
using NUnit.Framework;
using Item = IDesign.Contract.Online.Sales.Item;
using ItemCriteria = IDesign.Contract.Online.Sales.ItemCriteria;

namespace IDesign.Manager.Sales.Test
{
    [TestFixture]
    public class SalesManagerTests
    {
        private ISalesManager _sut;
        private Mock<IMapper> _mapper;
        private Mock<IProxyFactory> _proxyFactory;
        private Mock<IMenuingEngine> _orderingEngine;


        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            _mapper = new Mock<IMapper>(MockBehavior.Strict);
            _proxyFactory = new Mock<IProxyFactory>(MockBehavior.Strict);
            _orderingEngine = new Mock<IMenuingEngine>(MockBehavior.Strict);
            _sut = new SalesManager(_mapper.Object, _proxyFactory.Object);
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
        }

        [Test]
        public void ShouldFindAnOrderItemWhenProvidedWithACriteria()
        {
            _mapper
                .Setup(x => x.Map<IDesign.Engine.Sales.ItemCriteria>(It.IsAny<ItemCriteria>()))
                .Returns(new Engine.Sales.ItemCriteria());

            _mapper
                .Setup(x => x.Map<Item>(It.IsAny<IDesign.Engine.Sales.Item>()))
                .Returns(new Item());
            
            _proxyFactory
                .Setup(x => x.Create<IMenuingEngine>())
                .Returns(_orderingEngine.Object);

            _orderingEngine
                .Setup(x => x.MathItem(It.IsAny<Engine.Sales.ItemCriteria>()))
                .Returns(new Engine.Sales.Item());

            var criteria = new ItemCriteria();
            var actual = _sut.FindItem(criteria);
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.TypeOf<Item>());
            //TODO: Add more assertions
        }
    }
}