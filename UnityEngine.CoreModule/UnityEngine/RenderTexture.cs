using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001AB RID: 427
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
	public class RenderTexture : Texture
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600121F RID: 4639
		// (set) Token: 0x06001220 RID: 4640
		public override extern int width { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001221 RID: 4641
		// (set) Token: 0x06001222 RID: 4642
		public override extern int height { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001223 RID: 4643
		// (set) Token: 0x06001224 RID: 4644
		public override extern TextureDimension dimension { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001225 RID: 4645
		// (set) Token: 0x06001226 RID: 4646
		[NativeProperty("ColorFormat")]
		public new extern GraphicsFormat graphicsFormat { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001227 RID: 4647
		// (set) Token: 0x06001228 RID: 4648
		[NativeProperty("MipMap")]
		public extern bool useMipMap { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001229 RID: 4649
		[NativeProperty("SRGBReadWrite")]
		public extern bool sRGB { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600122A RID: 4650
		// (set) Token: 0x0600122B RID: 4651
		[NativeProperty("VRUsage")]
		public extern VRTextureUsage vrUsage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600122C RID: 4652
		// (set) Token: 0x0600122D RID: 4653
		[NativeProperty("Memoryless")]
		public extern RenderTextureMemoryless memorylessMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0001874C File Offset: 0x0001694C
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00018790 File Offset: 0x00016990
		public RenderTextureFormat format
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
					result = ((this.GetDescriptor().shadowSamplingMode != ShadowSamplingMode.None) ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth);
				}
				return result;
			}
			set
			{
				this.graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001230 RID: 4656
		// (set) Token: 0x06001231 RID: 4657
		public extern GraphicsFormat stencilFormat { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001232 RID: 4658
		// (set) Token: 0x06001233 RID: 4659
		public extern GraphicsFormat depthStencilFormat { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001234 RID: 4660
		// (set) Token: 0x06001235 RID: 4661
		public extern bool autoGenerateMips { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001236 RID: 4662
		// (set) Token: 0x06001237 RID: 4663
		public extern int volumeDepth { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001238 RID: 4664
		// (set) Token: 0x06001239 RID: 4665
		public extern int antiAliasing { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600123A RID: 4666
		// (set) Token: 0x0600123B RID: 4667
		public extern bool bindTextureMS { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600123C RID: 4668
		// (set) Token: 0x0600123D RID: 4669
		public extern bool enableRandomWrite { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600123E RID: 4670
		// (set) Token: 0x0600123F RID: 4671
		public extern bool useDynamicScale { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001240 RID: 4672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetIsPowerOfTwo();

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000187A8 File Offset: 0x000169A8
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00004563 File Offset: 0x00002763
		public bool isPowerOfTwo
		{
			get
			{
				return this.GetIsPowerOfTwo();
			}
			set
			{
			}
		}

		// Token: 0x06001243 RID: 4675
		[FreeFunction("RenderTexture::GetActive")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RenderTexture GetActive();

		// Token: 0x06001244 RID: 4676
		[FreeFunction("RenderTextureScripting::SetActive")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetActive(RenderTexture rt);

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000187C0 File Offset: 0x000169C0
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x000187D7 File Offset: 0x000169D7
		public static RenderTexture active
		{
			get
			{
				return RenderTexture.GetActive();
			}
			set
			{
				RenderTexture.SetActive(value);
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000187E4 File Offset: 0x000169E4
		[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = true)]
		private RenderBuffer GetColorBuffer()
		{
			RenderBuffer result;
			this.GetColorBuffer_Injected(out result);
			return result;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000187FC File Offset: 0x000169FC
		[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = true)]
		private RenderBuffer GetDepthBuffer()
		{
			RenderBuffer result;
			this.GetDepthBuffer_Injected(out result);
			return result;
		}

		// Token: 0x06001249 RID: 4681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetMipMapCount(int count);

		// Token: 0x0600124A RID: 4682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetShadowSamplingMode(ShadowSamplingMode samplingMode);

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00018814 File Offset: 0x00016A14
		public RenderBuffer colorBuffer
		{
			get
			{
				return this.GetColorBuffer();
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0001882C File Offset: 0x00016A2C
		public RenderBuffer depthBuffer
		{
			get
			{
				return this.GetDepthBuffer();
			}
		}

		// Token: 0x0600124D RID: 4685
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern IntPtr GetNativeDepthBufferPtr();

		// Token: 0x0600124E RID: 4686
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DiscardContents(bool discardColor, bool discardDepth);

		// Token: 0x0600124F RID: 4687
		[Obsolete("This function has no effect.", false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void MarkRestoreExpected();

		// Token: 0x06001250 RID: 4688 RVA: 0x00018844 File Offset: 0x00016A44
		public void DiscardContents()
		{
			this.DiscardContents(true, true);
		}

		// Token: 0x06001251 RID: 4689
		[NativeName("ResolveAntiAliasedSurface")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResolveAA();

		// Token: 0x06001252 RID: 4690
		[NativeName("ResolveAntiAliasedSurface")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResolveAATo(RenderTexture rt);

		// Token: 0x06001253 RID: 4691 RVA: 0x00018850 File Offset: 0x00016A50
		public void ResolveAntiAliasedSurface()
		{
			this.ResolveAA();
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0001885A File Offset: 0x00016A5A
		public void ResolveAntiAliasedSurface(RenderTexture target)
		{
			this.ResolveAATo(target);
		}

		// Token: 0x06001255 RID: 4693
		[FreeFunction(Name = "RenderTextureScripting::SetGlobalShaderProperty", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalShaderProperty(string propertyName);

		// Token: 0x06001256 RID: 4694
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Create();

		// Token: 0x06001257 RID: 4695
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Release();

		// Token: 0x06001258 RID: 4696
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsCreated();

		// Token: 0x06001259 RID: 4697
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GenerateMips();

		// Token: 0x0600125A RID: 4698
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ConvertToEquirect(RenderTexture equirect, Camera.MonoOrStereoscopicEye eye = Camera.MonoOrStereoscopicEye.Mono);

		// Token: 0x0600125B RID: 4699
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetSRGBReadWrite(bool srgb);

		// Token: 0x0600125C RID: 4700
		[FreeFunction("RenderTextureScripting::Create")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] RenderTexture rt);

		// Token: 0x0600125D RID: 4701
		[FreeFunction("RenderTextureSupportsStencil")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportsStencil(RenderTexture rt);

		// Token: 0x0600125E RID: 4702 RVA: 0x00018865 File Offset: 0x00016A65
		[NativeName("SetRenderTextureDescFromScript")]
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			this.SetRenderTextureDescriptor_Injected(ref desc);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00018870 File Offset: 0x00016A70
		[NativeName("GetRenderTextureDesc")]
		private RenderTextureDescriptor GetDescriptor()
		{
			RenderTextureDescriptor result;
			this.GetDescriptor_Injected(out result);
			return result;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00018886 File Offset: 0x00016A86
		[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
		private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			return RenderTexture.GetTemporary_Internal_Injected(ref desc);
		}

		// Token: 0x06001261 RID: 4705
		[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseTemporary(RenderTexture temp);

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001262 RID: 4706
		// (set) Token: 0x06001263 RID: 4707
		public extern int depth { [FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001264 RID: 4708 RVA: 0x0001888F File Offset: 0x00016A8F
		[RequiredByNativeCode]
		protected internal RenderTexture()
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00018899 File Offset: 0x00016A99
		public RenderTexture(RenderTextureDescriptor desc)
		{
			RenderTexture.ValidateRenderTextureDesc(desc);
			RenderTexture.Internal_Create(this);
			this.SetRenderTextureDescriptor(desc);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000188BC File Offset: 0x00016ABC
		public RenderTexture(RenderTexture textureToCopy)
		{
			bool flag = textureToCopy == null;
			if (flag)
			{
				throw new ArgumentNullException("textureToCopy");
			}
			RenderTexture.ValidateRenderTextureDesc(textureToCopy.descriptor);
			RenderTexture.Internal_Create(this);
			this.SetRenderTextureDescriptor(textureToCopy.descriptor);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00018907 File Offset: 0x00016B07
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, DefaultFormat format) : this(width, height, RenderTexture.GetDefaultColorFormat(format), RenderTexture.GetDefaultDepthStencilFormat(format, depth), Texture.GenerateAllMips)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00018927 File Offset: 0x00016B27
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format) : this(width, height, depth, format, Texture.GenerateAllMips)
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0001893C File Offset: 0x00016B3C
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
			bool flag = format != GraphicsFormat.None && !base.ValidateFormat(format, FormatUsage.Render);
			if (!flag)
			{
				RenderTexture.Internal_Create(this);
				this.depthStencilFormat = RenderTexture.GetDepthStencilFormatLegacy(depth, format);
				this.width = width;
				this.height = height;
				this.graphicsFormat = format;
				this.SetMipMapCount(mipCount);
				this.SetSRGBReadWrite(GraphicsFormatUtility.IsSRGBFormat(format));
			}
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000189B0 File Offset: 0x00016BB0
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
			bool flag = colorFormat != GraphicsFormat.None && !base.ValidateFormat(colorFormat, FormatUsage.Render);
			if (!flag)
			{
				RenderTexture.Internal_Create(this);
				this.width = width;
				this.height = height;
				this.depthStencilFormat = depthStencilFormat;
				this.graphicsFormat = colorFormat;
				this.SetMipMapCount(mipCount);
				this.SetSRGBReadWrite(GraphicsFormatUtility.IsSRGBFormat(colorFormat));
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00018A1A File Offset: 0x00016C1A
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) : this(width, height, colorFormat, depthStencilFormat, Texture.GenerateAllMips)
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00018A2E File Offset: 0x00016C2E
		public RenderTexture(int width, int height, int depth, [UnityEngine.Internal.DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [UnityEngine.Internal.DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
		{
			this.Initialize(width, height, depth, format, readWrite, Texture.GenerateAllMips);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00018A4B File Offset: 0x00016C4B
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format) : this(width, height, depth, format, Texture.GenerateAllMips)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00018A5F File Offset: 0x00016C5F
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth) : this(width, height, depth, RenderTextureFormat.Default)
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00018A6D File Offset: 0x00016C6D
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		{
			this.Initialize(width, height, depth, format, RenderTextureReadWrite.Default, mipCount);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00018A88 File Offset: 0x00016C88
		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
			GraphicsFormat compatibleFormat = RenderTexture.GetCompatibleFormat(format, readWrite);
			GraphicsFormat depthStencilFormatLegacy = RenderTexture.GetDepthStencilFormatLegacy(depth, format);
			bool flag = compatibleFormat > GraphicsFormat.None;
			if (flag)
			{
				bool flag2 = !base.ValidateFormat(compatibleFormat, FormatUsage.Render);
				if (flag2)
				{
					return;
				}
			}
			RenderTexture.Internal_Create(this);
			this.width = width;
			this.height = height;
			this.depthStencilFormat = depthStencilFormatLegacy;
			this.graphicsFormat = compatibleFormat;
			this.SetMipMapCount(mipCount);
			this.SetSRGBReadWrite(GraphicsFormatUtility.IsSRGBFormat(compatibleFormat));
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00018B04 File Offset: 0x00016D04
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
		{
			return (colorFormat == GraphicsFormat.ShadowAuto) ? GraphicsFormatUtility.GetDepthStencilFormat(depthBits, 0) : GraphicsFormatUtility.GetDepthStencilFormat(depthBits);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00018B30 File Offset: 0x00016D30
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
		{
			return RenderTexture.GetDepthStencilFormatLegacy(depthBits, format == RenderTextureFormat.Shadowmap);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00018B4C File Offset: 0x00016D4C
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
		{
			return RenderTexture.GetDepthStencilFormatLegacy(depthBits, format == DefaultFormat.Shadow);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00018B68 File Offset: 0x00016D68
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
		{
			return requestedShadowMap ? GraphicsFormatUtility.GetDepthStencilFormat(depthBits, 0) : GraphicsFormatUtility.GetDepthStencilFormat(depthBits);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00018B8C File Offset: 0x00016D8C
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x00018BA4 File Offset: 0x00016DA4
		public RenderTextureDescriptor descriptor
		{
			get
			{
				return this.GetDescriptor();
			}
			set
			{
				RenderTexture.ValidateRenderTextureDesc(value);
				this.SetRenderTextureDescriptor(value);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00018BB8 File Offset: 0x00016DB8
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			bool flag = desc.graphicsFormat == GraphicsFormat.None && desc.depthStencilFormat == GraphicsFormat.None;
			if (flag)
			{
				throw new ArgumentException("RenderTextureDesc graphicsFormat and depthStencilFormat cannot both be None.");
			}
			bool flag2 = desc.graphicsFormat != GraphicsFormat.None && !SystemInfo.IsFormatSupported(desc.graphicsFormat, FormatUsage.Render);
			if (flag2)
			{
				throw new ArgumentException("RenderTextureDesc graphicsFormat must be a supported GraphicsFormat. " + desc.graphicsFormat.ToString() + " is not supported on this platform.", "desc.graphicsFormat");
			}
			bool flag3 = desc.depthStencilFormat != GraphicsFormat.None && !GraphicsFormatUtility.IsDepthFormat(desc.depthStencilFormat) && !GraphicsFormatUtility.IsStencilFormat(desc.depthStencilFormat);
			if (flag3)
			{
				throw new ArgumentException("RenderTextureDesc depthStencilFormat must be a supported depth/stencil GraphicsFormat. " + desc.depthStencilFormat.ToString() + " is not supported on this platform.", "desc.depthStencilFormat");
			}
			bool flag4 = desc.width <= 0;
			if (flag4)
			{
				throw new ArgumentException("RenderTextureDesc width must be greater than zero.", "desc.width");
			}
			bool flag5 = desc.height <= 0;
			if (flag5)
			{
				throw new ArgumentException("RenderTextureDesc height must be greater than zero.", "desc.height");
			}
			bool flag6 = desc.volumeDepth <= 0;
			if (flag6)
			{
				throw new ArgumentException("RenderTextureDesc volumeDepth must be greater than zero.", "desc.volumeDepth");
			}
			bool flag7 = desc.msaaSamples != 1 && desc.msaaSamples != 2 && desc.msaaSamples != 4 && desc.msaaSamples != 8;
			if (flag7)
			{
				throw new ArgumentException("RenderTextureDesc msaaSamples must be 1, 2, 4, or 8.", "desc.msaaSamples");
			}
			bool flag8 = desc.dimension == TextureDimension.CubeArray && desc.volumeDepth % 6 != 0;
			if (flag8)
			{
				throw new ArgumentException("RenderTextureDesc volumeDepth must be a multiple of 6 when dimension is CubeArray", "desc.volumeDepth");
			}
			bool flag9 = desc.graphicsFormat != GraphicsFormat.ShadowAuto && desc.graphicsFormat != GraphicsFormat.DepthAuto && (GraphicsFormatUtility.IsDepthFormat(desc.graphicsFormat) || GraphicsFormatUtility.IsStencilFormat(desc.graphicsFormat));
			if (flag9)
			{
				throw new ArgumentException("RenderTextureDesc graphicsFormat must not be a depth/stencil format. " + desc.graphicsFormat.ToString() + " is not supported.", "desc.graphicsFormat");
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00018DE8 File Offset: 0x00016FE8
		internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
		{
			GraphicsFormat result;
			if (format != DefaultFormat.DepthStencil)
			{
				if (format != DefaultFormat.Shadow)
				{
					result = SystemInfo.GetGraphicsFormat(format);
				}
				else
				{
					result = GraphicsFormat.ShadowAuto;
				}
			}
			else
			{
				result = GraphicsFormat.DepthAuto;
			}
			return result;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00018E20 File Offset: 0x00017020
		internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
		{
			GraphicsFormat result;
			if (format - DefaultFormat.DepthStencil > 1)
			{
				result = RenderTexture.GetDepthStencilFormatLegacy(depth, format);
			}
			else
			{
				result = SystemInfo.GetGraphicsFormat(format);
			}
			return result;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00018E50 File Offset: 0x00017050
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			GraphicsFormat graphicsFormat = GraphicsFormatUtility.GetGraphicsFormat(renderTextureFormat, readWrite);
			GraphicsFormat compatibleFormat = SystemInfo.GetCompatibleFormat(graphicsFormat, FormatUsage.Render);
			bool flag = graphicsFormat == compatibleFormat;
			GraphicsFormat result;
			if (flag)
			{
				result = graphicsFormat;
			}
			else
			{
				Debug.LogWarning(string.Format("'{0}' is not supported. RenderTexture::GetTemporary fallbacks to {1} format on this platform. Use 'SystemInfo.IsFormatSupported' C# API to check format support.", graphicsFormat.ToString(), compatibleFormat.ToString()));
				result = compatibleFormat;
			}
			return result;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00018EAC File Offset: 0x000170AC
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			RenderTexture.ValidateRenderTextureDesc(desc);
			desc.createdFromScript = true;
			return RenderTexture.GetTemporary_Internal(desc);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00018ED4 File Offset: 0x000170D4
		private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			return RenderTexture.GetTemporary(new RenderTextureDescriptor(width, height, colorFormat, depthStencilFormat)
			{
				msaaSamples = antiAliasing,
				memoryless = memorylessMode,
				vrUsage = vrUsage,
				useDynamicScale = useDynamicScale
			});
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00018F20 File Offset: 0x00017120
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, [UnityEngine.Internal.DefaultValue("1")] int antiAliasing, [UnityEngine.Internal.DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [UnityEngine.Internal.DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [UnityEngine.Internal.DefaultValue("false")] bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, RenderTexture.GetDepthStencilFormatLegacy(depthBuffer, format), format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00018F4C File Offset: 0x0001714C
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00018F70 File Offset: 0x00017170
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00018F90 File Offset: 0x00017190
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00018FB0 File Offset: 0x000171B0
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, 1);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00018FCC File Offset: 0x000171CC
		public static RenderTexture GetTemporary(int width, int height, [UnityEngine.Internal.DefaultValue("0")] int depthBuffer, [UnityEngine.Internal.DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [UnityEngine.Internal.DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [UnityEngine.Internal.DefaultValue("1")] int antiAliasing, [UnityEngine.Internal.DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [UnityEngine.Internal.DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [UnityEngine.Internal.DefaultValue("false")] bool useDynamicScale)
		{
			GraphicsFormat compatibleFormat = RenderTexture.GetCompatibleFormat(format, readWrite);
			GraphicsFormat depthStencilFormatLegacy = RenderTexture.GetDepthStencilFormatLegacy(depthBuffer, format);
			return RenderTexture.GetTemporaryImpl(width, height, depthStencilFormatLegacy, compatibleFormat, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00019000 File Offset: 0x00017200
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00019024 File Offset: 0x00017224
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, memorylessMode, VRTextureUsage.None);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00019048 File Offset: 0x00017248
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, antiAliasing, RenderTextureMemoryless.None);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00019068 File Offset: 0x00017268
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, 1);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00019088 File Offset: 0x00017288
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, RenderTextureReadWrite.Default);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000190A4 File Offset: 0x000172A4
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, RenderTextureFormat.Default);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000190C0 File Offset: 0x000172C0
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height)
		{
			return RenderTexture.GetTemporary(width, height, 0);
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x000190DC File Offset: 0x000172DC
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x000190F7 File Offset: 0x000172F7
		[Obsolete("Use RenderTexture.dimension instead.", false)]
		public bool isCubemap
		{
			get
			{
				return this.dimension == TextureDimension.Cube;
			}
			set
			{
				this.dimension = (value ? TextureDimension.Cube : TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00019108 File Offset: 0x00017308
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x00019123 File Offset: 0x00017323
		[Obsolete("Use RenderTexture.dimension instead.", false)]
		public bool isVolume
		{
			get
			{
				return this.dimension == TextureDimension.Tex3D;
			}
			set
			{
				this.dimension = (value ? TextureDimension.Tex3D : TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00019134 File Offset: 0x00017334
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x00004563 File Offset: 0x00002763
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("RenderTexture.enabled is always now, no need to use it.", false)]
		public static bool enabled
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00019148 File Offset: 0x00017348
		[Obsolete("GetTexelOffset always returns zero now, no point in using it.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x06001291 RID: 4753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetColorBuffer_Injected(out RenderBuffer ret);

		// Token: 0x06001292 RID: 4754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetDepthBuffer_Injected(out RenderBuffer ret);

		// Token: 0x06001293 RID: 4755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc);

		// Token: 0x06001294 RID: 4756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetDescriptor_Injected(out RenderTextureDescriptor ret);

		// Token: 0x06001295 RID: 4757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc);
	}
}
