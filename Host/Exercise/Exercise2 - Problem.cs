using System.Runtime.Serialization;

namespace Clinic.Essentials.Exercise.Exercise2
{
   interface IMySmellyContract
   {
      void GetCustomeriPad();
      //void ProcessOrder();
      void GetNameGalaxyS5();
      void GetCount();
      //void UpdateCustomer();
     // void iPhoneProcessOrder();
    //  void GetCustomer();
   //   void GetName();
     // void SaveOrder();
      void GetCountiPhone();
      void GalaxyS5GetCustomer();
     // void ProcessOrderiPad();
    //  void SaveCustomer();
    //  void GetOrder();
   }

    enum DeviceType
    {
        IPhone,
        IPad,
        Galaxy
    }
    
    class OrderRequestContext
    {
        public DeviceType DeviceType { get; set; }
        
    }
    interface OrderManager
    {
        Order Get(OrderIdentity identity);
        void ProcessOrder(OrderRequestContext context);
        void Save(Order order);
        
    }

    internal class OrderIdentity
    {
    }

    internal class Order
    {
    }

    interface Customer
    {
        Customer Get(CustomerIdentity identity);
        void Save(Customer customer);
        void Update(Customer customer);
    }

    internal class CustomerIdentity
    {
    }
}
