using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using FluentNHibernate.Conventions.Inspections;

namespace LI.Collaborate.Mappings.Fluent.TypeConvention
{
    public class EnumConvention : IPropertyConvention, IPropertyConventionAcceptance
    {
        public void Apply(IPropertyInstance instance)
        {
            instance.CustomType(instance.Property.PropertyType);
        }

        public void Accept(IAcceptanceCriteria<IPropertyInspector> criteria)
        {
            criteria.Expect(x => x.Property.PropertyType.IsEnum ||
                (x.Property.PropertyType.IsGenericType &&
                x.Property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                x.Property.PropertyType.GetGenericArguments()[0].IsEnum)
                );
        }
    }
}
