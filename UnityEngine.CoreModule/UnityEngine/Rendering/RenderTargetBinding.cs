using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003C6 RID: 966
	public struct RenderTargetBinding
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00033AC8 File Offset: 0x00031CC8
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00033AE0 File Offset: 0x00031CE0
		public RenderTargetIdentifier[] colorRenderTargets
		{
			get
			{
				return this.m_ColorRenderTargets;
			}
			set
			{
				this.m_ColorRenderTargets = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00033AEC File Offset: 0x00031CEC
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x00033B04 File Offset: 0x00031D04
		public RenderTargetIdentifier depthRenderTarget
		{
			get
			{
				return this.m_DepthRenderTarget;
			}
			set
			{
				this.m_DepthRenderTarget = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00033B10 File Offset: 0x00031D10
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00033B28 File Offset: 0x00031D28
		public RenderBufferLoadAction[] colorLoadActions
		{
			get
			{
				return this.m_ColorLoadActions;
			}
			set
			{
				this.m_ColorLoadActions = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00033B34 File Offset: 0x00031D34
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x00033B4C File Offset: 0x00031D4C
		public RenderBufferStoreAction[] colorStoreActions
		{
			get
			{
				return this.m_ColorStoreActions;
			}
			set
			{
				this.m_ColorStoreActions = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00033B58 File Offset: 0x00031D58
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00033B70 File Offset: 0x00031D70
		public RenderBufferLoadAction depthLoadAction
		{
			get
			{
				return this.m_DepthLoadAction;
			}
			set
			{
				this.m_DepthLoadAction = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00033B7C File Offset: 0x00031D7C
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00033B94 File Offset: 0x00031D94
		public RenderBufferStoreAction depthStoreAction
		{
			get
			{
				return this.m_DepthStoreAction;
			}
			set
			{
				this.m_DepthStoreAction = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x00033BA0 File Offset: 0x00031DA0
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00033BB8 File Offset: 0x00031DB8
		public RenderTargetFlags flags
		{
			get
			{
				return this.m_Flags;
			}
			set
			{
				this.m_Flags = value;
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00033BC2 File Offset: 0x00031DC2
		public RenderTargetBinding(RenderTargetIdentifier[] colorRenderTargets, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderTargetIdentifier depthRenderTarget, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this.m_ColorRenderTargets = colorRenderTargets;
			this.m_DepthRenderTarget = depthRenderTarget;
			this.m_ColorLoadActions = colorLoadActions;
			this.m_ColorStoreActions = colorStoreActions;
			this.m_DepthLoadAction = depthLoadAction;
			this.m_DepthStoreAction = depthStoreAction;
			this.m_Flags = RenderTargetFlags.None;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00033BF9 File Offset: 0x00031DF9
		public RenderTargetBinding(RenderTargetIdentifier colorRenderTarget, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthRenderTarget, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
			this = new RenderTargetBinding(new RenderTargetIdentifier[]
			{
				colorRenderTarget
			}, new RenderBufferLoadAction[]
			{
				colorLoadAction
			}, new RenderBufferStoreAction[]
			{
				colorStoreAction
			}, depthRenderTarget, depthLoadAction, depthStoreAction);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00033C2C File Offset: 0x00031E2C
		public RenderTargetBinding(RenderTargetSetup setup)
		{
			this.m_ColorRenderTargets = new RenderTargetIdentifier[setup.color.Length];
			for (int i = 0; i < this.m_ColorRenderTargets.Length; i++)
			{
				this.m_ColorRenderTargets[i] = new RenderTargetIdentifier(setup.color[i], setup.mipLevel, setup.cubemapFace, setup.depthSlice);
			}
			this.m_DepthRenderTarget = setup.depth;
			this.m_ColorLoadActions = (RenderBufferLoadAction[])setup.colorLoad.Clone();
			this.m_ColorStoreActions = (RenderBufferStoreAction[])setup.colorStore.Clone();
			this.m_DepthLoadAction = setup.depthLoad;
			this.m_DepthStoreAction = setup.depthStore;
			this.m_Flags = RenderTargetFlags.None;
		}

		// Token: 0x04000B86 RID: 2950
		private RenderTargetIdentifier[] m_ColorRenderTargets;

		// Token: 0x04000B87 RID: 2951
		private RenderTargetIdentifier m_DepthRenderTarget;

		// Token: 0x04000B88 RID: 2952
		private RenderBufferLoadAction[] m_ColorLoadActions;

		// Token: 0x04000B89 RID: 2953
		private RenderBufferStoreAction[] m_ColorStoreActions;

		// Token: 0x04000B8A RID: 2954
		private RenderBufferLoadAction m_DepthLoadAction;

		// Token: 0x04000B8B RID: 2955
		private RenderBufferStoreAction m_DepthStoreAction;

		// Token: 0x04000B8C RID: 2956
		private RenderTargetFlags m_Flags;
	}
}
