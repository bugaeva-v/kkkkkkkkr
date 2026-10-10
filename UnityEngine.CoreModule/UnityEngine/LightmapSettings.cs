using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000134 RID: 308
	[StaticAccessor("GetLightmapSettings()")]
	[NativeHeader("Runtime/Graphics/LightmapSettings.h")]
	public sealed class LightmapSettings : Object
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		private LightmapSettings()
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060009A1 RID: 2465
		// (set) Token: 0x060009A2 RID: 2466
		public static extern LightmapData[] lightmaps { [FreeFunction] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction(ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] [param: Unmarshalled] set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060009A3 RID: 2467
		// (set) Token: 0x060009A4 RID: 2468
		public static extern LightmapsMode lightmapsMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction(ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009A5 RID: 2469
		// (set) Token: 0x060009A6 RID: 2470
		public static extern LightProbes lightProbes { [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction] [NativeName("SetLightProbes")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060009A7 RID: 2471
		[NativeName("ResetAndAwakeFromLoad")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("Use lightmapsMode instead.", false)]
		public static LightmapsModeLegacy lightmapsModeLegacy
		{
			get
			{
				return LightmapsModeLegacy.Single;
			}
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0000E8CC File Offset: 0x0000CACC
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("Use QualitySettings.desiredColorSpace instead.", false)]
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}
	}
}
