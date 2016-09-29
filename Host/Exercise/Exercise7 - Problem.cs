using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace IDesign.Framework.Repository
{
   [AttributeUsage(AttributeTargets.Class)]
   class Table : Attribute
   {}
   [AttributeUsage(AttributeTargets.Property)]
   class Column : Attribute
   {}
   abstract class TableBase
   {}

   interface IRepository
   {
      T Get<T>(string key) where T : TableBase,new();
   }
   class Repository : IRepository
   {
      public T Get<T>(string key) where T : TableBase,new()
      {
         return new T();
      }
   }

   static class RepositoryFactory
   {
      static Type GetRepositoryType<I>() where I : class
      {
         string typeName = string.Empty;

         string repositoryName = typeof(I).Name.Replace("I","");
         typeName = typeof(I).Namespace + "." + repositoryName;

         Type implementationType = typeof(I).Assembly.GetType(typeName);
         Debug.Assert(implementationType != null, "You did not follow the rules...");

         return implementationType;
      }
      public static I Create<I>() where I : class,IRepository
      {
         return Activator.CreateInstance(GetRepositoryType<I>()) as I;
      }
   }
}

namespace IDesign.Repository.Sales
{
   using IDesign.Framework.Repository;

   //Our Entity...
   [Table]
   class Customer : TableBase
   {
      [Column]
      public string Name
      {get;set;}
   }
   interface ICustomerRepository : IRepository
   {}
   class CustomerRepository : Repository,ICustomerRepository
   {}
}