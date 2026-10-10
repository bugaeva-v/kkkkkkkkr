using System;
using System.Collections.Generic;

namespace Ink.Runtime
{
	// Token: 0x0200002C RID: 44
	internal class ListDefinition
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000B9C7 File Offset: 0x00009BC7
		public string name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public Dictionary<InkListItem, int> items
		{
			get
			{
				if (this._items == null)
				{
					this._items = new Dictionary<InkListItem, int>();
					foreach (KeyValuePair<string, int> keyValuePair in this._itemNameToValues)
					{
						InkListItem key = new InkListItem(this.name, keyValuePair.Key);
						this._items[key] = keyValuePair.Value;
					}
				}
				return this._items;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public int ValueForItem(InkListItem item)
		{
			int result;
			if (this._itemNameToValues.TryGetValue(item.itemName, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000BA81 File Offset: 0x00009C81
		public bool ContainsItem(InkListItem item)
		{
			return !(item.originName != this.name) && this._itemNameToValues.ContainsKey(item.itemName);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000BAA9 File Offset: 0x00009CA9
		public bool ContainsItemWithName(string itemName)
		{
			return this._itemNameToValues.ContainsKey(itemName);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		public bool TryGetItemWithValue(int val, out InkListItem item)
		{
			foreach (KeyValuePair<string, int> keyValuePair in this._itemNameToValues)
			{
				if (keyValuePair.Value == val)
				{
					item = new InkListItem(this.name, keyValuePair.Key);
					return true;
				}
			}
			item = InkListItem.Null;
			return false;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000BB38 File Offset: 0x00009D38
		public bool TryGetValueForItem(InkListItem item, out int intVal)
		{
			return this._itemNameToValues.TryGetValue(item.itemName, out intVal);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public ListValue ListRange(int min, int max)
		{
			InkList inkList = new InkList();
			foreach (KeyValuePair<string, int> keyValuePair in this._itemNameToValues)
			{
				if (keyValuePair.Value >= min && keyValuePair.Value <= max)
				{
					InkListItem key = new InkListItem(this.name, keyValuePair.Key);
					inkList[key] = keyValuePair.Value;
				}
			}
			return new ListValue(inkList);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000BBDC File Offset: 0x00009DDC
		public ListDefinition(string name, Dictionary<string, int> items)
		{
			this._name = name;
			this._itemNameToValues = items;
		}

		// Token: 0x04000134 RID: 308
		private Dictionary<InkListItem, int> _items;

		// Token: 0x04000135 RID: 309
		private string _name;

		// Token: 0x04000136 RID: 310
		private Dictionary<string, int> _itemNameToValues;
	}
}
