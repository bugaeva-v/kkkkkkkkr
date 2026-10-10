using System;

namespace UnityEngine
{
	// Token: 0x02000231 RID: 561
	public sealed class WaitWhile : CustomYieldInstruction
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00027004 File Offset: 0x00025204
		public override bool keepWaiting
		{
			get
			{
				return this.m_Predicate();
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00027021 File Offset: 0x00025221
		public WaitWhile(Func<bool> predicate)
		{
			this.m_Predicate = predicate;
		}

		// Token: 0x0400083A RID: 2106
		private Func<bool> m_Predicate;
	}
}
