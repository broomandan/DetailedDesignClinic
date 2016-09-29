namespace IDesign.Contract.Online.Sales
{
    public interface ISalesManager
    {
        void FindItem();
    }
}

namespace IDesign.Contract.Restaurant.Sales
{
    public interface ISalesManager
    {
        void FindItem();
    }
}

namespace IDesign.Manager.Sales
{
    using IDesign.Contract.Online.Sales;

    class SalesManager : ISalesManager, Contract.Restaurant.Sales.ISalesManager
    {
        void ISalesManager.FindItem()
        {
        }

        void Contract.Restaurant.Sales.ISalesManager.FindItem()
        {
        }
    }
}

namespace IDesign.Engine.Sales
{
    interface IValidationEngine
    {
    }

    interface IOrderingEngine
    {
    }
}

namespace IDesign.Engine.Customer
{
    interface IValidationEngine
    {
    }
}

namespace IDesign.Engine.Common
{
    using IDesign.Engine.Sales;

    class ValidationEngine : IValidationEngine, Customer.IValidationEngine
    {
    }
}

namespace IDesign.Access.Sales
{
    interface ICustomerAccess
    {
    }
}

