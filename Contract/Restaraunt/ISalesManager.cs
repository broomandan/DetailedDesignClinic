namespace IDesign.Contract.Restaurant.Sales
{
    public interface ISalesManager
    {
        Item FindItem(ItemCriteria criteria);
    }

    public class ItemCriteria
    {
    }

    public class Item
    {
    }
}