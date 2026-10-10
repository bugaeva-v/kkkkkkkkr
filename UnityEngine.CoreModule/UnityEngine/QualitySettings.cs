using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200013D RID: 317
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	public sealed class QualitySettings : Object
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x0000F25C File Offset: 0x0000D45C
		public static void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() + 1, applyExpensiveChanges);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0000F26D File Offset: 0x0000D46D
		public static void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges)
		{
			QualitySettings.SetQualityLevel(QualitySettings.GetQualityLevel() - 1, applyExpensiveChanges);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0000F27E File Offset: 0x0000D47E
		public static void SetQualityLevel(int index)
		{
			QualitySettings.SetQualityLevel(index, true);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0000F289 File Offset: 0x0000D489
		public static void IncreaseLevel()
		{
			QualitySettings.IncreaseLevel(false);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0000F293 File Offset: 0x0000D493
		public static void DecreaseLevel()
		{
			QualitySettings.DecreaseLevel(false);
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0000F27E File Offset: 0x0000D47E
		[Obsolete("Use GetQualityLevel and SetQualityLevel", false)]
		public static QualityLevel currentLevel
		{
			get
			{
				return (QualityLevel)QualitySettings.GetQualityLevel();
			}
			set
			{
				QualitySettings.SetQualityLevel((int)value, true);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		private QualitySettings()
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A1D RID: 2589
		// (set) Token: 0x06000A1E RID: 2590
		public static extern int pixelLightCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A1F RID: 2591
		// (set) Token: 0x06000A20 RID: 2592
		[NativeProperty("ShadowQuality")]
		public static extern ShadowQuality shadows { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A21 RID: 2593
		// (set) Token: 0x06000A22 RID: 2594
		public static extern ShadowProjection shadowProjection { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A23 RID: 2595
		// (set) Token: 0x06000A24 RID: 2596
		public static extern int shadowCascades { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A25 RID: 2597
		// (set) Token: 0x06000A26 RID: 2598
		public static extern float shadowDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A27 RID: 2599
		// (set) Token: 0x06000A28 RID: 2600
		[NativeProperty("ShadowResolution")]
		public static extern ShadowResolution shadowResolution { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A29 RID: 2601
		// (set) Token: 0x06000A2A RID: 2602
		[NativeProperty("ShadowmaskMode")]
		public static extern ShadowmaskMode shadowmaskMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A2B RID: 2603
		// (set) Token: 0x06000A2C RID: 2604
		public static extern float shadowNearPlaneOffset { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A2D RID: 2605
		// (set) Token: 0x06000A2E RID: 2606
		public static extern float shadowCascade2Split { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0000F2CD File Offset: 0x0000D4CD
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 result;
				QualitySettings.get_shadowCascade4Split_Injected(out result);
				return result;
			}
			set
			{
				QualitySettings.set_shadowCascade4Split_Injected(ref value);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A31 RID: 2609
		// (set) Token: 0x06000A32 RID: 2610
		[NativeProperty("LODBias")]
		public static extern float lodBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A33 RID: 2611
		// (set) Token: 0x06000A34 RID: 2612
		[NativeProperty("AnisotropicTextures")]
		public static extern AnisotropicFiltering anisotropicFiltering { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A35 RID: 2613
		// (set) Token: 0x06000A36 RID: 2614
		public static extern int masterTextureLimit { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A37 RID: 2615
		// (set) Token: 0x06000A38 RID: 2616
		public static extern int maximumLODLevel { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A39 RID: 2617
		// (set) Token: 0x06000A3A RID: 2618
		public static extern int particleRaycastBudget { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A3B RID: 2619
		// (set) Token: 0x06000A3C RID: 2620
		public static extern bool softParticles { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A3D RID: 2621
		// (set) Token: 0x06000A3E RID: 2622
		public static extern bool softVegetation { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A3F RID: 2623
		// (set) Token: 0x06000A40 RID: 2624
		public static extern int vSyncCount { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A41 RID: 2625
		// (set) Token: 0x06000A42 RID: 2626
		public static extern int realtimeGICPUUsage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A43 RID: 2627
		// (set) Token: 0x06000A44 RID: 2628
		public static extern int antiAliasing { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A45 RID: 2629
		// (set) Token: 0x06000A46 RID: 2630
		public static extern int asyncUploadTimeSlice { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A47 RID: 2631
		// (set) Token: 0x06000A48 RID: 2632
		public static extern int asyncUploadBufferSize { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A49 RID: 2633
		// (set) Token: 0x06000A4A RID: 2634
		public static extern bool asyncUploadPersistentBuffer { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A4B RID: 2635
		[NativeName("SetLODSettings")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLODSettings(float lodBias, int maximumLODLevel, bool setDirty = true);

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A4C RID: 2636
		// (set) Token: 0x06000A4D RID: 2637
		public static extern bool realtimeReflectionProbes { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A4E RID: 2638
		// (set) Token: 0x06000A4F RID: 2639
		public static extern bool billboardsFaceCameraPosition { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A50 RID: 2640
		// (set) Token: 0x06000A51 RID: 2641
		public static extern float resolutionScalingFixedDPIFactor { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A52 RID: 2642
		// (set) Token: 0x06000A53 RID: 2643
		[NativeName("RenderPipeline")]
		private static extern ScriptableObject INTERNAL_renderPipeline { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public static RenderPipelineAsset renderPipeline
		{
			get
			{
				return QualitySettings.INTERNAL_renderPipeline as RenderPipelineAsset;
			}
			set
			{
				QualitySettings.INTERNAL_renderPipeline = value;
			}
		}

		// Token: 0x06000A56 RID: 2646
		[NativeName("GetRenderPipelineAssetAt")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern ScriptableObject InternalGetRenderPipelineAssetAt(int index);

		// Token: 0x06000A57 RID: 2647 RVA: 0x0000F300 File Offset: 0x0000D500
		public static RenderPipelineAsset GetRenderPipelineAssetAt(int index)
		{
			bool flag = index < 0 || index >= QualitySettings.names.Length;
			if (flag)
			{
				throw new IndexOutOfRangeException(string.Format("{0} is out of range [0..{1}[", "index", QualitySettings.names.Length));
			}
			return QualitySettings.InternalGetRenderPipelineAssetAt(index) as RenderPipelineAsset;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A58 RID: 2648
		// (set) Token: 0x06000A59 RID: 2649
		[Obsolete("blendWeights is obsolete. Use skinWeights instead (UnityUpgradable) -> skinWeights", true)]
		public static extern BlendWeights blendWeights { [NativeName("GetSkinWeights")] [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeName("SetSkinWeights")] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A5A RID: 2650
		// (set) Token: 0x06000A5B RID: 2651
		public static extern SkinWeights skinWeights { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A5C RID: 2652
		// (set) Token: 0x06000A5D RID: 2653
		public static extern bool streamingMipmapsActive { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A5E RID: 2654
		// (set) Token: 0x06000A5F RID: 2655
		public static extern float streamingMipmapsMemoryBudget { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A60 RID: 2656
		// (set) Token: 0x06000A61 RID: 2657
		public static extern int streamingMipmapsRenderersPerFrame { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A62 RID: 2658
		// (set) Token: 0x06000A63 RID: 2659
		public static extern int streamingMipmapsMaxLevelReduction { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A64 RID: 2660
		// (set) Token: 0x06000A65 RID: 2661
		public static extern bool streamingMipmapsAddAllCameras { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A66 RID: 2662
		// (set) Token: 0x06000A67 RID: 2663
		public static extern int streamingMipmapsMaxFileIORequests { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A68 RID: 2664
		// (set) Token: 0x06000A69 RID: 2665
		[StaticAccessor("QualitySettingsScripting", StaticAccessorType.DoubleColon)]
		public static extern int maxQueuedFrames { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000A6A RID: 2666
		[NativeName("GetCurrentIndex")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetQualityLevel();

		// Token: 0x06000A6B RID: 2667
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object GetQualitySettings();

		// Token: 0x06000A6C RID: 2668
		[NativeName("SetCurrentIndex")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A6D RID: 2669
		[NativeProperty("QualitySettingsNames")]
		public static extern string[] names { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A6E RID: 2670
		public static extern ColorSpace desiredColorSpace { [NativeName("GetColorSpace")] [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A6F RID: 2671
		public static extern ColorSpace activeColorSpace { [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)] [NativeName("GetColorSpace")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000A70 RID: 2672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_shadowCascade4Split_Injected(out Vector3 ret);

		// Token: 0x06000A71 RID: 2673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_shadowCascade4Split_Injected(ref Vector3 value);
	}
}
