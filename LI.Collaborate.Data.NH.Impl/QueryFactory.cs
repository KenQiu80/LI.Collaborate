using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LI.Collaborate.Data.NH;

using Microsoft.Practices.ServiceLocation;

using NHibernate;

namespace LI.Collaborate.Data.NH.Impl
{
    public class QueryFactory : IQueryFactory
    {
        private readonly IServiceLocator serviceLocator;

        public QueryFactory(IServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        public TQuery CreateQuery<TQuery>() where TQuery : Data.INHibernateQuery
        {
            return serviceLocator.GetInstance<TQuery>();
        }
    }
}