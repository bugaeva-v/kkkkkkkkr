using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Runtime
{
	// Token: 0x0200002A RID: 42
	public class InkList : Dictionary<InkListItem, int>
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00009D76 File Offset: 0x00007F76
		public InkList()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009D7E File Offset: 0x00007F7E
		public InkList(InkList otherList) : base(otherList)
		{
			this._originNames = otherList.originNames;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00009D94 File Offset: 0x00007F94
		public InkList(string singleOriginListName, Story originStory)
		{
			this.SetInitialOriginName(singleOriginListName);
			ListDefinition item;
			if (originStory.listDefinitions.TryListGetDefinition(singleOriginListName, out item))
			{
				this.origins = new List<ListDefinition>
				{
					item
				};
				return;
			}
			throw new Exception("InkList origin could not be found in story when constructing new list: " + singleOriginListName);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009DE1 File Offset: 0x00007FE1
		internal InkList(KeyValuePair<InkListItem, int> singleElement)
		{
			base.Add(singleElement.Key, singleElement.Value);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009E00 File Offset: 0x00008000
		public void AddItem(InkListItem item)
		{
			if (item.originName == null)
			{
				this.AddItem(item.itemName);
				return;
			}
			foreach (ListDefinition listDefinition in this.origins)
			{
				if (listDefinition.name == item.originName)
				{
					int value;
					if (listDefinition.TryGetValueForItem(item, out value))
					{
						base[item] = value;
						return;
					}
					string str = "Could not add the item ";
					InkListItem inkListItem = item;
					throw new Exception(str + inkListItem.ToString() + " to this list because it doesn't exist in the original list definition in ink.");
				}
			}
			throw new Exception("Failed to add item to list because the item was from a new list definition that wasn't previously known to this list. Only items from previously known lists can be used, so that the int value can be found.");
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009EB8 File Offset: 0x000080B8
		public void AddItem(string itemName)
		{
			ListDefinition listDefinition = null;
			foreach (ListDefinition listDefinition2 in this.origins)
			{
				if (listDefinition2.ContainsItemWithName(itemName))
				{
					if (listDefinition != null)
					{
						throw new Exception(string.Concat(new string[]
						{
							"Could not add the item ",
							itemName,
							" to this list because it could come from either ",
							listDefinition2.name,
							" or ",
							listDefinition.name
						}));
					}
					listDefinition = listDefinition2;
				}
			}
			if (listDefinition == null)
			{
				throw new Exception("Could not add the item " + itemName + " to this list because it isn't known to any list definitions previously associated with this list.");
			}
			InkListItem inkListItem = new InkListItem(listDefinition.name, itemName);
			int value = listDefinition.ValueForItem(inkListItem);
			base[inkListItem] = value;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00009F90 File Offset: 0x00008190
		public bool ContainsItemNamed(string itemName)
		{
			foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
			{
				if (keyValuePair.Key.itemName == itemName)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00009FF4 File Offset: 0x000081F4
		internal ListDefinition originOfMaxItem
		{
			get
			{
				if (this.origins == null)
				{
					return null;
				}
				string originName = this.maxItem.Key.originName;
				foreach (ListDefinition listDefinition in this.origins)
				{
					if (listDefinition.name == originName)
					{
						return listDefinition;
					}
				}
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000A078 File Offset: 0x00008278
		internal List<string> originNames
		{
			get
			{
				if (base.Count > 0)
				{
					if (this._originNames == null && base.Count > 0)
					{
						this._originNames = new List<string>();
					}
					else
					{
						this._originNames.Clear();
					}
					foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
					{
						this._originNames.Add(keyValuePair.Key.originName);
					}
				}
				return this._originNames;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000A110 File Offset: 0x00008310
		internal void SetInitialOriginName(string initialOriginName)
		{
			this._originNames = new List<string>
			{
				initialOriginName
			};
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000A124 File Offset: 0x00008324
		internal void SetInitialOriginNames(List<string> initialOriginNames)
		{
			if (initialOriginNames == null)
			{
				this._originNames = null;
				return;
			}
			this._originNames = new List<string>(initialOriginNames);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000A140 File Offset: 0x00008340
		public KeyValuePair<InkListItem, int> maxItem
		{
			get
			{
				KeyValuePair<InkListItem, int> result = default(KeyValuePair<InkListItem, int>);
				foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
				{
					if (result.Key.isNull || keyValuePair.Value > result.Value)
					{
						result = keyValuePair;
					}
				}
				return result;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000A1B4 File Offset: 0x000083B4
		public KeyValuePair<InkListItem, int> minItem
		{
			get
			{
				KeyValuePair<InkListItem, int> result = default(KeyValuePair<InkListItem, int>);
				foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
				{
					if (result.Key.isNull || keyValuePair.Value < result.Value)
					{
						result = keyValuePair;
					}
				}
				return result;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000A228 File Offset: 0x00008428
		public InkList inverse
		{
			get
			{
				InkList inkList = new InkList();
				if (this.origins != null)
				{
					foreach (ListDefinition listDefinition in this.origins)
					{
						foreach (KeyValuePair<InkListItem, int> keyValuePair in listDefinition.items)
						{
							if (!base.ContainsKey(keyValuePair.Key))
							{
								inkList.Add(keyValuePair.Key, keyValuePair.Value);
							}
						}
					}
				}
				return inkList;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public InkList all
		{
			get
			{
				InkList inkList = new InkList();
				if (this.origins != null)
				{
					foreach (ListDefinition listDefinition in this.origins)
					{
						foreach (KeyValuePair<InkListItem, int> keyValuePair in listDefinition.items)
						{
							inkList[keyValuePair.Key] = keyValuePair.Value;
						}
					}
				}
				return inkList;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000A388 File Offset: 0x00008588
		public InkList Union(InkList otherList)
		{
			InkList inkList = new InkList(this);
			foreach (KeyValuePair<InkListItem, int> keyValuePair in otherList)
			{
				inkList[keyValuePair.Key] = keyValuePair.Value;
			}
			return inkList;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000A3EC File Offset: 0x000085EC
		public InkList Intersect(InkList otherList)
		{
			InkList inkList = new InkList();
			foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
			{
				if (otherList.ContainsKey(keyValuePair.Key))
				{
					inkList.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return inkList;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000A460 File Offset: 0x00008660
		public InkList Without(InkList listToRemove)
		{
			InkList inkList = new InkList(this);
			foreach (KeyValuePair<InkListItem, int> keyValuePair in listToRemove)
			{
				inkList.Remove(keyValuePair.Key);
			}
			return inkList;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000A4C0 File Offset: 0x000086C0
		public bool Contains(InkList otherList)
		{
			foreach (KeyValuePair<InkListItem, int> keyValuePair in otherList)
			{
				if (!base.ContainsKey(keyValuePair.Key))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000A520 File Offset: 0x00008720
		public bool GreaterThan(InkList otherList)
		{
			return base.Count != 0 && (otherList.Count == 0 || this.minItem.Value > otherList.maxItem.Value);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000A560 File Offset: 0x00008760
		public bool GreaterThanOrEquals(InkList otherList)
		{
			return base.Count != 0 && (otherList.Count == 0 || (this.minItem.Value >= otherList.minItem.Value && this.maxItem.Value >= otherList.maxItem.Value));
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public bool LessThan(InkList otherList)
		{
			return otherList.Count != 0 && (base.Count == 0 || this.maxItem.Value < otherList.minItem.Value);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000A604 File Offset: 0x00008804
		public bool LessThanOrEquals(InkList otherList)
		{
			return otherList.Count != 0 && (base.Count == 0 || (this.maxItem.Value <= otherList.maxItem.Value && this.minItem.Value <= otherList.minItem.Value));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000A666 File Offset: 0x00008866
		internal InkList MaxAsList()
		{
			if (base.Count > 0)
			{
				return new InkList(this.maxItem);
			}
			return new InkList();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000A682 File Offset: 0x00008882
		internal InkList MinAsList()
		{
			if (base.Count > 0)
			{
				return new InkList(this.minItem);
			}
			return new InkList();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public override bool Equals(object other)
		{
			InkList inkList = other as InkList;
			if (inkList == null)
			{
				return false;
			}
			if (inkList.Count != base.Count)
			{
				return false;
			}
			foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
			{
				if (!inkList.ContainsKey(keyValuePair.Key))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000A71C File Offset: 0x0000891C
		public override int GetHashCode()
		{
			int num = 0;
			foreach (KeyValuePair<InkListItem, int> keyValuePair in this)
			{
				num += keyValuePair.Key.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000A780 File Offset: 0x00008980
		public override string ToString()
		{
			List<KeyValuePair<InkListItem, int>> list = new List<KeyValuePair<InkListItem, int>>();
			list.AddRange(this);
			list.Sort((KeyValuePair<InkListItem, int> x, KeyValuePair<InkListItem, int> y) => x.Value.CompareTo(y.Value));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < list.Count; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				InkListItem key = list[i].Key;
				stringBuilder.Append(key.itemName);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000131 RID: 305
		internal List<ListDefinition> origins;

		// Token: 0x04000132 RID: 306
		private List<string> _originNames;
	}
}
