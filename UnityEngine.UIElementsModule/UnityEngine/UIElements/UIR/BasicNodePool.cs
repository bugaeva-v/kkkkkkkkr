using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000309 RID: 777
	internal class BasicNodePool<T> : LinkedPool<BasicNode<T>>
	{
		// Token: 0x0600199D RID: 6557 RVA: 0x00068ABA File Offset: 0x00066CBA
		private static void Reset(BasicNode<T> node)
		{
			node.next = null;
			node.data = default(T);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00068AD0 File Offset: 0x00066CD0
		private static BasicNode<T> Create()
		{
			return new BasicNode<T>();
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00068AE7 File Offset: 0x00066CE7
		public BasicNodePool() : base(new Func<BasicNode<T>>(BasicNodePool<T>.Create), new Action<BasicNode<T>>(BasicNodePool<T>.Reset), 10000)
		{
		}
	}
}
