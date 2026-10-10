using System;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000125 RID: 293
	public interface IDictionaryEdit : IEditableObject, IRevertibleChangeTracking, IChangeTracking
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007F8 RID: 2040
		bool CanEdit { get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007F9 RID: 2041
		bool IsEditing { get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007FA RID: 2042
		// (set) Token: 0x060007FB RID: 2043
		bool SupportsMultiLevelEdit { get; set; }

		// Token: 0x060007FC RID: 2044
		IDisposable SuppressEditingBlock();

		// Token: 0x060007FD RID: 2045
		void SuppressEditing();

		// Token: 0x060007FE RID: 2046
		void ResumeEditing();
	}
}
