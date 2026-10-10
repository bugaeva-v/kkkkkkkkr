using System;

namespace UnityEngine.SearchService
{
	// Token: 0x020002D6 RID: 726
	[AttributeUsage(AttributeTargets.Field)]
	[Obsolete("ObjectSelectorHandlerWithTagsAttribute has been deprecated. Use SearchContextAttribute instead.")]
	public class ObjectSelectorHandlerWithTagsAttribute : Attribute
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00030CC7 File Offset: 0x0002EEC7
		public string[] tags { get; }

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00030CCF File Offset: 0x0002EECF
		public ObjectSelectorHandlerWithTagsAttribute(params string[] tags)
		{
			this.tags = tags;
		}
	}
}
