using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001A3 RID: 419
	[NativeHeader("Runtime/Graphics/Texture.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
	public class Texture : Object
	{
		// Token: 0x060010BE RID: 4286 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		protected Texture()
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060010BF RID: 4287
		// (set) Token: 0x060010C0 RID: 4288
		[NativeProperty("GlobalMasterTextureLimit")]
		public static extern int masterTextureLimit { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060010C1 RID: 4289
		public extern int mipmapCount { [NativeName("GetMipmapCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060010C2 RID: 4290
		// (set) Token: 0x060010C3 RID: 4291
		[NativeProperty("AnisoLimit")]
		public static extern AnisotropicFiltering anisotropicFiltering { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060010C4 RID: 4292
		[NativeName("SetGlobalAnisoLimits")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0001616C File Offset: 0x0001436C
		public virtual GraphicsFormat graphicsFormat
		{
			get
			{
				return GraphicsFormatUtility.GetFormat(this);
			}
		}

		// Token: 0x060010C6 RID: 4294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetDataWidth();

		// Token: 0x060010C7 RID: 4295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetDataHeight();

		// Token: 0x060010C8 RID: 4296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern TextureDimension GetDimension();

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00016184 File Offset: 0x00014384
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x0001619C File Offset: 0x0001439C
		public virtual int width
		{
			get
			{
				return this.GetDataWidth();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x000161A4 File Offset: 0x000143A4
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0001619C File Offset: 0x0001439C
		public virtual int height
		{
			get
			{
				return this.GetDataHeight();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000161BC File Offset: 0x000143BC
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0001619C File Offset: 0x0001439C
		public virtual TextureDimension dimension
		{
			get
			{
				return this.GetDimension();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060010CF RID: 4303
		internal extern bool isNativeTexture { [NativeName("IsNativeTexture")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060010D0 RID: 4304
		public virtual extern bool isReadable { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060010D1 RID: 4305
		// (set) Token: 0x060010D2 RID: 4306
		public extern TextureWrapMode wrapMode { [NativeName("GetWrapModeU")] [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060010D3 RID: 4307
		// (set) Token: 0x060010D4 RID: 4308
		public extern TextureWrapMode wrapModeU { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060010D5 RID: 4309
		// (set) Token: 0x060010D6 RID: 4310
		public extern TextureWrapMode wrapModeV { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060010D7 RID: 4311
		// (set) Token: 0x060010D8 RID: 4312
		public extern TextureWrapMode wrapModeW { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060010D9 RID: 4313
		// (set) Token: 0x060010DA RID: 4314
		public extern FilterMode filterMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060010DB RID: 4315
		// (set) Token: 0x060010DC RID: 4316
		public extern int anisoLevel { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060010DD RID: 4317
		// (set) Token: 0x060010DE RID: 4318
		public extern float mipMapBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000161D4 File Offset: 0x000143D4
		public Vector2 texelSize
		{
			[NativeName("GetTexelSize")]
			get
			{
				Vector2 result;
				this.get_texelSize_Injected(out result);
				return result;
			}
		}

		// Token: 0x060010E0 RID: 4320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern IntPtr GetNativeTexturePtr();

		// Token: 0x060010E1 RID: 4321 RVA: 0x000161EC File Offset: 0x000143EC
		[Obsolete("Use GetNativeTexturePtr instead.", false)]
		public int GetNativeTextureID()
		{
			return (int)this.GetNativeTexturePtr();
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060010E2 RID: 4322
		public extern uint updateCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010E3 RID: 4323
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void IncrementUpdateCount();

		// Token: 0x060010E4 RID: 4324
		[NativeMethod("GetActiveTextureColorSpace")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int Internal_GetActiveTextureColorSpace();

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0001620C File Offset: 0x0001440C
		internal ColorSpace activeTextureColorSpace
		{
			[VisibleToOtherModules(new string[]
			{
				"UnityEngine.UIElementsModule",
				"Unity.UIElements"
			})]
			get
			{
				return (this.Internal_GetActiveTextureColorSpace() == 0) ? ColorSpace.Linear : ColorSpace.Gamma;
			}
		}

		// Token: 0x060010E6 RID: 4326
		[NativeMethod("GetStoredColorSpace")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern TextureColorSpace Internal_GetStoredColorSpace();

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0001622C File Offset: 0x0001442C
		public bool isDataSRGB
		{
			get
			{
				return this.Internal_GetStoredColorSpace() == TextureColorSpace.sRGB;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060010E8 RID: 4328
		public static extern ulong totalTextureMemory { [FreeFunction("GetTextureStreamingManager().GetTotalTextureMemory")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060010E9 RID: 4329
		public static extern ulong desiredTextureMemory { [FreeFunction("GetTextureStreamingManager().GetDesiredTextureMemory")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060010EA RID: 4330
		public static extern ulong targetTextureMemory { [FreeFunction("GetTextureStreamingManager().GetTargetTextureMemory")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060010EB RID: 4331
		public static extern ulong currentTextureMemory { [FreeFunction("GetTextureStreamingManager().GetCurrentTextureMemory")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060010EC RID: 4332
		public static extern ulong nonStreamingTextureMemory { [FreeFunction("GetTextureStreamingManager().GetNonStreamingTextureMemory")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010ED RID: 4333
		public static extern ulong streamingMipmapUploadCount { [FreeFunction("GetTextureStreamingManager().GetStreamingMipmapUploadCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010EE RID: 4334
		public static extern ulong streamingRendererCount { [FreeFunction("GetTextureStreamingManager().GetStreamingRendererCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010EF RID: 4335
		public static extern ulong streamingTextureCount { [FreeFunction("GetTextureStreamingManager().GetStreamingTextureCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010F0 RID: 4336
		public static extern ulong nonStreamingTextureCount { [FreeFunction("GetTextureStreamingManager().GetNonStreamingTextureCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060010F1 RID: 4337
		public static extern ulong streamingTexturePendingLoadCount { [FreeFunction("GetTextureStreamingManager().GetStreamingTexturePendingLoadCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060010F2 RID: 4338
		public static extern ulong streamingTextureLoadingCount { [FreeFunction("GetTextureStreamingManager().GetStreamingTextureLoadingCount")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010F3 RID: 4339
		[FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugProperties")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetStreamingTextureMaterialDebugProperties();

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060010F4 RID: 4340
		// (set) Token: 0x060010F5 RID: 4341
		public static extern bool streamingTextureForceLoadAll { [FreeFunction(Name = "GetTextureStreamingManager().GetForceLoadAll")] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction(Name = "GetTextureStreamingManager().SetForceLoadAll")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060010F6 RID: 4342
		// (set) Token: 0x060010F7 RID: 4343
		public static extern bool streamingTextureDiscardUnusedMips { [FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060010F8 RID: 4344
		// (set) Token: 0x060010F9 RID: 4345
		public static extern bool allowThreadedTextureCreation { [FreeFunction(Name = "Texture2DScripting::IsCreateTextureThreadedEnabled")] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction(Name = "Texture2DScripting::EnableCreateTextureThreaded")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060010FA RID: 4346
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ulong GetPixelDataSize(int mipLevel, int element = 0);

		// Token: 0x060010FB RID: 4347
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ulong GetPixelDataOffset(int mipLevel, int element = 0);

		// Token: 0x060010FC RID: 4348 RVA: 0x00016248 File Offset: 0x00014448
		internal TextureColorSpace GetTextureColorSpace(bool linear)
		{
			return linear ? TextureColorSpace.Linear : TextureColorSpace.sRGB;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00016264 File Offset: 0x00014464
		internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
		{
			return this.GetTextureColorSpace(!GraphicsFormatUtility.IsSRGBFormat(format));
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00016288 File Offset: 0x00014488
		internal bool ValidateFormat(RenderTextureFormat format)
		{
			bool flag = SystemInfo.SupportsRenderTextureFormat(format);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				Debug.LogError(string.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", format.ToString()), this);
				result = false;
			}
			return result;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000162CC File Offset: 0x000144CC
		internal bool ValidateFormat(TextureFormat format)
		{
			bool flag = SystemInfo.SupportsTextureFormat(format);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = GraphicsFormatUtility.IsCompressedTextureFormat(format) && GraphicsFormatUtility.CanDecompressFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
				if (flag2)
				{
					Debug.LogWarning(string.Format("'{0}' is not supported on this platform. Decompressing texture. Use 'SystemInfo.SupportsTextureFormat' C# API to check format support.", format.ToString()), this);
					result = true;
				}
				else
				{
					Debug.LogError(string.Format("Texture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsTextureFormat' C# API to check format support.", format.ToString()), this);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0001634C File Offset: 0x0001454C
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
		{
			bool flag = usage != FormatUsage.Render && (format == GraphicsFormat.ShadowAuto || format == GraphicsFormat.DepthAuto);
			bool result;
			if (flag)
			{
				Debug.LogWarning(string.Format("'{0}' is not allowed because it is an auto format and not an exact format. Use GraphicsFormatUtility.GetDepthStencilFormat to get an exact depth/stencil format.", format.ToString()), this);
				result = false;
			}
			else
			{
				bool flag2 = SystemInfo.IsFormatSupported(format, usage);
				if (flag2)
				{
					result = true;
				}
				else
				{
					Debug.LogError(string.Format("Texture creation failed. '{0}' is not supported for {1} usage on this platform. Use 'SystemInfo.IsFormatSupported' C# API to check format support.", format.ToString(), usage.ToString()), this);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000163DC File Offset: 0x000145DC
		internal UnityException CreateNonReadableException(Texture t)
		{
			return new UnityException(string.Format("Texture '{0}' is not readable, the texture memory can not be accessed from scripts. You can make the texture readable in the Texture Import Settings.", t.name));
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00016404 File Offset: 0x00014604
		internal UnityException CreateNativeArrayLengthOverflowException()
		{
			return new UnityException("Failed to create NativeArray, length exceeds the allowed maximum of Int32.MaxValue. Use a larger type as template argument to reduce the array length.");
		}

		// Token: 0x06001104 RID: 4356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_texelSize_Injected(out Vector2 ret);

		// Token: 0x040005BE RID: 1470
		public static readonly int GenerateAllMips = -1;
	}
}
