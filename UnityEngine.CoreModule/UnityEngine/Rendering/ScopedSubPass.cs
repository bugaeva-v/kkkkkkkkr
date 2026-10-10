using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200040F RID: 1039
	public struct ScopedSubPass : IDisposable
	{
		// Token: 0x0600237F RID: 9087 RVA: 0x0003C004 File Offset: 0x0003A204
		internal ScopedSubPass(ScriptableRenderContext context)
		{
			this.m_Context = context;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0003C010 File Offset: 0x0003A210
		public void Dispose()
		{
			try
			{
				this.m_Context.EndSubPass();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("The ScopedSubPass instance is not valid. This can happen if it was constructed using the default constructor.", innerException);
			}
		}

		// Token: 0x04000D37 RID: 3383
		private ScriptableRenderContext m_Context;
	}
}
