using System;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000149 RID: 329
	public interface IVirtualTarget<TNode, TMember>
	{
		// Token: 0x060008E5 RID: 2277
		void OnRealizing(TNode node, TMember member);
	}
}
