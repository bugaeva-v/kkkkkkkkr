using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.Core;
using Castle.Core.Internal;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x02000157 RID: 343
	public class XmlReferenceManager
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00018CDC File Offset: 0x00016EDC
		public XmlReferenceManager(IXmlNode root, IXmlReferenceFormat format)
		{
			this.entriesById = new Dictionary<int, XmlReferenceManager.Entry>();
			this.entriesByValue = new WeakKeyDictionary<object, XmlReferenceManager.Entry>(ReferenceEqualityComparer<object>.Instance);
			this.format = format;
			this.nextId = 1;
			this.Populate(root);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00018D14 File Offset: 0x00016F14
		private void Populate(IXmlNode node)
		{
			List<XmlReferenceManager.Reference> references = new List<XmlReferenceManager.Reference>();
			IXmlIterator xmlIterator = node.SelectSubtree();
			while (xmlIterator.MoveNext())
			{
				this.PopulateFromNode(xmlIterator, references);
			}
			this.PopulateDeferredReferences(references);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00018D48 File Offset: 0x00016F48
		private void PopulateFromNode(IXmlIterator node, ICollection<XmlReferenceManager.Reference> references)
		{
			int id;
			if (this.format.TryGetIdentity(node, out id))
			{
				this.PopulateIdentity(id, node.Save());
				return;
			}
			if (this.format.TryGetReference(node, out id))
			{
				this.PopulateReference(id, node.Save(), references);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00018D94 File Offset: 0x00016F94
		private void PopulateIdentity(int id, IXmlNode node)
		{
			XmlReferenceManager.Entry entry;
			if (!this.entriesById.TryGetValue(id, out entry))
			{
				this.entriesById.Add(id, new XmlReferenceManager.Entry(id, node));
			}
			if (this.nextId <= id)
			{
				id = (this.nextId = id + 1);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00018DDC File Offset: 0x00016FDC
		private void PopulateReference(int id, IXmlNode node, ICollection<XmlReferenceManager.Reference> references)
		{
			XmlReferenceManager.Entry entry;
			if (this.entriesById.TryGetValue(id, out entry))
			{
				entry.AddReference(node);
				return;
			}
			references.Add(new XmlReferenceManager.Reference(id, node));
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00018E10 File Offset: 0x00017010
		private void PopulateDeferredReferences(ICollection<XmlReferenceManager.Reference> references)
		{
			foreach (XmlReferenceManager.Reference reference in references)
			{
				XmlReferenceManager.Entry entry;
				if (this.entriesById.TryGetValue(reference.Id, out entry))
				{
					entry.AddReference(reference.Node);
				}
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00018E74 File Offset: 0x00017074
		public bool TryGet(object keyObject, out object inGraphObject)
		{
			XmlReferenceManager.Entry entry;
			if (this.entriesByValue.TryGetValue(keyObject, out entry))
			{
				inGraphObject = keyObject;
				this.TryGetCompatibleValue(entry, keyObject.GetComponentType(), ref inGraphObject);
				return true;
			}
			inGraphObject = null;
			return false;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00018EAC File Offset: 0x000170AC
		public void Add(IXmlNode node, object keyValue, object newValue, bool isInGraph)
		{
			if (keyValue == null)
			{
				throw Error.ArgumentNull("keyValue");
			}
			if (newValue == null)
			{
				throw Error.ArgumentNull("newValue");
			}
			Type componentType = newValue.GetComponentType();
			if (XmlReferenceManager.ShouldExclude(componentType))
			{
				return;
			}
			if (this.entriesByValue.ContainsKey(newValue))
			{
				return;
			}
			XmlReferenceManager.Entry entry;
			if (this.entriesByValue.TryGetValue(keyValue, out entry))
			{
				if (newValue == keyValue)
				{
					return;
				}
			}
			else
			{
				if (node == null)
				{
					return;
				}
				bool flag;
				if (!this.TryGetEntry(node, out entry, out flag))
				{
					entry = new XmlReferenceManager.Entry(node);
				}
			}
			this.AddValueCore(entry, componentType, newValue, isInGraph);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00018F30 File Offset: 0x00017130
		public bool OnGetStarting(ref IXmlNode node, ref object value, out object token)
		{
			if (XmlReferenceManager.ShouldExclude(node.ClrType))
			{
				token = null;
				return true;
			}
			XmlReferenceManager.Entry entry;
			bool flag;
			if (!this.TryGetEntry(node, out entry, out flag))
			{
				token = XmlReferenceManager.CreateEntryToken;
				return true;
			}
			if (flag)
			{
				XmlReferenceManager.RedirectNode(ref node, entry);
			}
			bool flag2 = !this.TryGetCompatibleValue(entry, node.ClrType, ref value);
			token = (flag2 ? entry : null);
			return flag2;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00018F90 File Offset: 0x00017190
		public void OnGetCompleted(IXmlNode node, object value, object token)
		{
			if (value == null)
			{
				return;
			}
			Type clrType = node.ClrType;
			if (XmlReferenceManager.ShouldExclude(clrType))
			{
				return;
			}
			if (this.entriesByValue.ContainsKey(value))
			{
				return;
			}
			XmlReferenceManager.Entry entry = (token == XmlReferenceManager.CreateEntryToken) ? new XmlReferenceManager.Entry(node) : (token as XmlReferenceManager.Entry);
			if (entry == null)
			{
				return;
			}
			this.AddValue(entry, clrType, value, null);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00018FE8 File Offset: 0x000171E8
		public bool OnAssigningNull(IXmlNode node, object oldValue)
		{
			object obj = null;
			object obj2;
			return this.OnAssigningValue(node, oldValue, ref obj, out obj2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00019004 File Offset: 0x00017204
		public bool OnAssigningValue(IXmlNode node, object oldValue, ref object newValue, out object token)
		{
			if (newValue == oldValue && newValue != null)
			{
				token = null;
				return false;
			}
			XmlReferenceManager.Entry entry = this.OnReplacingValue(node, oldValue);
			if (newValue == null)
			{
				XmlReferenceManager.Entry oldEntry = entry;
				XmlReferenceManager.Entry newEntry = null;
				object token2;
				token = (token2 = null);
				return this.ShouldAssignmentProceed(oldEntry, newEntry, token2);
			}
			Type componentType = newValue.GetComponentType();
			if (XmlReferenceManager.ShouldExclude(componentType))
			{
				XmlReferenceManager.Entry oldEntry2 = entry;
				XmlReferenceManager.Entry newEntry2 = null;
				object token2;
				token = (token2 = null);
				return this.ShouldAssignmentProceed(oldEntry2, newEntry2, token2);
			}
			XmlAdapter xmlAdapter = XmlAdapter.For(newValue, false);
			XmlReferenceManager.Entry entry2;
			if (this.entriesByValue.TryGetValue(xmlAdapter ?? newValue, out entry2))
			{
				this.TryGetCompatibleValue(entry2, componentType, ref newValue);
				this.AddReference(node, entry2);
				token = null;
			}
			else
			{
				entry2 = (entry ?? new XmlReferenceManager.Entry(node));
				this.AddValue(entry2, componentType, newValue, xmlAdapter);
				this.format.ClearIdentity(node);
				this.format.ClearReference(node);
				token = entry2;
			}
			return this.ShouldAssignmentProceed(entry, entry2, token);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000190D6 File Offset: 0x000172D6
		private bool ShouldAssignmentProceed(XmlReferenceManager.Entry oldEntry, XmlReferenceManager.Entry newEntry, object token)
		{
			if (oldEntry != null && oldEntry != newEntry && oldEntry.Id > 0)
			{
				this.entriesById.Remove(oldEntry.Id);
			}
			return token != null || newEntry == null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00019104 File Offset: 0x00017304
		private XmlReferenceManager.Entry OnReplacingValue(IXmlNode node, object oldValue)
		{
			XmlReferenceManager.Entry entry;
			bool flag;
			if (oldValue == null)
			{
				if (!this.TryGetEntry(node, out entry, out flag))
				{
					return null;
				}
			}
			else
			{
				if (!this.entriesByValue.TryGetValue(oldValue, out entry))
				{
					return null;
				}
				flag = !entry.Node.PositionEquals(node);
			}
			if (flag)
			{
				entry.RemoveReference(node);
				this.ClearReference(entry, node);
				return null;
			}
			if (entry.References != null)
			{
				node = entry.RemoveReference(0);
				this.ClearReference(entry, node);
				entry.Node.CopyTo(node);
				entry.Node.Clear();
				entry.Node = node;
				return null;
			}
			this.PrepareForReuse(entry);
			return entry;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001919C File Offset: 0x0001739C
		public void OnAssignedValue(IXmlNode node, object givenValue, object storedValue, object token)
		{
			XmlReferenceManager.Entry entry = token as XmlReferenceManager.Entry;
			if (entry == null)
			{
				return;
			}
			if (givenValue == storedValue)
			{
				return;
			}
			XmlReferenceManager.SetNotInGraph(entry, givenValue);
			if (this.entriesByValue.ContainsKey(storedValue))
			{
				return;
			}
			this.AddValue(entry, node.ClrType, storedValue, null);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000191E0 File Offset: 0x000173E0
		private void AddReference(IXmlNode node, XmlReferenceManager.Entry entry)
		{
			if (!entry.Node.PositionEquals(node))
			{
				if (entry.References == null)
				{
					this.GenerateId(entry);
					this.format.SetIdentity(entry.Node, entry.Id);
				}
				node.Clear();
				entry.AddReference(node);
				this.format.SetReference(node, entry.Id);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00019240 File Offset: 0x00017440
		private void GenerateId(XmlReferenceManager.Entry entry)
		{
			if (entry.Id == 0)
			{
				int num = this.nextId;
				this.nextId = num + 1;
				entry.Id = num;
				this.entriesById.Add(entry.Id, entry);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001927E File Offset: 0x0001747E
		private void AddValue(XmlReferenceManager.Entry entry, Type type, object value, XmlAdapter xmlAdapter)
		{
			if (xmlAdapter == null)
			{
				xmlAdapter = XmlAdapter.For(value, false);
			}
			this.AddValueCore(entry, type, value, true);
			if (xmlAdapter != null)
			{
				this.AddValueCore(entry, typeof(XmlAdapter), xmlAdapter, true);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000192AF File Offset: 0x000174AF
		private void AddValueCore(XmlReferenceManager.Entry entry, Type type, object value, bool isInGraph)
		{
			entry.AddValue(type, value, isInGraph);
			this.entriesByValue.Add(value, entry);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000192C8 File Offset: 0x000174C8
		private void ClearReference(XmlReferenceManager.Entry entry, IXmlNode node)
		{
			this.format.ClearReference(node);
			if (entry.References == null)
			{
				this.format.ClearIdentity(entry.Node);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000192F0 File Offset: 0x000174F0
		private void PrepareForReuse(XmlReferenceManager.Entry entry)
		{
			foreach (XmlReferenceManager.EntryValue entryValue in entry.Values)
			{
				object target = entryValue.Value.Target;
				if (target != null)
				{
					this.entriesByValue.Remove(target);
				}
			}
			entry.Values.Clear();
			this.format.ClearIdentity(entry.Node);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00019374 File Offset: 0x00017574
		private bool TryGetEntry(IXmlNode node, out XmlReferenceManager.Entry entry, out bool reference)
		{
			int num;
			if (this.format.TryGetIdentity(node, out num))
			{
				reference = false;
			}
			else
			{
				if (!this.format.TryGetReference(node, out num))
				{
					reference = false;
					entry = null;
					return false;
				}
				reference = true;
			}
			if (!this.entriesById.TryGetValue(num, out entry))
			{
				throw XmlReferenceManager.IdNotFoundError(num);
			}
			return true;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000193CC File Offset: 0x000175CC
		private bool TryGetCompatibleValue(XmlReferenceManager.Entry entry, Type type, ref object value)
		{
			List<XmlReferenceManager.EntryValue> values = entry.Values;
			if (values == null)
			{
				return false;
			}
			IDictionaryAdapter dictionaryAdapter = null;
			foreach (XmlReferenceManager.EntryValue entryValue in values)
			{
				if (entryValue.IsInGraph)
				{
					object target = entryValue.Value.Target;
					if (target != null)
					{
						if (type.IsAssignableFrom(entryValue.Type) && target != null)
						{
							return Try.Success<object>(out value, target);
						}
						if (dictionaryAdapter == null)
						{
							dictionaryAdapter = (target as IDictionaryAdapter);
						}
					}
				}
			}
			if (dictionaryAdapter != null)
			{
				value = dictionaryAdapter.Coerce(type);
				entry.AddValue(type, value, true);
				return true;
			}
			return false;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00019480 File Offset: 0x00017680
		private static void SetNotInGraph(XmlReferenceManager.Entry entry, object value)
		{
			XmlAdapter xmlAdapter = XmlAdapter.For(value, false);
			XmlReferenceManager.SetNotInGraphCore(entry, value);
			if (xmlAdapter != null)
			{
				XmlReferenceManager.SetNotInGraphCore(entry, xmlAdapter);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000194A6 File Offset: 0x000176A6
		private static bool ShouldExclude(Type type)
		{
			return type.GetTypeInfo().IsValueType || type == XmlReferenceManager.StringType;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x000194C4 File Offset: 0x000176C4
		private static void SetNotInGraphCore(XmlReferenceManager.Entry entry, object value)
		{
			List<XmlReferenceManager.EntryValue> values = entry.Values;
			for (int i = 0; i < values.Count; i++)
			{
				XmlReferenceManager.EntryValue entryValue = values[i];
				if (entryValue.Value.Target == value)
				{
					entryValue = new XmlReferenceManager.EntryValue(entryValue.Type, entryValue.Value, false);
					values[i] = entryValue;
					return;
				}
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001951C File Offset: 0x0001771C
		private static IXmlNode RedirectNode(ref IXmlNode node, XmlReferenceManager.Entry entry)
		{
			IXmlCursor xmlCursor = entry.Node.SelectSelf(node.ClrType);
			xmlCursor.MoveNext();
			IXmlNode result;
			node = (result = xmlCursor);
			return result;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0001954C File Offset: 0x0001774C
		public void UnionWith(XmlReferenceManager other)
		{
			HashSet<XmlReferenceManager.Entry> hashSet = null;
			foreach (KeyValuePair<object, XmlReferenceManager.Entry> keyValuePair in other.entriesByValue)
			{
				XmlReferenceManager.Entry entry;
				if (this.entriesByValue.TryGetValue(keyValuePair.Key, out entry))
				{
					if (hashSet == null)
					{
						hashSet = new HashSet<XmlReferenceManager.Entry>(ReferenceEqualityComparer<XmlReferenceManager.Entry>.Instance);
					}
					else if (hashSet.Contains(entry))
					{
						continue;
					}
					hashSet.Add(entry);
					foreach (XmlReferenceManager.EntryValue entryValue in keyValuePair.Value.Values)
					{
						object target = entryValue.Value.Target;
						if (target != null && target != keyValuePair.Key && !this.entriesByValue.ContainsKey(target))
						{
							this.AddValueCore(entry, entryValue.Type, target, false);
						}
					}
				}
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00019654 File Offset: 0x00017854
		private static Exception IdNotFoundError(int id)
		{
			return new KeyNotFoundException(string.Format("The given ID ({0}) was not present in the underlying data.", id));
		}

		// Token: 0x0400022E RID: 558
		private readonly Dictionary<int, XmlReferenceManager.Entry> entriesById;

		// Token: 0x0400022F RID: 559
		private readonly WeakKeyDictionary<object, XmlReferenceManager.Entry> entriesByValue;

		// Token: 0x04000230 RID: 560
		private readonly IXmlReferenceFormat format;

		// Token: 0x04000231 RID: 561
		private int nextId;

		// Token: 0x04000232 RID: 562
		private static readonly Type StringType = typeof(string);

		// Token: 0x04000233 RID: 563
		private static readonly object CreateEntryToken = new object();

		// Token: 0x02000211 RID: 529
		private class Entry
		{
			// Token: 0x06000EF9 RID: 3833 RVA: 0x0002394B File Offset: 0x00021B4B
			public Entry(IXmlNode node)
			{
				this.Node = node.Save();
			}

			// Token: 0x06000EFA RID: 3834 RVA: 0x0002395F File Offset: 0x00021B5F
			public Entry(int id, IXmlNode node) : this(node)
			{
				this.Id = id;
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x0002396F File Offset: 0x00021B6F
			public void AddReference(IXmlNode node)
			{
				if (this.references == null)
				{
					this.references = new List<IXmlNode>();
				}
				this.references.Add(node);
			}

			// Token: 0x06000EFC RID: 3836 RVA: 0x00023990 File Offset: 0x00021B90
			public IXmlNode RemoveReference(IXmlNode node)
			{
				for (int i = 0; i < this.references.Count; i++)
				{
					if (this.references[i].PositionEquals(node))
					{
						return this.RemoveReference(i);
					}
				}
				return node;
			}

			// Token: 0x06000EFD RID: 3837 RVA: 0x000239D0 File Offset: 0x00021BD0
			public IXmlNode RemoveReference(int index)
			{
				IXmlNode result = this.references[index];
				this.references.RemoveAt(index);
				if (this.references.Count == 0)
				{
					this.references = null;
				}
				return result;
			}

			// Token: 0x06000EFE RID: 3838 RVA: 0x000239FE File Offset: 0x00021BFE
			public void AddValue(Type type, object value, bool isInGraph)
			{
				if (this.values == null)
				{
					this.values = new List<XmlReferenceManager.EntryValue>();
				}
				this.values.Add(new XmlReferenceManager.EntryValue(type, value, isInGraph));
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00023A26 File Offset: 0x00021C26
			public List<IXmlNode> References
			{
				get
				{
					return this.references;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00023A2E File Offset: 0x00021C2E
			public List<XmlReferenceManager.EntryValue> Values
			{
				get
				{
					return this.values;
				}
			}

			// Token: 0x0400040C RID: 1036
			public int Id;

			// Token: 0x0400040D RID: 1037
			public IXmlNode Node;

			// Token: 0x0400040E RID: 1038
			private List<IXmlNode> references;

			// Token: 0x0400040F RID: 1039
			private List<XmlReferenceManager.EntryValue> values;
		}

		// Token: 0x02000212 RID: 530
		private struct Reference
		{
			// Token: 0x06000F01 RID: 3841 RVA: 0x00023A36 File Offset: 0x00021C36
			public Reference(int id, IXmlNode node)
			{
				this.Id = id;
				this.Node = node;
			}

			// Token: 0x04000410 RID: 1040
			public readonly int Id;

			// Token: 0x04000411 RID: 1041
			public readonly IXmlNode Node;
		}

		// Token: 0x02000213 RID: 531
		private struct EntryValue
		{
			// Token: 0x06000F02 RID: 3842 RVA: 0x00023A46 File Offset: 0x00021C46
			public EntryValue(Type type, object value, bool isInGraph)
			{
				this = new XmlReferenceManager.EntryValue(type, new WeakReference(value), isInGraph);
			}

			// Token: 0x06000F03 RID: 3843 RVA: 0x00023A56 File Offset: 0x00021C56
			public EntryValue(Type type, WeakReference value, bool isInGraph)
			{
				this.Type = type;
				this.Value = value;
				this.IsInGraph = isInGraph;
			}

			// Token: 0x04000412 RID: 1042
			public readonly Type Type;

			// Token: 0x04000413 RID: 1043
			public readonly WeakReference Value;

			// Token: 0x04000414 RID: 1044
			public readonly bool IsInGraph;
		}
	}
}
