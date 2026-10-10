using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	public struct SortingLayer
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00005EC4 File Offset: 0x000040C4
		public int id
		{
			get
			{
				return this.m_Id;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00005EDC File Offset: 0x000040DC
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00005EFC File Offset: 0x000040FC
		public int value
		{
			get
			{
				return SortingLayer.GetLayerValueFromID(this.m_Id);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00005F1C File Offset: 0x0000411C
		public static SortingLayer[] layers
		{
			get
			{
				int[] sortingLayerIDsInternal = SortingLayer.GetSortingLayerIDsInternal();
				SortingLayer[] array = new SortingLayer[sortingLayerIDsInternal.Length];
				for (int i = 0; i < sortingLayerIDsInternal.Length; i++)
				{
					array[i].m_Id = sortingLayerIDsInternal[i];
				}
				return array;
			}
		}

		// Token: 0x06000384 RID: 900
		[FreeFunction("GetTagManager().GetSortingLayerIDs")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int[] GetSortingLayerIDsInternal();

		// Token: 0x06000385 RID: 901
		[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromID(int id);

		// Token: 0x06000386 RID: 902
		[FreeFunction("GetTagManager().GetSortingLayerValueFromName")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLayerValueFromName(string name);

		// Token: 0x06000387 RID: 903
		[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NameToID(string name);

		// Token: 0x06000388 RID: 904
		[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string IDToName(int id);

		// Token: 0x06000389 RID: 905
		[FreeFunction("GetTagManager().IsSortingLayerUniqueIDValid")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValid(int id);

		// Token: 0x040002E3 RID: 739
		private int m_Id;
	}
}
