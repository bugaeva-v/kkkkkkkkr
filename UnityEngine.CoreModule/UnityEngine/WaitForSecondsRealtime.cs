using System;

namespace UnityEngine
{
	// Token: 0x0200022F RID: 559
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00026F39 File Offset: 0x00025139
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x00026F41 File Offset: 0x00025141
		public float waitTime { get; set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00026F4C File Offset: 0x0002514C
		public override bool keepWaiting
		{
			get
			{
				bool flag = this.m_WaitUntilTime < 0f;
				if (flag)
				{
					this.m_WaitUntilTime = Time.realtimeSinceStartup + this.waitTime;
				}
				bool flag2 = Time.realtimeSinceStartup < this.m_WaitUntilTime;
				bool flag3 = !flag2;
				if (flag3)
				{
					this.Reset();
				}
				return flag2;
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00026FA3 File Offset: 0x000251A3
		public WaitForSecondsRealtime(float time)
		{
			this.waitTime = time;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00026FC0 File Offset: 0x000251C0
		public override void Reset()
		{
			this.m_WaitUntilTime = -1f;
		}

		// Token: 0x04000838 RID: 2104
		private float m_WaitUntilTime = -1f;
	}
}
