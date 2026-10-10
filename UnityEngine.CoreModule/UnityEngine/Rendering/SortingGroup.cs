using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200042A RID: 1066
	[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002527 RID: 9511
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static extern int invalidSortingGroupID { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06002528 RID: 9512
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateAllSortingGroups();

		// Token: 0x06002529 RID: 9513
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern SortingGroup GetSortingGroupByIndex(int index);

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600252A RID: 9514
		// (set) Token: 0x0600252B RID: 9515
		public extern string sortingLayerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600252C RID: 9516
		// (set) Token: 0x0600252D RID: 9517
		public extern int sortingLayerID { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600252E RID: 9518
		// (set) Token: 0x0600252F RID: 9519
		public extern int sortingOrder { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002530 RID: 9520
		internal extern int sortingGroupID { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002531 RID: 9521
		internal extern int sortingGroupOrder { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002532 RID: 9522
		internal extern int index { [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
