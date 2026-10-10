using System;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000472 RID: 1138
	public abstract class ScriptableRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x00042F3C File Offset: 0x0004113C
		public virtual bool TickRealtimeProbes()
		{
			return false;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00004563 File Offset: 0x00002763
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00042F4F File Offset: 0x0004114F
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
