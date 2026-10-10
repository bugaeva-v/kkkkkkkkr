using System;
using System.Collections.Generic;
using UnityEngine;

namespace DG.DemiLib.External
{
	// Token: 0x0200000A RID: 10
	public class DeHierarchyComponent : MonoBehaviour
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002604 File Offset: 0x00000804
		public List<int> MissingItemsIndexes()
		{
			List<int> list = null;
			for (int i = this.customizedItems.Count - 1; i > -1; i--)
			{
				if (this.customizedItems[i].gameObject == null)
				{
					if (list == null)
					{
						list = new List<int>();
					}
					list.Add(i);
				}
			}
			return list;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002658 File Offset: 0x00000858
		public void StoreItemColor(GameObject go, DeHierarchyComponent.HColor hColor)
		{
			foreach (DeHierarchyComponent.CustomizedItem customizedItem in this.customizedItems)
			{
				if (!(customizedItem.gameObject != go))
				{
					customizedItem.hColor = hColor;
					return;
				}
			}
			this.customizedItems.Add(new DeHierarchyComponent.CustomizedItem(go, hColor));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000026D0 File Offset: 0x000008D0
		public void StoreItemIcon(GameObject go, DeHierarchyComponent.IcoType icoType)
		{
			foreach (DeHierarchyComponent.CustomizedItem customizedItem in this.customizedItems)
			{
				if (!(customizedItem.gameObject != go))
				{
					customizedItem.icoType = icoType;
					return;
				}
			}
			this.customizedItems.Add(new DeHierarchyComponent.CustomizedItem(go, icoType));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002748 File Offset: 0x00000948
		public bool RemoveItemData(GameObject go)
		{
			int num = -1;
			for (int i = 0; i < this.customizedItems.Count; i++)
			{
				if (this.customizedItems[i].gameObject == go)
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				this.customizedItems.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027A0 File Offset: 0x000009A0
		public DeHierarchyComponent.CustomizedItem GetItem(GameObject go)
		{
			foreach (DeHierarchyComponent.CustomizedItem customizedItem in this.customizedItems)
			{
				if (customizedItem.gameObject == go)
				{
					return customizedItem;
				}
			}
			return null;
		}

		// Token: 0x0400001A RID: 26
		public List<DeHierarchyComponent.CustomizedItem> customizedItems = new List<DeHierarchyComponent.CustomizedItem>();

		// Token: 0x0200000C RID: 12
		public enum HColor
		{
			// Token: 0x0400001D RID: 29
			None,
			// Token: 0x0400001E RID: 30
			Blue,
			// Token: 0x0400001F RID: 31
			Green,
			// Token: 0x04000020 RID: 32
			Orange,
			// Token: 0x04000021 RID: 33
			Purple,
			// Token: 0x04000022 RID: 34
			Red,
			// Token: 0x04000023 RID: 35
			Yellow,
			// Token: 0x04000024 RID: 36
			BrightGrey,
			// Token: 0x04000025 RID: 37
			DarkGrey,
			// Token: 0x04000026 RID: 38
			Black,
			// Token: 0x04000027 RID: 39
			White
		}

		// Token: 0x0200000D RID: 13
		public enum IcoType
		{
			// Token: 0x04000029 RID: 41
			Dot,
			// Token: 0x0400002A RID: 42
			Star,
			// Token: 0x0400002B RID: 43
			Cog,
			// Token: 0x0400002C RID: 44
			Comment,
			// Token: 0x0400002D RID: 45
			UI,
			// Token: 0x0400002E RID: 46
			Play
		}

		// Token: 0x0200000E RID: 14
		[Serializable]
		public class CustomizedItem
		{
			// Token: 0x06000020 RID: 32 RVA: 0x00002817 File Offset: 0x00000A17
			public CustomizedItem(GameObject gameObject, DeHierarchyComponent.HColor hColor)
			{
				this.gameObject = gameObject;
				this.hColor = hColor;
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00002834 File Offset: 0x00000A34
			public CustomizedItem(GameObject gameObject, DeHierarchyComponent.IcoType icoType)
			{
				this.gameObject = gameObject;
				this.icoType = icoType;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00002854 File Offset: 0x00000A54
			public Color GetColor()
			{
				switch (this.hColor)
				{
				case DeHierarchyComponent.HColor.Blue:
					return new Color(0.2145329f, 0.4501492f, 0.9117647f, 1f);
				case DeHierarchyComponent.HColor.Green:
					return new Color(0.05060553f, 0.8602941f, 0.2237113f, 1f);
				case DeHierarchyComponent.HColor.Orange:
					return new Color(0.9558824f, 0.4471125f, 0.05622837f, 1f);
				case DeHierarchyComponent.HColor.Purple:
					return new Color(0.907186f, 0.05406574f, 0.9191176f, 1f);
				case DeHierarchyComponent.HColor.Red:
					return new Color(0.9191176f, 0.1617312f, 0.07434041f, 1f);
				case DeHierarchyComponent.HColor.Yellow:
					return new Color(1f, 0.853854f, 0.03676468f, 1f);
				case DeHierarchyComponent.HColor.BrightGrey:
					return new Color(0.6470588f, 0.6470588f, 0.6470588f, 1f);
				case DeHierarchyComponent.HColor.DarkGrey:
					return new Color(0.3308824f, 0.3308824f, 0.3308824f, 1f);
				case DeHierarchyComponent.HColor.Black:
					return Color.black;
				case DeHierarchyComponent.HColor.White:
					return Color.white;
				default:
					return Color.white;
				}
			}

			// Token: 0x0400002F RID: 47
			public GameObject gameObject;

			// Token: 0x04000030 RID: 48
			public DeHierarchyComponent.HColor hColor = DeHierarchyComponent.HColor.BrightGrey;

			// Token: 0x04000031 RID: 49
			public DeHierarchyComponent.IcoType icoType;
		}
	}
}
