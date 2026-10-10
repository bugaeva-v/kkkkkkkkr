using System;

namespace UnityEngine.SearchService
{
	// Token: 0x020002D5 RID: 725
	[AttributeUsage(AttributeTargets.Field)]
	[Obsolete("ObjectSelectorHandlerWithLabelsAttribute has been deprecated. Use SearchContextAttribute instead.")]
	public class ObjectSelectorHandlerWithLabelsAttribute : Attribute
	{
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00030C87 File Offset: 0x0002EE87
		public string[] labels { get; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00030C8F File Offset: 0x0002EE8F
		public bool matchAll { get; }

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00030C97 File Offset: 0x0002EE97
		public ObjectSelectorHandlerWithLabelsAttribute(params string[] labels)
		{
			this.labels = labels;
			this.matchAll = 1;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00030CAF File Offset: 0x0002EEAF
		public ObjectSelectorHandlerWithLabelsAttribute(bool matchAll, params string[] labels)
		{
			this.labels = labels;
			this.matchAll = matchAll;
		}
	}
}
