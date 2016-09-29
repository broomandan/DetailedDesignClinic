namespace IDesign.Engine.Sales
{
    public class Item
    {
    }

    public class ItemCriteria
    {
    }

    public interface IMenuingEngine
    {
        Item MathItem(ItemCriteria criteria);
    }


    public interface IInquiryEngine
    {
       
    }


    public class OrderingEngine : IMenuingEngine, IInquiryEngine
    {
        public Item MathItem(ItemCriteria criteria)
        {
            // use user preference 
            // search in menu (criteria)  
            return new Item();
        }
    }
}