using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x0200013B RID: 315
	internal readonly struct RenderInstancedDataLayout
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x0000F188 File Offset: 0x0000D388
		public RenderInstancedDataLayout(Type t)
		{
			this.size = Marshal.SizeOf(t);
			this.offsetObjectToWorld = ((t == typeof(Matrix4x4)) ? 0 : Marshal.OffsetOf(t, "objectToWorld").ToInt32());
			try
			{
				this.offsetPrevObjectToWorld = Marshal.OffsetOf(t, "prevObjectToWorld").ToInt32();
			}
			catch (ArgumentException)
			{
				this.offsetPrevObjectToWorld = -1;
			}
			try
			{
				this.offsetRenderingLayerMask = Marshal.OffsetOf(t, "renderingLayerMask").ToInt32();
			}
			catch (ArgumentException)
			{
				this.offsetRenderingLayerMask = -1;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0000F23C File Offset: 0x0000D43C
		public int size { get; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0000F244 File Offset: 0x0000D444
		public int offsetObjectToWorld { get; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000F24C File Offset: 0x0000D44C
		public int offsetPrevObjectToWorld { get; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0000F254 File Offset: 0x0000D454
		public int offsetRenderingLayerMask { get; }
	}
}
