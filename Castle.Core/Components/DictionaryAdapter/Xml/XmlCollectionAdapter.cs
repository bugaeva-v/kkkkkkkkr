using System;
using System.Collections.Generic;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000166 RID: 358
	internal class XmlCollectionAdapter<T> : ICollectionAdapter<T>, IXmlNodeSource
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x0001A6AC File Offset: 0x000188AC
		public XmlCollectionAdapter(IXmlNode parentNode, IDictionaryAdapter parentObject, IXmlCollectionAccessor accessor)
		{
			this.items = new List<XmlCollectionItem<T>>();
			this.accessor = accessor;
			this.cursor = accessor.SelectCollectionItems(parentNode, true);
			this.parentNode = parentNode;
			this.parentObject = parentObject;
			this.references = XmlAdapter.For(parentObject).References;
			while (this.cursor.MoveNext())
			{
				this.items.Add(new XmlCollectionItem<T>(this.cursor.Save()));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0001A728 File Offset: 0x00018928
		public IXmlNode Node
		{
			get
			{
				return this.parentNode;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0001A730 File Offset: 0x00018930
		public XmlReferenceManager References
		{
			get
			{
				return this.references;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0001A738 File Offset: 0x00018938
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001A745 File Offset: 0x00018945
		public void Initialize(ICollectionAdapterObserver<T> advisor)
		{
			this.advisor = advisor;
		}

		// Token: 0x170001EC RID: 492
		public T this[int index]
		{
			get
			{
				XmlCollectionItem<T> xmlCollectionItem = this.items[index];
				if (!xmlCollectionItem.HasValue)
				{
					xmlCollectionItem = (this.items[index] = xmlCollectionItem.WithValue(this.GetValue(xmlCollectionItem.Node)));
				}
				return xmlCollectionItem.Value;
			}
			set
			{
				XmlCollectionItem<T> xmlCollectionItem = this.items[index];
				this.cursor.MoveTo(xmlCollectionItem.Node);
				this.SetValue(this.cursor, xmlCollectionItem.Value, ref value);
				if (this.advisor.OnReplacing(xmlCollectionItem.Value, value))
				{
					this.items[index] = xmlCollectionItem.WithValue(value);
					this.advisor.OnReplaced(xmlCollectionItem.Value, value, index);
					return;
				}
				T value2 = xmlCollectionItem.Value;
				this.SetValue(this.cursor, value, ref value2);
				this.items[index] = xmlCollectionItem.WithValue(value2);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001A84C File Offset: 0x00018A4C
		public T AddNew()
		{
			this.cursor.MoveToEnd();
			this.cursor.Create(typeof(T));
			IXmlNode node = this.cursor.Save();
			T value = this.GetValue(node);
			int count = this.items.Count;
			this.CommitInsert(count, node, value, true);
			return value;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001A8A5 File Offset: 0x00018AA5
		public bool Add(T value)
		{
			return this.InsertCore(this.Count, value, true);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001A8B5 File Offset: 0x00018AB5
		public bool Insert(int index, T value)
		{
			return this.InsertCore(index, value, false);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		private bool InsertCore(int index, T value, bool append)
		{
			if (append)
			{
				this.cursor.MoveToEnd();
			}
			else
			{
				this.cursor.MoveTo(this.items[index].Node);
			}
			this.cursor.Create(XmlCollectionAdapter<T>.GetTypeOrDefault(value));
			IXmlNode node = this.cursor.Save();
			this.SetValue(this.cursor, default(T), ref value);
			if (!this.advisor.OnInserting(value))
			{
				return this.RollbackInsert();
			}
			return this.CommitInsert(index, node, value, append);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001A954 File Offset: 0x00018B54
		private bool CommitInsert(int index, IXmlNode node, T value, bool append)
		{
			XmlCollectionItem<T> item = new XmlCollectionItem<T>(node, value);
			if (append)
			{
				this.items.Add(item);
			}
			else
			{
				this.items.Insert(index, item);
			}
			this.advisor.OnInserted(value, index);
			return true;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001A997 File Offset: 0x00018B97
		private bool RollbackInsert()
		{
			this.cursor.Remove();
			return false;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		public void Remove(int index)
		{
			XmlCollectionItem<T> xmlCollectionItem = this.items[index];
			this.OnRemoving(xmlCollectionItem);
			this.cursor.MoveTo(xmlCollectionItem.Node);
			this.cursor.Remove();
			this.items.RemoveAt(index);
			this.advisor.OnRemoved(xmlCollectionItem.Value, index);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001AA04 File Offset: 0x00018C04
		public void Clear()
		{
			foreach (XmlCollectionItem<T> item in this.items)
			{
				this.OnRemoving(item);
			}
			this.cursor.Reset();
			this.cursor.RemoveAllNext();
			this.items.Clear();
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001AA78 File Offset: 0x00018C78
		public void ClearReferences()
		{
			if (this.accessor.IsReference)
			{
				foreach (XmlCollectionItem<T> xmlCollectionItem in this.items)
				{
					this.references.OnAssigningNull(xmlCollectionItem.Node, xmlCollectionItem.Value);
				}
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		private void OnRemoving(XmlCollectionItem<T> item)
		{
			this.advisor.OnRemoving(item.Value);
			if (this.accessor.IsReference)
			{
				this.references.OnAssigningNull(item.Node, item.Value);
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001AB30 File Offset: 0x00018D30
		private T GetValue(IXmlNode node)
		{
			object obj;
			if ((obj = this.accessor.GetValue(node, this.parentObject, this.references, true, true)) == null)
			{
				obj = default(T);
			}
			return (T)((object)obj);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001AB70 File Offset: 0x00018D70
		private void SetValue(IXmlCursor cursor, object oldValue, ref T value)
		{
			object obj = value;
			this.accessor.SetValue(cursor, this.parentObject, this.references, true, oldValue, ref obj);
			object obj2;
			if ((obj2 = obj) == null)
			{
				obj2 = default(T);
			}
			value = (T)((object)obj2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001ABC3 File Offset: 0x00018DC3
		private static Type GetTypeOrDefault(T value)
		{
			if (value != null)
			{
				return value.GetComponentType();
			}
			return typeof(T);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0001ABE3 File Offset: 0x00018DE3
		public IEqualityComparer<T> Comparer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0001ABE6 File Offset: 0x00018DE6
		public bool HasSnapshot
		{
			get
			{
				return this.snapshot != null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0001ABF1 File Offset: 0x00018DF1
		public int SnapshotCount
		{
			get
			{
				return this.snapshot.Count;
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001ABFE File Offset: 0x00018DFE
		public T GetCurrentItem(int index)
		{
			return this.items[index].Value;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001AC11 File Offset: 0x00018E11
		public T GetSnapshotItem(int index)
		{
			return this.snapshot[index].Value;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001AC24 File Offset: 0x00018E24
		public void SaveSnapshot()
		{
			this.snapshot = new List<XmlCollectionItem<T>>(this.items);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001AC37 File Offset: 0x00018E37
		public void LoadSnapshot()
		{
			this.items = this.snapshot;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001AC45 File Offset: 0x00018E45
		public void DropSnapshot()
		{
			this.snapshot = null;
		}

		// Token: 0x0400024D RID: 589
		private List<XmlCollectionItem<T>> items;

		// Token: 0x0400024E RID: 590
		private List<XmlCollectionItem<T>> snapshot;

		// Token: 0x0400024F RID: 591
		private ICollectionAdapterObserver<T> advisor;

		// Token: 0x04000250 RID: 592
		private readonly IXmlCursor cursor;

		// Token: 0x04000251 RID: 593
		private readonly IXmlCollectionAccessor accessor;

		// Token: 0x04000252 RID: 594
		private readonly IXmlNode parentNode;

		// Token: 0x04000253 RID: 595
		private readonly IDictionaryAdapter parentObject;

		// Token: 0x04000254 RID: 596
		private readonly XmlReferenceManager references;
	}
}
