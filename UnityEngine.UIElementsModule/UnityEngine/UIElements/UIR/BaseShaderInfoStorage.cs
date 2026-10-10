using System;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200031B RID: 795
	internal abstract class BaseShaderInfoStorage : IDisposable
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001A0D RID: 6669
		public abstract Texture2D texture { get; }

		// Token: 0x06001A0E RID: 6670
		public abstract bool AllocateRect(int width, int height, out RectInt uvs);

		// Token: 0x06001A0F RID: 6671
		public abstract void SetTexel(int x, int y, Color color);

		// Token: 0x06001A10 RID: 6672
		public abstract void UpdateTexture();

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0006E77C File Offset: 0x0006C97C
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0006E784 File Offset: 0x0006C984
		private protected bool disposed { protected get; private set; }

		// Token: 0x06001A13 RID: 6675 RVA: 0x0006E78D File Offset: 0x0006C98D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0006E7A0 File Offset: 0x0006C9A0
		protected virtual void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				bool flag = !disposing;
				if (flag)
				{
				}
				this.disposed = true;
			}
		}

		// Token: 0x04000BD7 RID: 3031
		protected static int s_TextureCounter;

		// Token: 0x04000BD8 RID: 3032
		internal static ProfilerMarker s_MarkerCopyTexture = new ProfilerMarker("UIR.ShaderInfoStorage.CopyTexture");

		// Token: 0x04000BD9 RID: 3033
		internal static ProfilerMarker s_MarkerGetTextureData = new ProfilerMarker("UIR.ShaderInfoStorage.GetTextureData");

		// Token: 0x04000BDA RID: 3034
		internal static ProfilerMarker s_MarkerUpdateTexture = new ProfilerMarker("UIR.ShaderInfoStorage.UpdateTexture");
	}
}
