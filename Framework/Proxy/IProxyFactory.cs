namespace IDesign.Framework.Proxy
{
    public interface IProxyFactory
    {
        I Create<I>() where I : class;
    }
}