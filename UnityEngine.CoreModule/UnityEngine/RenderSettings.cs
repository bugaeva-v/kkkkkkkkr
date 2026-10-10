using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000149 RID: 329
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	public sealed class RenderSettings : Object
	{
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00010758 File Offset: 0x0000E958
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0001076F File Offset: 0x0000E96F
		[Obsolete("Use RenderSettings.ambientIntensity instead (UnityUpgradable) -> ambientIntensity", false)]
		public static float ambientSkyboxAmount
		{
			get
			{
				return RenderSettings.ambientIntensity;
			}
			set
			{
				RenderSettings.ambientIntensity = value;
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		private RenderSettings()
		{
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C0F RID: 3087
		// (set) Token: 0x06000C10 RID: 3088
		[NativeProperty("UseFog")]
		public static extern bool fog { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C11 RID: 3089
		// (set) Token: 0x06000C12 RID: 3090
		[NativeProperty("LinearFogStart")]
		public static extern float fogStartDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C13 RID: 3091
		// (set) Token: 0x06000C14 RID: 3092
		[NativeProperty("LinearFogEnd")]
		public static extern float fogEndDistance { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C15 RID: 3093
		// (set) Token: 0x06000C16 RID: 3094
		public static extern FogMode fogMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0001077C File Offset: 0x0000E97C
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00010791 File Offset: 0x0000E991
		public static Color fogColor
		{
			get
			{
				Color result;
				RenderSettings.get_fogColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_fogColor_Injected(ref value);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C19 RID: 3097
		// (set) Token: 0x06000C1A RID: 3098
		public static extern float fogDensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C1B RID: 3099
		// (set) Token: 0x06000C1C RID: 3100
		public static extern AmbientMode ambientMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0001079C File Offset: 0x0000E99C
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000107B1 File Offset: 0x0000E9B1
		public static Color ambientSkyColor
		{
			get
			{
				Color result;
				RenderSettings.get_ambientSkyColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_ambientSkyColor_Injected(ref value);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000107BC File Offset: 0x0000E9BC
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x000107D1 File Offset: 0x0000E9D1
		public static Color ambientEquatorColor
		{
			get
			{
				Color result;
				RenderSettings.get_ambientEquatorColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_ambientEquatorColor_Injected(ref value);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000107DC File Offset: 0x0000E9DC
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x000107F1 File Offset: 0x0000E9F1
		public static Color ambientGroundColor
		{
			get
			{
				Color result;
				RenderSettings.get_ambientGroundColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_ambientGroundColor_Injected(ref value);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000C23 RID: 3107
		// (set) Token: 0x06000C24 RID: 3108
		public static extern float ambientIntensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000107FC File Offset: 0x0000E9FC
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00010811 File Offset: 0x0000EA11
		[NativeProperty("AmbientSkyColor")]
		public static Color ambientLight
		{
			get
			{
				Color result;
				RenderSettings.get_ambientLight_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_ambientLight_Injected(ref value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0001081C File Offset: 0x0000EA1C
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00010831 File Offset: 0x0000EA31
		public static Color subtractiveShadowColor
		{
			get
			{
				Color result;
				RenderSettings.get_subtractiveShadowColor_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_subtractiveShadowColor_Injected(ref value);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000C29 RID: 3113
		// (set) Token: 0x06000C2A RID: 3114
		[NativeProperty("SkyboxMaterial")]
		public static extern Material skybox { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000C2B RID: 3115
		// (set) Token: 0x06000C2C RID: 3116
		public static extern Light sun { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0001083C File Offset: 0x0000EA3C
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00010851 File Offset: 0x0000EA51
		public static SphericalHarmonicsL2 ambientProbe
		{
			[NativeMethod("GetFinalAmbientProbe")]
			get
			{
				SphericalHarmonicsL2 result;
				RenderSettings.get_ambientProbe_Injected(out result);
				return result;
			}
			set
			{
				RenderSettings.set_ambientProbe_Injected(ref value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000C2F RID: 3119
		// (set) Token: 0x06000C30 RID: 3120
		public static extern Texture customReflection { [MethodImpl(MethodImplOptions.InternalCall)] get; [NativeThrows] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000C31 RID: 3121
		// (set) Token: 0x06000C32 RID: 3122
		public static extern float reflectionIntensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000C33 RID: 3123
		// (set) Token: 0x06000C34 RID: 3124
		public static extern int reflectionBounces { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000C35 RID: 3125
		[NativeProperty("GeneratedSkyboxReflection")]
		internal static extern Cubemap defaultReflection { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000C36 RID: 3126
		// (set) Token: 0x06000C37 RID: 3127
		public static extern DefaultReflectionMode defaultReflectionMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000C38 RID: 3128
		// (set) Token: 0x06000C39 RID: 3129
		public static extern int defaultReflectionResolution { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000C3A RID: 3130
		// (set) Token: 0x06000C3B RID: 3131
		public static extern float haloStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000C3C RID: 3132
		// (set) Token: 0x06000C3D RID: 3133
		public static extern float flareStrength { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000C3E RID: 3134
		// (set) Token: 0x06000C3F RID: 3135
		public static extern float flareFadeSpeed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000C40 RID: 3136
		[FreeFunction("GetRenderSettings")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetRenderSettings();

		// Token: 0x06000C41 RID: 3137
		[StaticAccessor("RenderSettingsScripting", StaticAccessorType.DoubleColon)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();

		// Token: 0x06000C42 RID: 3138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_fogColor_Injected(out Color ret);

		// Token: 0x06000C43 RID: 3139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_fogColor_Injected(ref Color value);

		// Token: 0x06000C44 RID: 3140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_ambientSkyColor_Injected(out Color ret);

		// Token: 0x06000C45 RID: 3141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_ambientSkyColor_Injected(ref Color value);

		// Token: 0x06000C46 RID: 3142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_ambientEquatorColor_Injected(out Color ret);

		// Token: 0x06000C47 RID: 3143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_ambientEquatorColor_Injected(ref Color value);

		// Token: 0x06000C48 RID: 3144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_ambientGroundColor_Injected(out Color ret);

		// Token: 0x06000C49 RID: 3145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_ambientGroundColor_Injected(ref Color value);

		// Token: 0x06000C4A RID: 3146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_ambientLight_Injected(out Color ret);

		// Token: 0x06000C4B RID: 3147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_ambientLight_Injected(ref Color value);

		// Token: 0x06000C4C RID: 3148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_subtractiveShadowColor_Injected(out Color ret);

		// Token: 0x06000C4D RID: 3149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_subtractiveShadowColor_Injected(ref Color value);

		// Token: 0x06000C4E RID: 3150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret);

		// Token: 0x06000C4F RID: 3151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value);
	}
}
