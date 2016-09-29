namespace IDesign.Manager.Sales
{
    using Online = IDesign.Contract.Online.Sales;
    using Resaurant = IDesign.Contract.Restaurant.Sales;

    public class SalesManager : Online.ISalesManager, Resaurant.ISalesManager
    {
        public Online.Item FindItem(Online.ItemCriteria criteria)
        {
            // add validation
            var engineCriteria = AutoMapper.Mapper.Map<IDesign.Engine.Sales.ItemCriteria>(criteria);
            var engine = IDesign.Framework.Proxy.ProxyFactory.Create<IDesign.Engine.Sales.IMenuingEngine>();
            var matchedItem = engine.MathItem(engineCriteria);
            return AutoMapper.Mapper.Map<Online.Item>(matchedItem);
        }

        public Resaurant.Item FindItem(Resaurant.ItemCriteria criteria)
        {
            var engineCriteria = AutoMapper.Mapper.Map<IDesign.Engine.Sales.ItemCriteria>(criteria);
            var engine = IDesign.Framework.Proxy.ProxyFactory.Create<IDesign.Engine.Sales.IMenuingEngine>();
            var matchedItem = engine.MathItem(engineCriteria);
            return AutoMapper.Mapper.Map<Resaurant.Item>(matchedItem);
        }
    }
}