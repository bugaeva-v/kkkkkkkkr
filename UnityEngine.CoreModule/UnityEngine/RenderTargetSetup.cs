using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000139 RID: 313
	public struct RenderTargetSetup
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, RenderBufferLoadAction[] colorLoad, RenderBufferStoreAction[] colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore)
		{
			this.color = color;
			this.depth = depth;
			this.mipLevel = mip;
			this.cubemapFace = face;
			this.depthSlice = 0;
			this.colorLoad = colorLoad;
			this.colorStore = colorStore;
			this.depthLoad = depthLoad;
			this.depthStore = depthStore;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		internal static RenderBufferLoadAction[] LoadActions(RenderBuffer[] buf)
		{
			RenderBufferLoadAction[] array = new RenderBufferLoadAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].loadAction;
				buf[i].loadAction = RenderBufferLoadAction.Load;
			}
			return array;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000EF10 File Offset: 0x0000D110
		internal static RenderBufferStoreAction[] StoreActions(RenderBuffer[] buf)
		{
			RenderBufferStoreAction[] array = new RenderBufferStoreAction[buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i].storeAction;
				buf[i].storeAction = RenderBufferStoreAction.Store;
			}
			return array;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000EF5D File Offset: 0x0000D15D
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0000EF76 File Offset: 0x0000D176
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000EF90 File Offset: 0x0000D190
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel, face);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face, int depthSlice)
		{
			this = new RenderTargetSetup(new RenderBuffer[]
			{
				color
			}, depth, mipLevel, face);
			this.depthSlice = depthSlice;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth)
		{
			this = new RenderTargetSetup(color, depth, 0, CubemapFace.Unknown);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0000EFDE File Offset: 0x0000D1DE
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel)
		{
			this = new RenderTargetSetup(color, depth, mipLevel, CubemapFace.Unknown);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face)
		{
			this = new RenderTargetSetup(color, depth, mip, face, RenderTargetSetup.LoadActions(color), RenderTargetSetup.StoreActions(color), depth.loadAction, depth.storeAction);
		}

		// Token: 0x040003E8 RID: 1000
		public RenderBuffer[] color;

		// Token: 0x040003E9 RID: 1001
		public RenderBuffer depth;

		// Token: 0x040003EA RID: 1002
		public int mipLevel;

		// Token: 0x040003EB RID: 1003
		public CubemapFace cubemapFace;

		// Token: 0x040003EC RID: 1004
		public int depthSlice;

		// Token: 0x040003ED RID: 1005
		public RenderBufferLoadAction[] colorLoad;

		// Token: 0x040003EE RID: 1006
		public RenderBufferStoreAction[] colorStore;

		// Token: 0x040003EF RID: 1007
		public RenderBufferLoadAction depthLoad;

		// Token: 0x040003F0 RID: 1008
		public RenderBufferStoreAction depthStore;
	}
}
