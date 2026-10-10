using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Castle.Core;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x020000F8 RID: 248
	public abstract class AbstractDictionaryAdapterVisitor : IDictionaryAdapterVisitor
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00012D2A File Offset: 0x00010F2A
		protected AbstractDictionaryAdapterVisitor()
		{
			this.scopes = new Dictionary<IDictionaryAdapter, int>(ReferenceEqualityComparer<IDictionaryAdapter>.Instance);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00012D42 File Offset: 0x00010F42
		protected AbstractDictionaryAdapterVisitor(AbstractDictionaryAdapterVisitor parent)
		{
			this.scopes = parent.scopes;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00012D56 File Offset: 0x00010F56
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00012D5E File Offset: 0x00010F5E
		protected bool Cancelled { get; set; }

		// Token: 0x060006A3 RID: 1699 RVA: 0x00012D67 File Offset: 0x00010F67
		public virtual bool VisitDictionaryAdapter(IDictionaryAdapter dictionaryAdapter, object state)
		{
			return this.VisitDictionaryAdapter(dictionaryAdapter, null, null);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00012D74 File Offset: 0x00010F74
		public virtual bool VisitDictionaryAdapter(IDictionaryAdapter dictionaryAdapter, Func<PropertyDescriptor, bool> selector, object state)
		{
			if (!this.PushScope(dictionaryAdapter))
			{
				return false;
			}
			try
			{
				foreach (PropertyDescriptor propertyDescriptor in dictionaryAdapter.This.Properties.Values)
				{
					if (this.Cancelled)
					{
						break;
					}
					if (selector == null || selector(propertyDescriptor))
					{
						Type collectionItemType;
						if (AbstractDictionaryAdapterVisitor.IsCollection(propertyDescriptor, out collectionItemType))
						{
							this.VisitCollection(dictionaryAdapter, propertyDescriptor, collectionItemType, state);
						}
						else if (propertyDescriptor.PropertyType.GetTypeInfo().IsInterface)
						{
							this.VisitInterface(dictionaryAdapter, propertyDescriptor, state);
						}
						else
						{
							this.VisitProperty(dictionaryAdapter, propertyDescriptor, state);
						}
					}
				}
			}
			finally
			{
				this.PopScope(dictionaryAdapter);
			}
			return true;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00012E38 File Offset: 0x00011038
		void IDictionaryAdapterVisitor.VisitProperty(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
		{
			this.VisitProperty(dictionaryAdapter, property, state);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00012E43 File Offset: 0x00011043
		protected virtual void VisitProperty(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00012E45 File Offset: 0x00011045
		void IDictionaryAdapterVisitor.VisitInterface(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
		{
			this.VisitInterface(dictionaryAdapter, property, state);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00012E50 File Offset: 0x00011050
		protected virtual void VisitInterface(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, object state)
		{
			this.VisitProperty(dictionaryAdapter, property, state);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00012E5B File Offset: 0x0001105B
		void IDictionaryAdapterVisitor.VisitCollection(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, Type collectionItemType, object state)
		{
			this.VisitCollection(dictionaryAdapter, property, collectionItemType, state);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00012E68 File Offset: 0x00011068
		protected virtual void VisitCollection(IDictionaryAdapter dictionaryAdapter, PropertyDescriptor property, Type collectionItemType, object state)
		{
			this.VisitProperty(dictionaryAdapter, property, state);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00012E74 File Offset: 0x00011074
		private bool PushScope(IDictionaryAdapter dictionaryAdapter)
		{
			if (this.scopes.ContainsKey(dictionaryAdapter))
			{
				return false;
			}
			this.scopes.Add(dictionaryAdapter, 0);
			return true;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00012E94 File Offset: 0x00011094
		private void PopScope(IDictionaryAdapter dictionaryAdapter)
		{
			this.scopes.Remove(dictionaryAdapter);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00012EA4 File Offset: 0x000110A4
		private static bool IsCollection(PropertyDescriptor property, out Type collectionItemType)
		{
			collectionItemType = null;
			Type propertyType = property.PropertyType;
			if (propertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(propertyType))
			{
				if (propertyType.GetTypeInfo().IsArray)
				{
					collectionItemType = propertyType.GetElementType();
				}
				else if (propertyType.GetTypeInfo().IsGenericType)
				{
					Type[] genericArguments = propertyType.GetGenericArguments();
					collectionItemType = genericArguments[0];
				}
				else
				{
					collectionItemType = typeof(object);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0400018F RID: 399
		private readonly Dictionary<IDictionaryAdapter, int> scopes;
	}
}
