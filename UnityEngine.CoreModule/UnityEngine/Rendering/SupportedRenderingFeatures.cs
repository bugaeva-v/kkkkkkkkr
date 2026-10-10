using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200041A RID: 1050
	public class SupportedRenderingFeatures
	{
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0003D7CD File Offset: 0x0003B9CD
		public static SupportedRenderingFeatures active
		{
			get
			{
				bool flag = SupportedRenderingFeatures.s_Active == null;
				if (flag)
				{
					SupportedRenderingFeatures.s_Active = new SupportedRenderingFeatures();
				}
				return SupportedRenderingFeatures.s_Active;
			}
			set
			{
				SupportedRenderingFeatures.s_Active = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0003D7D6 File Offset: 0x0003B9D6
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0003D7DE File Offset: 0x0003B9DE
		public SupportedRenderingFeatures.ReflectionProbeModes reflectionProbeModes { get; set; } = SupportedRenderingFeatures.ReflectionProbeModes.None;

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0003D7E7 File Offset: 0x0003B9E7
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x0003D7EF File Offset: 0x0003B9EF
		public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; set; } = SupportedRenderingFeatures.LightmapMixedBakeModes.None;

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0003D800 File Offset: 0x0003BA00
		public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; set; } = SupportedRenderingFeatures.LightmapMixedBakeModes.IndirectOnly | SupportedRenderingFeatures.LightmapMixedBakeModes.Subtractive | SupportedRenderingFeatures.LightmapMixedBakeModes.Shadowmask;

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x0003D809 File Offset: 0x0003BA09
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0003D811 File Offset: 0x0003BA11
		public LightmapBakeType lightmapBakeTypes { get; set; } = LightmapBakeType.Realtime | LightmapBakeType.Baked | LightmapBakeType.Mixed;

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0003D81A File Offset: 0x0003BA1A
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0003D822 File Offset: 0x0003BA22
		public LightmapsMode lightmapsModes { get; set; } = LightmapsMode.CombinedDirectional;

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0003D82B File Offset: 0x0003BA2B
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0003D833 File Offset: 0x0003BA33
		public bool enlightenLightmapper { get; set; } = true;

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0003D83C File Offset: 0x0003BA3C
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0003D844 File Offset: 0x0003BA44
		public bool enlighten { get; set; } = true;

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x0003D84D File Offset: 0x0003BA4D
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0003D855 File Offset: 0x0003BA55
		public bool lightProbeProxyVolumes { get; set; } = true;

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0003D85E File Offset: 0x0003BA5E
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0003D866 File Offset: 0x0003BA66
		public bool motionVectors { get; set; } = true;

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0003D86F File Offset: 0x0003BA6F
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0003D877 File Offset: 0x0003BA77
		public bool receiveShadows { get; set; } = true;

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0003D880 File Offset: 0x0003BA80
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0003D888 File Offset: 0x0003BA88
		public bool reflectionProbes { get; set; } = true;

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x0003D891 File Offset: 0x0003BA91
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0003D899 File Offset: 0x0003BA99
		public bool reflectionProbesBlendDistance { get; set; } = true;

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0003D8A2 File Offset: 0x0003BAA2
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0003D8AA File Offset: 0x0003BAAA
		public bool rendererPriority { get; set; } = false;

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x0003D8B3 File Offset: 0x0003BAB3
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0003D8BB File Offset: 0x0003BABB
		public bool rendersUIOverlay { get; set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0003D8C4 File Offset: 0x0003BAC4
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0003D8CC File Offset: 0x0003BACC
		public bool overridesEnvironmentLighting { get; set; } = false;

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x0003D8D5 File Offset: 0x0003BAD5
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x0003D8DD File Offset: 0x0003BADD
		public bool overridesFog { get; set; } = false;

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0003D8E6 File Offset: 0x0003BAE6
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x0003D8EE File Offset: 0x0003BAEE
		public bool overridesRealtimeReflectionProbes { get; set; } = false;

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x0003D8F7 File Offset: 0x0003BAF7
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x0003D8FF File Offset: 0x0003BAFF
		public bool overridesOtherLightingSettings { get; set; } = false;

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0003D908 File Offset: 0x0003BB08
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0003D910 File Offset: 0x0003BB10
		public bool editableMaterialRenderQueue { get; set; } = true;

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0003D919 File Offset: 0x0003BB19
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x0003D921 File Offset: 0x0003BB21
		public bool overridesLODBias { get; set; } = false;

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0003D92A File Offset: 0x0003BB2A
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0003D932 File Offset: 0x0003BB32
		public bool overridesMaximumLODLevel { get; set; } = false;

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0003D93B File Offset: 0x0003BB3B
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0003D943 File Offset: 0x0003BB43
		public bool rendererProbes { get; set; } = true;

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0003D94C File Offset: 0x0003BB4C
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x0003D954 File Offset: 0x0003BB54
		public bool particleSystemInstancing { get; set; } = true;

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x0003D95D File Offset: 0x0003BB5D
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0003D965 File Offset: 0x0003BB65
		public bool autoAmbientProbeBaking { get; set; } = true;

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x0003D96E File Offset: 0x0003BB6E
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0003D976 File Offset: 0x0003BB76
		public bool autoDefaultReflectionProbeBaking { get; set; } = true;

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0003D97F File Offset: 0x0003BB7F
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0003D987 File Offset: 0x0003BB87
		public bool overridesShadowmask { get; set; } = false;

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0003D990 File Offset: 0x0003BB90
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0003D998 File Offset: 0x0003BB98
		public string overrideShadowmaskMessage { get; set; } = "";

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
		public string shadowmaskMessage
		{
			get
			{
				bool flag = !this.overridesShadowmask;
				string result;
				if (flag)
				{
					result = "The Shadowmask Mode used at run time can be set in the Quality Settings panel.";
				}
				else
				{
					result = this.overrideShadowmaskMessage;
				}
				return result;
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		internal unsafe static MixedLightingMode FallbackMixedLightingMode()
		{
			MixedLightingMode result;
			SupportedRenderingFeatures.FallbackMixedLightingModeByRef(new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		[RequiredByNativeCode]
		internal unsafe static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
			MixedLightingMode* ptr = (MixedLightingMode*)((void*)fallbackModePtr);
			bool flag = SupportedRenderingFeatures.active.defaultMixedLightingModes != SupportedRenderingFeatures.LightmapMixedBakeModes.None && (SupportedRenderingFeatures.active.mixedLightingModes & SupportedRenderingFeatures.active.defaultMixedLightingModes) == SupportedRenderingFeatures.active.defaultMixedLightingModes;
			if (flag)
			{
				SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes = SupportedRenderingFeatures.active.defaultMixedLightingModes;
				SupportedRenderingFeatures.LightmapMixedBakeModes lightmapMixedBakeModes = defaultMixedLightingModes;
				if (lightmapMixedBakeModes != SupportedRenderingFeatures.LightmapMixedBakeModes.Subtractive)
				{
					if (lightmapMixedBakeModes != SupportedRenderingFeatures.LightmapMixedBakeModes.Shadowmask)
					{
						*ptr = MixedLightingMode.IndirectOnly;
					}
					else
					{
						*ptr = MixedLightingMode.Shadowmask;
					}
				}
				else
				{
					*ptr = MixedLightingMode.Subtractive;
				}
			}
			else
			{
				bool flag2 = SupportedRenderingFeatures.IsMixedLightingModeSupported(MixedLightingMode.Shadowmask);
				if (flag2)
				{
					*ptr = MixedLightingMode.Shadowmask;
				}
				else
				{
					bool flag3 = SupportedRenderingFeatures.IsMixedLightingModeSupported(MixedLightingMode.Subtractive);
					if (flag3)
					{
						*ptr = MixedLightingMode.Subtractive;
					}
					else
					{
						*ptr = MixedLightingMode.IndirectOnly;
					}
				}
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0003DA94 File Offset: 0x0003BC94
		internal unsafe static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			bool result;
			SupportedRenderingFeatures.IsMixedLightingModeSupportedByRef(mixedMode, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
		[RequiredByNativeCode]
		internal unsafe static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			bool flag = !SupportedRenderingFeatures.IsLightmapBakeTypeSupported(LightmapBakeType.Mixed);
			if (flag)
			{
				*ptr = false;
			}
			else
			{
				*ptr = ((mixedMode == MixedLightingMode.IndirectOnly && (SupportedRenderingFeatures.active.mixedLightingModes & SupportedRenderingFeatures.LightmapMixedBakeModes.IndirectOnly) == SupportedRenderingFeatures.LightmapMixedBakeModes.IndirectOnly) || (mixedMode == MixedLightingMode.Subtractive && (SupportedRenderingFeatures.active.mixedLightingModes & SupportedRenderingFeatures.LightmapMixedBakeModes.Subtractive) == SupportedRenderingFeatures.LightmapMixedBakeModes.Subtractive) || (mixedMode == MixedLightingMode.Shadowmask && (SupportedRenderingFeatures.active.mixedLightingModes & SupportedRenderingFeatures.LightmapMixedBakeModes.Shadowmask) == SupportedRenderingFeatures.LightmapMixedBakeModes.Shadowmask));
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0003DB20 File Offset: 0x0003BD20
		internal unsafe static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			bool result;
			SupportedRenderingFeatures.IsLightmapBakeTypeSupportedByRef(bakeType, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0003DB44 File Offset: 0x0003BD44
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			bool flag = bakeType == LightmapBakeType.Mixed;
			if (flag)
			{
				bool flag2 = SupportedRenderingFeatures.IsLightmapBakeTypeSupported(LightmapBakeType.Baked);
				bool flag3 = !flag2 || SupportedRenderingFeatures.active.mixedLightingModes == SupportedRenderingFeatures.LightmapMixedBakeModes.None;
				if (flag3)
				{
					*ptr = false;
					return;
				}
			}
			*ptr = ((SupportedRenderingFeatures.active.lightmapBakeTypes & bakeType) == bakeType);
			bool flag4 = bakeType == LightmapBakeType.Realtime && !SupportedRenderingFeatures.active.enlighten;
			if (flag4)
			{
				*ptr = false;
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0003DBB8 File Offset: 0x0003BDB8
		internal unsafe static bool IsLightmapsModeSupported(LightmapsMode mode)
		{
			bool result;
			SupportedRenderingFeatures.IsLightmapsModeSupportedByRef(mode, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0003DBDC File Offset: 0x0003BDDC
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			*ptr = ((SupportedRenderingFeatures.active.lightmapsModes & mode) == mode);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0003DC04 File Offset: 0x0003BE04
		internal unsafe static bool IsLightmapperSupported(int lightmapper)
		{
			bool result;
			SupportedRenderingFeatures.IsLightmapperSupportedByRef(lightmapper, new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0003DC28 File Offset: 0x0003BE28
		[RequiredByNativeCode]
		internal unsafe static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			*ptr = (lightmapper != 0 || SupportedRenderingFeatures.active.enlightenLightmapper);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0003DC50 File Offset: 0x0003BE50
		[RequiredByNativeCode]
		internal unsafe static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			*ptr = SupportedRenderingFeatures.active.rendersUIOverlay;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0003DC74 File Offset: 0x0003BE74
		[RequiredByNativeCode]
		internal unsafe static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			*ptr = SupportedRenderingFeatures.active.autoAmbientProbeBaking;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0003DC98 File Offset: 0x0003BE98
		[RequiredByNativeCode]
		internal unsafe static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
			bool* ptr = (bool*)((void*)isSupportedPtr);
			*ptr = SupportedRenderingFeatures.active.autoDefaultReflectionProbeBaking;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0003DCBC File Offset: 0x0003BEBC
		internal unsafe static int FallbackLightmapper()
		{
			int result;
			SupportedRenderingFeatures.FallbackLightmapperByRef(new IntPtr((void*)(&result)));
			return result;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0003DCE0 File Offset: 0x0003BEE0
		[RequiredByNativeCode]
		internal unsafe static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
			int* ptr = (int*)((void*)lightmapperPtr);
			*ptr = 1;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("terrainDetailUnsupported is deprecated.")]
		public bool terrainDetailUnsupported
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x04000D6D RID: 3437
		private static SupportedRenderingFeatures s_Active = new SupportedRenderingFeatures();

		// Token: 0x0200041B RID: 1051
		[Flags]
		public enum ReflectionProbeModes
		{
			// Token: 0x04000D8A RID: 3466
			None = 0,
			// Token: 0x04000D8B RID: 3467
			Rotation = 1
		}

		// Token: 0x0200041C RID: 1052
		[Flags]
		public enum LightmapMixedBakeModes
		{
			// Token: 0x04000D8D RID: 3469
			None = 0,
			// Token: 0x04000D8E RID: 3470
			IndirectOnly = 1,
			// Token: 0x04000D8F RID: 3471
			Subtractive = 2,
			// Token: 0x04000D90 RID: 3472
			Shadowmask = 4
		}
	}
}
