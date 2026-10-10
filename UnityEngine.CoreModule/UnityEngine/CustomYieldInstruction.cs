using System;
using System.Collections;

namespace UnityEngine
{
	// Token: 0x02000202 RID: 514
	public abstract class CustomYieldInstruction : IEnumerator
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060016B4 RID: 5812
		public abstract bool keepWaiting { get; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00024514 File Offset: 0x00022714
		public object Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00024528 File Offset: 0x00022728
		public bool MoveNext()
		{
			return this.keepWaiting;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00004563 File Offset: 0x00002763
		public virtual void Reset()
		{
		}
	}
}
