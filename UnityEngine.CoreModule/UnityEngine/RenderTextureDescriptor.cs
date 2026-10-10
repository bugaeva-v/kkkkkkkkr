using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020001AE RID: 430
	public struct RenderTextureDescriptor
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000192B0 File Offset: 0x000174B0
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x000192B8 File Offset: 0x000174B8
		public int width { readonly get; set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x000192C1 File Offset: 0x000174C1
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x000192C9 File Offset: 0x000174C9
		public int height { readonly get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000192D2 File Offset: 0x000174D2
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x000192DA File Offset: 0x000174DA
		public int msaaSamples { readonly get; set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x000192E3 File Offset: 0x000174E3
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x000192EB File Offset: 0x000174EB
		public int volumeDepth { readonly get; set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x000192F4 File Offset: 0x000174F4
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x000192FC File Offset: 0x000174FC
		public int mipCount { readonly get; set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00019308 File Offset: 0x00017508
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00019320 File Offset: 0x00017520
		public GraphicsFormat graphicsFormat
		{
			get
			{
				return this._graphicsFormat;
			}
			set
			{
				this._graphicsFormat = value;
				this.SetOrClearRenderTextureCreationFlag(GraphicsFormatUtility.IsSRGBFormat(value), RenderTextureCreationFlags.SRGB);
				this.depthBufferBits = this.depthBufferBits;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00019345 File Offset: 0x00017545
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x0001934D File Offset: 0x0001754D
		public GraphicsFormat stencilFormat { readonly get; set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00019356 File Offset: 0x00017556
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x0001935E File Offset: 0x0001755E
		public GraphicsFormat depthStencilFormat { readonly get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00019368 File Offset: 0x00017568
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x000193A4 File Offset: 0x000175A4
		public RenderTextureFormat colorFormat
		{
			get
			{
				bool flag = this.graphicsFormat > GraphicsFormat.None;
				RenderTextureFormat result;
				if (flag)
				{
					result = GraphicsFormatUtility.GetRenderTextureFormat(this.graphicsFormat);
				}
				else
				{
					result = ((this.shadowSamplingMode != ShadowSamplingMode.None) ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth);
				}
				return result;
			}
			set
			{
				GraphicsFormat graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
				this.graphicsFormat = SystemInfo.GetCompatibleFormat(graphicsFormat, FormatUsage.Render);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000193D0 File Offset: 0x000175D0
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x000193F0 File Offset: 0x000175F0
		public bool sRGB
		{
			get
			{
				return GraphicsFormatUtility.IsSRGBFormat(this.graphicsFormat);
			}
			set
			{
				this.graphicsFormat = ((value && QualitySettings.activeColorSpace == ColorSpace.Linear && this.colorFormat != RenderTextureFormat.R8 && this.colorFormat != RenderTextureFormat.RG16) ? GraphicsFormatUtility.GetSRGBFormat(this.graphicsFormat) : GraphicsFormatUtility.GetLinearFormat(this.graphicsFormat));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x0001943C File Offset: 0x0001763C
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x00019459 File Offset: 0x00017659
		public int depthBufferBits
		{
			get
			{
				return GraphicsFormatUtility.GetDepthBits(this.depthStencilFormat);
			}
			set
			{
				this.depthStencilFormat = RenderTexture.GetDepthStencilFormatLegacy(value, this.graphicsFormat);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x0001946F File Offset: 0x0001766F
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x00019477 File Offset: 0x00017677
		public TextureDimension dimension { readonly get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00019480 File Offset: 0x00017680
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x00019488 File Offset: 0x00017688
		public ShadowSamplingMode shadowSamplingMode { readonly get; set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00019491 File Offset: 0x00017691
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x00019499 File Offset: 0x00017699
		public VRTextureUsage vrUsage { readonly get; set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000194A4 File Offset: 0x000176A4
		public RenderTextureCreationFlags flags
		{
			get
			{
				return this._flags;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000194BC File Offset: 0x000176BC
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x000194C4 File Offset: 0x000176C4
		public RenderTextureMemoryless memoryless { readonly get; set; }

		// Token: 0x060012E3 RID: 4835 RVA: 0x000194CD File Offset: 0x000176CD
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height)
		{
			this = new RenderTextureDescriptor(width, height, RenderTextureFormat.Default);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000194DA File Offset: 0x000176DA
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
		{
			this = new RenderTextureDescriptor(width, height, colorFormat, 0);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000194E8 File Offset: 0x000176E8
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
		{
			this = new RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, Texture.GenerateAllMips);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000194FC File Offset: 0x000176FC
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits)
		{
			this = new RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, Texture.GenerateAllMips);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00019510 File Offset: 0x00017710
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
		{
			this = new RenderTextureDescriptor(width, height, colorFormat, depthBufferBits, mipCount, RenderTextureReadWrite.Linear);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00019524 File Offset: 0x00017724
		public RenderTextureDescriptor(int width, int height, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat colorFormat, [DefaultValue("0")] int depthBufferBits, [DefaultValue("Texture.GenerateAllMips")] int mipCount, [DefaultValue("RenderTextureReadWrite.Linear")] RenderTextureReadWrite readWrite)
		{
			GraphicsFormat graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(colorFormat, readWrite);
			GraphicsFormat compatibleFormat = SystemInfo.GetCompatibleFormat(graphicsFormat, FormatUsage.Render);
			this = new RenderTextureDescriptor(width, height, compatibleFormat, RenderTexture.GetDepthStencilFormatLegacy(depthBufferBits, colorFormat), mipCount);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0001955C File Offset: 0x0001775C
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
		{
			this = default(RenderTextureDescriptor);
			this._flags = (RenderTextureCreationFlags.AutoGenerateMips | RenderTextureCreationFlags.AllowVerticalFlip);
			this.width = width;
			this.height = height;
			this.volumeDepth = 1;
			this.msaaSamples = 1;
			this.graphicsFormat = colorFormat;
			this.depthStencilFormat = RenderTexture.GetDepthStencilFormatLegacy(depthBufferBits, colorFormat);
			this.mipCount = mipCount;
			this.dimension = TextureDimension.Tex2D;
			this.shadowSamplingMode = ShadowSamplingMode.None;
			this.vrUsage = VRTextureUsage.None;
			this.memoryless = RenderTextureMemoryless.None;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000195DC File Offset: 0x000177DC
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
			this = new RenderTextureDescriptor(width, height, colorFormat, depthStencilFormat, Texture.GenerateAllMips);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000195F0 File Offset: 0x000177F0
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
			this = default(RenderTextureDescriptor);
			this._flags = (RenderTextureCreationFlags.AutoGenerateMips | RenderTextureCreationFlags.AllowVerticalFlip);
			this.width = width;
			this.height = height;
			this.volumeDepth = 1;
			this.msaaSamples = 1;
			this.graphicsFormat = colorFormat;
			this.depthStencilFormat = depthStencilFormat;
			this.mipCount = mipCount;
			this.dimension = TextureDimension.Tex2D;
			this.shadowSamplingMode = ShadowSamplingMode.None;
			this.vrUsage = VRTextureUsage.None;
			this.memoryless = RenderTextureMemoryless.None;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0001966C File Offset: 0x0001786C
		private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
			if (value)
			{
				this._flags |= flag;
			}
			else
			{
				this._flags &= ~flag;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000196A4 File Offset: 0x000178A4
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x000196C1 File Offset: 0x000178C1
		public bool useMipMap
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.MipMap) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.MipMap);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000196D0 File Offset: 0x000178D0
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x000196ED File Offset: 0x000178ED
		public bool autoGenerateMips
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.AutoGenerateMips) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.AutoGenerateMips);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000196FC File Offset: 0x000178FC
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x0001971A File Offset: 0x0001791A
		public bool enableRandomWrite
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.EnableRandomWrite) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.EnableRandomWrite);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00019728 File Offset: 0x00017928
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00019749 File Offset: 0x00017949
		public bool bindMS
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.BindMS) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.BindMS);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0001975C File Offset: 0x0001795C
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0001977A File Offset: 0x0001797A
		internal bool createdFromScript
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.CreatedFromScript) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.CreatedFromScript);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00019788 File Offset: 0x00017988
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x000197A9 File Offset: 0x000179A9
		public bool useDynamicScale
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.DynamicallyScalable) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.DynamicallyScalable);
			}
		}

		// Token: 0x040005D1 RID: 1489
		private GraphicsFormat _graphicsFormat;

		// Token: 0x040005D7 RID: 1495
		private RenderTextureCreationFlags _flags;
	}
}
