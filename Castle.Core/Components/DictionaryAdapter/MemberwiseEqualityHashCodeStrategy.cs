using System;
using System.Collections;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000131 RID: 305
	public class MemberwiseEqualityHashCodeStrategy : DictionaryBehaviorAttribute, IDictionaryEqualityHashCodeStrategy, IDictionaryInitializer, IDictionaryBehavior, IEqualityComparer<IDictionaryAdapter>
	{
		// Token: 0x0600081A RID: 2074 RVA: 0x00015FC8 File Offset: 0x000141C8
		public bool Equals(IDictionaryAdapter adapter1, IDictionaryAdapter adapter2)
		{
			return adapter1 == adapter2 || (!(adapter1 == null ^ adapter2 == null) && !(adapter1.Meta.Type != adapter2.Meta.Type) && this.GetHashCode(adapter1) == this.GetHashCode(adapter2));
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00016018 File Offset: 0x00014218
		public int GetHashCode(IDictionaryAdapter adapter)
		{
			int result;
			this.GetHashCode(adapter, out result);
			return result;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00016030 File Offset: 0x00014230
		public bool GetHashCode(IDictionaryAdapter adapter, out int hashCode)
		{
			hashCode = new MemberwiseEqualityHashCodeStrategy.HashCodeVisitor().CalculateHashCode(adapter);
			return true;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00016040 File Offset: 0x00014240
		void IDictionaryInitializer.Initialize(IDictionaryAdapter dictionaryAdapter, object[] behaviors)
		{
			dictionaryAdapter.This.EqualityHashCodeStrategy = this;
		}

		// Token: 0x0200020A RID: 522
		private class HashCodeVisitor : AbstractDictionaryAdapterVisitor
		{
			// Token: 0x06000ED8 RID: 3800 RVA: 0x00023249 File Offset: 0x00021449
			public int CalculateHashCode(IDictionaryAdapter dictionaryAdapter)
			{
				if (dictionaryAdapter == null)
				{
					return 0;
				}
				this.hashCode = 27;
				if (!this.VisitDictionaryAdapter(dictionaryAdapter, null))
				{
					return 0;
				}
				return this.hashCode;
			}

			// Token: 0x06000ED9 RID: 3801 RVA: 0x0002326C File Offset: 0x0002146C
			protected override void VisitProperty(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
			{
				object property2 = dictionaryAdapter.GetProperty(property.PropertyName, true);
				this.CollectHashCode(property, this.GetValueHashCode(property2));
			}

			// Token: 0x06000EDA RID: 3802 RVA: 0x00023298 File Offset: 0x00021498
			protected override void VisitInterface(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
			{
				IDictionaryAdapter nested = (IDictionaryAdapter)dictionaryAdapter.GetProperty(property.PropertyName, true);
				this.CollectHashCode(property, this.GetNestedHashCode(nested));
			}

			// Token: 0x06000EDB RID: 3803 RVA: 0x000232C8 File Offset: 0x000214C8
			protected override void VisitCollection(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, Type collectionItemType, object state)
			{
				IEnumerable collection = (IEnumerable)dictionaryAdapter.GetProperty(property.PropertyName, true);
				this.CollectHashCode(property, this.GetCollectionHashcode(collection));
			}

			// Token: 0x06000EDC RID: 3804 RVA: 0x000232F6 File Offset: 0x000214F6
			private int GetValueHashCode(object value)
			{
				if (value == null)
				{
					return 0;
				}
				if (value is IDictionaryAdapter)
				{
					return this.GetNestedHashCode((IDictionaryAdapter)value);
				}
				if (value is IEnumerable && !(value is string))
				{
					return this.GetCollectionHashcode((IEnumerable)value);
				}
				return value.GetHashCode();
			}

			// Token: 0x06000EDD RID: 3805 RVA: 0x00023338 File Offset: 0x00021538
			private int GetNestedHashCode(IDictionaryAdapter nested)
			{
				int num = this.hashCode;
				int result = this.CalculateHashCode(nested);
				this.hashCode = num;
				return result;
			}

			// Token: 0x06000EDE RID: 3806 RVA: 0x0002335C File Offset: 0x0002155C
			private int GetCollectionHashcode(IEnumerable collection)
			{
				if (collection == null)
				{
					return 0;
				}
				int num = 0;
				foreach (object value in collection)
				{
					int valueHashCode = this.GetValueHashCode(value);
					num = 13 * num + valueHashCode;
				}
				return num;
			}

			// Token: 0x06000EDF RID: 3807 RVA: 0x000233C0 File Offset: 0x000215C0
			private void CollectHashCode(PropertyDescriptor property, int valueHashCode)
			{
				this.hashCode = 13 * this.hashCode + property.PropertyName.GetHashCode();
				this.hashCode = 13 * this.hashCode + valueHashCode;
			}

			// Token: 0x040003F3 RID: 1011
			private int hashCode;
		}
	}
}
