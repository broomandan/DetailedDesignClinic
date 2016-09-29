using IDesign.Engine.Sales;

namespace IDesign.Engine.Sales
{
    interface IMenuingOrderingEngine
    {
        void Method1();
        void Method2();
    }


    interface IInquiryOrderingEngine
    {
        void Method1();
        void Method2();
    }
}

class OrderingEngine : IMenuingOrderingEngine, IInquiryOrderingEngine
{
    void IMenuingOrderingEngine.Method1()
    {
    }

    void IMenuingOrderingEngine.Method2()
    {
    }

    void IInquiryOrderingEngine.Method2()
    {
    }

    void IInquiryOrderingEngine.Method1()
    {
    }
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