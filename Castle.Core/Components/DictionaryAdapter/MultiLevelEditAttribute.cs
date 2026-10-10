using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000102 RID: 258
	[AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
	public class MultiLevelEditAttribute : DictionaryBehaviorAttribute, IDictionaryInitializer, IDictionaryBehavior
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00013169 File Offset: 0x00011369
		public void Initialize(IDictionaryAdapter dictionaryAdapter, object[] behaviors)
		{
			dictionaryAdapter.SupportsMultiLevelEdit = true;
		}
	}
}
