using System.Runtime.Serialization;
using IDesign.Contract.Sales;
using IDesign.Engine.Sales;

namespace IDesign.Contract.Sales
{
    public interface ISalesManager
    {
        Item FindItem(ItemCriteria criteria);
    }

    [DataContract]
    public class Item
    {
    }

    [DataContract]
    public class ItemCriteria
    {
    }
}

namespace IDesign.Manager.Sales
{
    public class SalesManager : ISalesManager
    {
        private readonly IMenuingOrderingEngine _menuingOrderingEngine;

        public SalesManager(IMenuingOrderingEngine orderingEngine)
        {
            _menuingOrderingEngine = orderingEngine;
        }

        public Contract.Sales.Item FindItem(Contract.Sales.ItemCriteria criteria)
        {
            var engineCriteria = AutoMapper.Mapper.Map<Engine.Sales.ItemCriteria>(criteria);
            var matchedItem = _menuingOrderingEngine.MathItem(engineCriteria);
            return AutoMapper.Mapper.Map<Contract.Sales.Item>(matchedItem);
        }
    }
}

namespace IDesign.Engine.Sales
{
//    public class Item
//    {
//    }
//
//    public class ItemCriteria
//    {
//    }
//
//    public interface IMenuingOrderingEngine
//    {
//        Item MathItem(ItemCriteria criteria);
//    }
//
//
//    interface IInquiryOrderingEngine
//    {
//    }
//
//
//    public class OrderingEngine : IMenuingOrderingEngine, IInquiryOrderingEngine
//    {
//        public Item MathItem(ItemCriteria criteria)
//        {
//            return new Item();
//        }
//    }
}

namespace IDesign.Access.Sales
{
    interface IProfileAccess
    {
        void Method1();
        void Method2();
    }

    interface IPreferenceAccess
    {
        void Method1();
        void Method2();
    }

    class CustomerAccess : IProfileAccess, IPreferenceAccess
    {
        void IProfileAccess.Method1()
        {
        }

        void IProfileAccess.Method2()
        {
        }

        void IPreferenceAccess.Method2()
        {
        }

        void IPreferenceAccess.Method1()
        {
        }
    }
}