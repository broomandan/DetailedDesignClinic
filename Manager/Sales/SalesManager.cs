using IDesign.Framework.Proxy;

namespace IDesign.Manager.Sales
{
    using Online = IDesign.Contract.Online.Sales;
    using Resaurant = IDesign.Contract.Restaurant.Sales;

    public class SalesManager : Online.ISalesManager, Resaurant.ISalesManager
    {
        private readonly IMapper _mapper;
        private readonly IProxyFactory _proxyFactory;

        public SalesManager(IMapper mapper, IProxyFactory proxyFactory)
        {
            _mapper = mapper;
            _proxyFactory = proxyFactory;
        }

        public Online.Item FindItem(Online.ItemCriteria criteria)
        {
            //TODO: Add validation
            var engineCriteria = _mapper.Map<IDesign.Engine.Sales.ItemCriteria>(criteria);
            var engine = _proxyFactory.Create<IDesign.Engine.Sales.IMenuingEngine>();

            var matchedItem = engine.MathItem(engineCriteria);

            var foundItem = _mapper.Map<Online.Item>(matchedItem);
            return foundItem;
        }

        public Resaurant.Item FindItem(Resaurant.ItemCriteria criteria)
        {
            return new Resaurant.Item();
        }
    }
}