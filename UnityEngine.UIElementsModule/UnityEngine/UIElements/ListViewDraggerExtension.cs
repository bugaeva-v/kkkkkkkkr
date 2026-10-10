using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B7 RID: 439
	internal static class ListViewDraggerExtension
	{
		// Token: 0x06000E63 RID: 3683 RVA: 0x0003C104 File Offset: 0x0003A304
		public static ReusableCollectionItem GetRecycledItemFromId(this BaseVerticalCollectionView listView, int id)
		{
			foreach (ReusableCollectionItem reusableCollectionItem in listView.activeItems)
			{
				bool flag = reusableCollectionItem.id.Equals(id);
				if (flag)
				{
					return reusableCollectionItem;
				}
			}
			return null;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0003C170 File Offset: 0x0003A370
		public static ReusableCollectionItem GetRecycledItemFromIndex(this BaseVerticalCollectionView listView, int index)
		{
			foreach (ReusableCollectionItem reusableCollectionItem in listView.activeItems)
			{
				bool flag = reusableCollectionItem.index.Equals(index);
				if (flag)
				{
					return reusableCollectionItem;
				}
			}
			return null;
		}
	}
}
