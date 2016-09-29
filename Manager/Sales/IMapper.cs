namespace IDesign.Manager.Sales
{
    public interface IMapper
    {
        TOut Map<TIn, TOut>(TIn instance);
        TOut Map<TOut>(object instance);
    }
}