using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000157 RID: 343
	[RequireComponent(typeof(Transform))]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Light.h")]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	public sealed class Light : Behaviour
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E45 RID: 3653
		// (set) Token: 0x06000E46 RID: 3654
		[NativeProperty("LightType")]
		public extern LightType type { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E47 RID: 3655
		// (set) Token: 0x06000E48 RID: 3656
		[NativeProperty("LightShape")]
		public extern LightShape shape { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E49 RID: 3657
		// (set) Token: 0x06000E4A RID: 3658
		public extern float spotAngle { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E4B RID: 3659
		// (set) Token: 0x06000E4C RID: 3660
		public extern float innerSpotAngle { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00012BC4 File Offset: 0x00010DC4
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00012BDA File Offset: 0x00010DDA
		public Color color
		{
			get
			{
				Color result;
				this.get_color_Injected(out result);
				return result;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E4F RID: 3663
		// (set) Token: 0x06000E50 RID: 3664
		public extern float colorTemperature { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E51 RID: 3665
		// (set) Token: 0x06000E52 RID: 3666
		public extern bool useColorTemperature { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E53 RID: 3667
		// (set) Token: 0x06000E54 RID: 3668
		public extern float intensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E55 RID: 3669
		// (set) Token: 0x06000E56 RID: 3670
		public extern float bounceIntensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E57 RID: 3671
		// (set) Token: 0x06000E58 RID: 3672
		public extern bool useBoundingSphereOverride { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00012BE4 File Offset: 0x00010DE4
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00012BFA File Offset: 0x00010DFA
		public Vector4 boundingSphereOverride
		{
			get
			{
				Vector4 result;
				this.get_boundingSphereOverride_Injected(out result);
				return result;
			}
			set
			{
				this.set_boundingSphereOverride_Injected(ref value);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E5B RID: 3675
		// (set) Token: 0x06000E5C RID: 3676
		public extern bool useViewFrustumForShadowCasterCull { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E5D RID: 3677
		// (set) Token: 0x06000E5E RID: 3678
		public extern int shadowCustomResolution { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E5F RID: 3679
		// (set) Token: 0x06000E60 RID: 3680
		public extern float shadowBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E61 RID: 3681
		// (set) Token: 0x06000E62 RID: 3682
		public extern float shadowNormalBias { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E63 RID: 3683
		// (set) Token: 0x06000E64 RID: 3684
		public extern float shadowNearPlane { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E65 RID: 3685
		// (set) Token: 0x06000E66 RID: 3686
		public extern bool useShadowMatrixOverride { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00012C04 File Offset: 0x00010E04
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00012C1A File Offset: 0x00010E1A
		public Matrix4x4 shadowMatrixOverride
		{
			get
			{
				Matrix4x4 result;
				this.get_shadowMatrixOverride_Injected(out result);
				return result;
			}
			set
			{
				this.set_shadowMatrixOverride_Injected(ref value);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000E69 RID: 3689
		// (set) Token: 0x06000E6A RID: 3690
		public extern float range { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E6B RID: 3691
		// (set) Token: 0x06000E6C RID: 3692
		public extern Flare flare { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00012C24 File Offset: 0x00010E24
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00012C3A File Offset: 0x00010E3A
		public LightBakingOutput bakingOutput
		{
			get
			{
				LightBakingOutput result;
				this.get_bakingOutput_Injected(out result);
				return result;
			}
			set
			{
				this.set_bakingOutput_Injected(ref value);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E6F RID: 3695
		// (set) Token: 0x06000E70 RID: 3696
		public extern int cullingMask { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E71 RID: 3697
		// (set) Token: 0x06000E72 RID: 3698
		public extern int renderingLayerMask { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E73 RID: 3699
		// (set) Token: 0x06000E74 RID: 3700
		public extern LightShadowCasterMode lightShadowCasterMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E75 RID: 3701
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Reset();

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E76 RID: 3702
		// (set) Token: 0x06000E77 RID: 3703
		public extern LightShadows shadows { [NativeMethod("GetShadowType")] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E78 RID: 3704
		// (set) Token: 0x06000E79 RID: 3705
		public extern float shadowStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E7A RID: 3706
		// (set) Token: 0x06000E7B RID: 3707
		public extern LightShadowResolution shadowResolution { [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00012C44 File Offset: 0x00010E44
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("Shadow softness is removed in Unity 5.0+", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float shadowSoftness
		{
			get
			{
				return 4f;
			}
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00012C5C File Offset: 0x00010E5C
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("Shadow softness is removed in Unity 5.0+", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float shadowSoftnessFade
		{
			get
			{
				return 1f;
			}
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E80 RID: 3712
		// (set) Token: 0x06000E81 RID: 3713
		public extern float[] layerShadowCullDistances { [FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = true, ThrowsException = false)] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E82 RID: 3714
		// (set) Token: 0x06000E83 RID: 3715
		public extern float cookieSize { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E84 RID: 3716
		// (set) Token: 0x06000E85 RID: 3717
		public extern Texture cookie { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E86 RID: 3718
		// (set) Token: 0x06000E87 RID: 3719
		public extern LightRenderMode renderMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00012C74 File Offset: 0x00010E74
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00012C8C File Offset: 0x00010E8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("warning bakedIndex has been removed please use bakingOutput.isBaked instead.", true)]
		public int bakedIndex
		{
			get
			{
				return this.m_BakedIndex;
			}
			set
			{
				this.m_BakedIndex = value;
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00012C96 File Offset: 0x00010E96
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer)
		{
			this.AddCommandBuffer(evt, buffer, ShadowMapPass.All);
		}

		// Token: 0x06000E8B RID: 3723
		[FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask);

		// Token: 0x06000E8C RID: 3724 RVA: 0x00012CA7 File Offset: 0x00010EA7
		public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType)
		{
			this.AddCommandBufferAsync(evt, buffer, ShadowMapPass.All, queueType);
		}

		// Token: 0x06000E8D RID: 3725
		[FreeFunction("Light_Bindings::AddCommandBufferAsync", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType);

		// Token: 0x06000E8E RID: 3726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);

		// Token: 0x06000E8F RID: 3727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveCommandBuffers(LightEvent evt);

		// Token: 0x06000E90 RID: 3728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void RemoveAllCommandBuffers();

		// Token: 0x06000E91 RID: 3729
		[FreeFunction("Light_Bindings::GetCommandBuffers", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern CommandBuffer[] GetCommandBuffers(LightEvent evt);

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E92 RID: 3730
		public extern int commandBufferCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00012CBC File Offset: 0x00010EBC
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00012CD3 File Offset: 0x00010ED3
		[Obsolete("Use QualitySettings.pixelLightCount instead.")]
		public static int pixelLightCount
		{
			get
			{
				return QualitySettings.pixelLightCount;
			}
			set
			{
				QualitySettings.pixelLightCount = value;
			}
		}

		// Token: 0x06000E95 RID: 3733
		[FreeFunction("Light_Bindings::GetLights")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Light[] GetLights(LightType type, int layer);

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00012CE0 File Offset: 0x00010EE0
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", true)]
		public float shadowConstantBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00012CF8 File Offset: 0x00010EF8
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", true)]
		public float shadowObjectSizeBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00012D10 File Offset: 0x00010F10
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00004563 File Offset: 0x00002763
		[Obsolete("light.attenuate was removed; all lights always attenuate now", true)]
		public bool attenuate
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x06000E9D RID: 3741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x06000E9E RID: 3742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_color_Injected(ref Color value);

		// Token: 0x06000E9F RID: 3743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_boundingSphereOverride_Injected(out Vector4 ret);

		// Token: 0x06000EA0 RID: 3744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_boundingSphereOverride_Injected(ref Vector4 value);

		// Token: 0x06000EA1 RID: 3745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_shadowMatrixOverride_Injected(out Matrix4x4 ret);

		// Token: 0x06000EA2 RID: 3746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_shadowMatrixOverride_Injected(ref Matrix4x4 value);

		// Token: 0x06000EA3 RID: 3747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_bakingOutput_Injected(out LightBakingOutput ret);

		// Token: 0x06000EA4 RID: 3748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_bakingOutput_Injected(ref LightBakingOutput value);

		// Token: 0x04000438 RID: 1080
		private int m_BakedIndex;
	}
}
