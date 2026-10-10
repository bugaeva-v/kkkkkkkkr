using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000137 RID: 311
	public class BindingListInitializer<T> : IValueInitializer
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x00016A7C File Offset: 0x00014C7C
		public BindingListInitializer(Func<int, object, object> addAt, Func<object> addNew, Func<int, object, object> setAt, Action<int> removeAt, Action reset)
		{
			this.addAt = addAt;
			this.addNew = addNew;
			this.setAt = setAt;
			this.removeAt = removeAt;
			this.reset = reset;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00016AAC File Offset: 0x00014CAC
		public void Initialize(IDictionaryAdapter dictionaryAdapter, object value)
		{
			BindingList<T> bindingList = (BindingList<T>)value;
			if (this.addNew != null)
			{
				bindingList.AddingNew += delegate(object sender, AddingNewEventArgs args)
				{
					args.NewObject = this.addNew();
					this.addingNew = true;
				};
			}
			bindingList.ListChanged += delegate(object sender, ListChangedEventArgs args)
			{
				switch (args.ListChangedType)
				{
				case ListChangedType.Reset:
					if (this.reset != null)
					{
						this.reset();
						return;
					}
					return;
				case ListChangedType.ItemAdded:
					if (!this.addingNew && this.addAt != null)
					{
						object obj = this.addAt(args.NewIndex, bindingList[args.NewIndex]);
						if (obj != null)
						{
							using (new BindingListInitializer<T>.SuppressListChangedEvents(bindingList))
							{
								bindingList[args.NewIndex] = (T)((object)obj);
							}
						}
					}
					this.addingNew = false;
					return;
				case ListChangedType.ItemDeleted:
					break;
				case ListChangedType.ItemMoved:
					return;
				case ListChangedType.ItemChanged:
				{
					if (this.setAt == null)
					{
						return;
					}
					object obj2 = this.setAt(args.NewIndex, bindingList[args.NewIndex]);
					if (obj2 == null)
					{
						return;
					}
					using (new BindingListInitializer<T>.SuppressListChangedEvents(bindingList))
					{
						bindingList[args.NewIndex] = (T)((object)obj2);
						return;
					}
					break;
				}
				default:
					return;
				}
				if (this.removeAt != null)
				{
					this.removeAt(args.NewIndex);
					return;
				}
			};
		}

		// Token: 0x040001F1 RID: 497
		private readonly Func<object> addNew;

		// Token: 0x040001F2 RID: 498
		private readonly Func<int, object, object> addAt;

		// Token: 0x040001F3 RID: 499
		private readonly Func<int, object, object> setAt;

		// Token: 0x040001F4 RID: 500
		private readonly Action<int> removeAt;

		// Token: 0x040001F5 RID: 501
		private readonly Action reset;

		// Token: 0x040001F6 RID: 502
		private bool addingNew;

		// Token: 0x0200020B RID: 523
		private class SuppressListChangedEvents : IDisposable
		{
			// Token: 0x06000EE1 RID: 3809 RVA: 0x000233F6 File Offset: 0x000215F6
			public SuppressListChangedEvents(BindingList<T> bindingList)
			{
				this.bindingList = bindingList;
				this.raiseEvents = this.bindingList.RaiseListChangedEvents;
				this.bindingList.RaiseListChangedEvents = false;
			}

			// Token: 0x06000EE2 RID: 3810 RVA: 0x00023422 File Offset: 0x00021622
			public void Dispose()
			{
				this.bindingList.RaiseListChangedEvents = this.raiseEvents;
			}

			// Token: 0x040003F4 RID: 1012
			private readonly bool raiseEvents;

			// Token: 0x040003F5 RID: 1013
			private readonly BindingList<T> bindingList;
		}
	}
}
