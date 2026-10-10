using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200040E RID: 1038
	public struct ScopedRenderPass : IDisposable
	{
		// Token: 0x0600237D RID: 9085 RVA: 0x0003BFBD File Offset: 0x0003A1BD
		internal ScopedRenderPass(ScriptableRenderContext context)
		{
			this.m_Context = context;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
		public void Dispose()
		{
			try
			{
				this.m_Context.EndRenderPass();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("The ScopedRenderPass instance is not valid. This can happen if it was constructed using the default constructor.", innerException);
			}
		}

		// Token: 0x04000D36 RID: 3382
		private ScriptableRenderContext m_Context;
	}
}
