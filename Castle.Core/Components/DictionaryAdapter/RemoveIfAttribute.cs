using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000106 RID: 262
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
	public class RemoveIfAttribute : DictionaryBehaviorAttribute, IDictionaryPropertySetter, IDictionaryBehavior
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x00013654 File Offset: 0x00011854
		public RemoveIfAttribute()
		{
			base.ExecutionOrder += 10;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001366B File Offset: 0x0001186B
		public RemoveIfAttribute(params object[] values) : this()
		{
			values = (values ?? new object[1]);
			this.condition = new RemoveIfAttribute.ValueCondition(values, null);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00013690 File Offset: 0x00011890
		public RemoveIfAttribute(object[] values, Type comparerType) : this()
		{
			IEqualityComparer comparer = RemoveIfAttribute.Construct<IEqualityComparer>(comparerType, "comparerType");
			this.condition = new RemoveIfAttribute.ValueCondition(values, comparer);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000136BC File Offset: 0x000118BC
		protected RemoveIfAttribute(ICondition condition) : this()
		{
			this.condition = condition;
		}

		// Token: 0x17000108 RID: 264
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x000136CB File Offset: 0x000118CB
		public Type Condition
		{
			set
			{
				this.condition = RemoveIfAttribute.Construct<ICondition>(value, "value");
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000136DE File Offset: 0x000118DE
		bool IDictionaryPropertySetter.SetPropertyValue(IDictionaryAdapter dictionaryAdapter, string key, ref object value, PropertyDescriptor property)
		{
			if (this.ShouldRemove(value))
			{
				dictionaryAdapter.ClearProperty(property, key);
				return false;
			}
			return true;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000136F6 File Offset: 0x000118F6
		internal bool ShouldRemove(object value)
		{
			return this.condition != null && this.condition.SatisfiedBy(value);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00013710 File Offset: 0x00011910
		private static TBase Construct<TBase>(Type type, string paramName) where TBase : class
		{
			if (type == null)
			{
				throw new ArgumentNullException(paramName);
			}
			if (!type.GetTypeInfo().IsAbstract && typeof(TBase).IsAssignableFrom(type))
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					return (TBase)((object)constructor.Invoke(new object[0]));
				}
			}
			throw new ArgumentException(string.Format("{0} is not a concrete type implementing {1} with a default constructor", type.FullName, typeof(TBase).FullName));
		}

		// Token: 0x040001A0 RID: 416
		private ICondition condition;

		// Token: 0x020001F9 RID: 505
		private class ValueCondition : ICondition
		{
			// Token: 0x06000E87 RID: 3719 RVA: 0x00022821 File Offset: 0x00020A21
			public ValueCondition(object[] values, IEqualityComparer comparer)
			{
				this.values = values;
				this.comparer = comparer;
			}

			// Token: 0x06000E88 RID: 3720 RVA: 0x00022838 File Offset: 0x00020A38
			public bool SatisfiedBy(object value)
			{
				return this.values.Any(delegate(object valueToMatch)
				{
					if (this.comparer == null)
					{
						return object.Equals(value, valueToMatch);
					}
					return this.comparer.Equals(value, valueToMatch);
				});
			}

			// Token: 0x040003BA RID: 954
			private readonly object[] values;

			// Token: 0x040003BB RID: 955
			private readonly IEqualityComparer comparer;
		}
	}
}
