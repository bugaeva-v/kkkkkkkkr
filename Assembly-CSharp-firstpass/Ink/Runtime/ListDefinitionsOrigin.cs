using System;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x0200002D RID: 45
	internal class ListDefinitionsOrigin
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		public List<ListDefinition> lists
		{
			get
			{
				List<ListDefinition> list = new List<ListDefinition>();
				foreach (KeyValuePair<string, ListDefinition> keyValuePair in this._lists)
				{
					list.Add(keyValuePair.Value);
				}
				return list;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000BC54 File Offset: 0x00009E54
		public ListDefinitionsOrigin(List<ListDefinition> lists)
		{
			this._lists = new Dictionary<string, ListDefinition>();
			this._allUnambiguousListValueCache = new Dictionary<string, ListValue>();
			foreach (ListDefinition listDefinition in lists)
			{
				this._lists[listDefinition.name] = listDefinition;
				foreach (KeyValuePair<InkListItem, int> keyValuePair in listDefinition.items)
				{
					InkListItem key = keyValuePair.Key;
					int value = keyValuePair.Value;
					ListValue value2 = new ListValue(key, value);
					this._allUnambiguousListValueCache[key.itemName] = value2;
					this._allUnambiguousListValueCache[key.fullName] = value2;
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000BD50 File Offset: 0x00009F50
		public bool TryListGetDefinition(string name, out ListDefinition def)
		{
			return this._lists.TryGetValue(name, out def);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000BD60 File Offset: 0x00009F60
		public ListValue FindSingleItemListWithName(string name)
		{
			ListValue result = null;
			this._allUnambiguousListValueCache.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x04000137 RID: 311
		private Dictionary<string, ListDefinition> _lists;

		// Token: 0x04000138 RID: 312
		private Dictionary<string, ListValue> _allUnambiguousListValueCache;
	}
}
