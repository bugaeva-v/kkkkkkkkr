using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000148 RID: 328
	[UsedByNativeCode]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public class Renderer : Component
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0001043C File Offset: 0x0000E63C
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00010457 File Offset: 0x0000E657
		[Obsolete("Use shadowCastingMode instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool castShadows
		{
			get
			{
				return this.shadowCastingMode > ShadowCastingMode.Off;
			}
			set
			{
				this.shadowCastingMode = (value ? ShadowCastingMode.On : ShadowCastingMode.Off);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00010468 File Offset: 0x0000E668
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00010483 File Offset: 0x0000E683
		[Obsolete("Use motionVectorGenerationMode instead.", false)]
		public bool motionVectors
		{
			get
			{
				return this.motionVectorGenerationMode == MotionVectorGenerationMode.Object;
			}
			set
			{
				this.motionVectorGenerationMode = (value ? MotionVectorGenerationMode.Object : MotionVectorGenerationMode.Camera);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00010494 File Offset: 0x0000E694
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000104AF File Offset: 0x0000E6AF
		[Obsolete("Use lightProbeUsage instead.", false)]
		public bool useLightProbes
		{
			get
			{
				return this.lightProbeUsage > LightProbeUsage.Off;
			}
			set
			{
				this.lightProbeUsage = (value ? LightProbeUsage.BlendProbes : LightProbeUsage.Off);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000104C0 File Offset: 0x0000E6C0
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000104D6 File Offset: 0x0000E6D6
		public Bounds bounds
		{
			[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
			get
			{
				Bounds result;
				this.get_bounds_Injected(out result);
				return result;
			}
			[NativeName("SetWorldAABB")]
			set
			{
				this.set_bounds_Injected(ref value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000104E0 File Offset: 0x0000E6E0
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x000104F6 File Offset: 0x0000E6F6
		public Bounds localBounds
		{
			[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = true)]
			get
			{
				Bounds result;
				this.get_localBounds_Injected(out result);
				return result;
			}
			[NativeName("SetLocalAABB")]
			set
			{
				this.set_localBounds_Injected(ref value);
			}
		}

		// Token: 0x06000BA5 RID: 2981
		[NativeName("ResetWorldAABB")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetBounds();

		// Token: 0x06000BA6 RID: 2982
		[NativeName("ResetLocalAABB")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetLocalBounds();

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00010500 File Offset: 0x0000E700
		[FreeFunction(Name = "RendererScripting::SetStaticLightmapST", HasExplicitThis = true)]
		private void SetStaticLightmapST(Vector4 st)
		{
			this.SetStaticLightmapST_Injected(ref st);
		}

		// Token: 0x06000BA8 RID: 2984
		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Material GetMaterial();

		// Token: 0x06000BA9 RID: 2985
		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Material GetSharedMaterial();

		// Token: 0x06000BAA RID: 2986
		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetMaterial(Material m);

		// Token: 0x06000BAB RID: 2987
		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Material[] GetMaterialArray();

		// Token: 0x06000BAC RID: 2988
		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void CopyMaterialArray([Out] Material[] m);

		// Token: 0x06000BAD RID: 2989
		[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void CopySharedMaterialArray([Out] Material[] m);

		// Token: 0x06000BAE RID: 2990
		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m);

		// Token: 0x06000BAF RID: 2991
		[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_SetPropertyBlock(MaterialPropertyBlock properties);

		// Token: 0x06000BB0 RID: 2992
		[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_GetPropertyBlock([NotNull("ArgumentNullException")] MaterialPropertyBlock dest);

		// Token: 0x06000BB1 RID: 2993
		[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex);

		// Token: 0x06000BB2 RID: 2994
		[FreeFunction(Name = "RendererScripting::GetPropertyBlockMaterialIndex", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void Internal_GetPropertyBlockMaterialIndex([NotNull("ArgumentNullException")] MaterialPropertyBlock dest, int materialIndex);

		// Token: 0x06000BB3 RID: 2995
		[FreeFunction(Name = "RendererScripting::HasPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasPropertyBlock();

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001050A File Offset: 0x0000E70A
		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_SetPropertyBlock(properties);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00010515 File Offset: 0x0000E715
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_SetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00010521 File Offset: 0x0000E721
		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
			this.Internal_GetPropertyBlock(properties);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0001052C File Offset: 0x0000E72C
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
			this.Internal_GetPropertyBlockMaterialIndex(properties, materialIndex);
		}

		// Token: 0x06000BB8 RID: 3000
		[FreeFunction(Name = "RendererScripting::GetClosestReflectionProbes", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000BB9 RID: 3001
		// (set) Token: 0x06000BBA RID: 3002
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000BBB RID: 3003
		public extern bool isVisible { [NativeName("IsVisibleInScene")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000BBC RID: 3004
		// (set) Token: 0x06000BBD RID: 3005
		public extern ShadowCastingMode shadowCastingMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000BBE RID: 3006
		// (set) Token: 0x06000BBF RID: 3007
		public extern bool receiveShadows { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000BC0 RID: 3008
		// (set) Token: 0x06000BC1 RID: 3009
		public extern bool forceRenderingOff { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000BC2 RID: 3010
		[NativeName("GetIsStaticShadowCaster")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetIsStaticShadowCaster();

		// Token: 0x06000BC3 RID: 3011
		[NativeName("SetIsStaticShadowCaster")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIsStaticShadowCaster(bool value);

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00010538 File Offset: 0x0000E738
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00010550 File Offset: 0x0000E750
		public bool staticShadowCaster
		{
			get
			{
				return this.GetIsStaticShadowCaster();
			}
			set
			{
				this.SetIsStaticShadowCaster(value);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000BC6 RID: 3014
		// (set) Token: 0x06000BC7 RID: 3015
		public extern MotionVectorGenerationMode motionVectorGenerationMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000BC8 RID: 3016
		// (set) Token: 0x06000BC9 RID: 3017
		public extern LightProbeUsage lightProbeUsage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000BCA RID: 3018
		// (set) Token: 0x06000BCB RID: 3019
		public extern ReflectionProbeUsage reflectionProbeUsage { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BCC RID: 3020
		// (set) Token: 0x06000BCD RID: 3021
		public extern uint renderingLayerMask { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000BCE RID: 3022
		// (set) Token: 0x06000BCF RID: 3023
		public extern int rendererPriority { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000BD0 RID: 3024
		// (set) Token: 0x06000BD1 RID: 3025
		public extern RayTracingMode rayTracingMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000BD2 RID: 3026
		// (set) Token: 0x06000BD3 RID: 3027
		public extern string sortingLayerName { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000BD4 RID: 3028
		// (set) Token: 0x06000BD5 RID: 3029
		public extern int sortingLayerID { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000BD6 RID: 3030
		// (set) Token: 0x06000BD7 RID: 3031
		public extern int sortingOrder { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000BD8 RID: 3032
		// (set) Token: 0x06000BD9 RID: 3033
		internal extern int sortingGroupID { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000BDA RID: 3034
		// (set) Token: 0x06000BDB RID: 3035
		internal extern int sortingGroupOrder { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000BDC RID: 3036
		// (set) Token: 0x06000BDD RID: 3037
		[NativeProperty("IsDynamicOccludee")]
		public extern bool allowOcclusionWhenDynamic { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000BDE RID: 3038
		// (set) Token: 0x06000BDF RID: 3039
		[NativeProperty("StaticBatchRoot")]
		internal extern Transform staticBatchRootTransform { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000BE0 RID: 3040
		internal extern int staticBatchIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000BE1 RID: 3041
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetStaticBatchInfo(int firstSubMesh, int subMeshCount);

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000BE2 RID: 3042
		public extern bool isPartOfStaticBatch { [NativeName("IsPartOfStaticBatch")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0001055C File Offset: 0x0000E75C
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_worldToLocalMatrix_Injected(out result);
				return result;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00010574 File Offset: 0x0000E774
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 result;
				this.get_localToWorldMatrix_Injected(out result);
				return result;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000BE5 RID: 3045
		// (set) Token: 0x06000BE6 RID: 3046
		public extern GameObject lightProbeProxyVolumeOverride { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000BE7 RID: 3047
		// (set) Token: 0x06000BE8 RID: 3048
		public extern Transform probeAnchor { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000BE9 RID: 3049
		[NativeName("GetLightmapIndexInt")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetLightmapIndex(LightmapType lt);

		// Token: 0x06000BEA RID: 3050
		[NativeName("SetLightmapIndexInt")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetLightmapIndex(int index, LightmapType lt);

		// Token: 0x06000BEB RID: 3051 RVA: 0x0001058C File Offset: 0x0000E78C
		[NativeName("GetLightmapST")]
		private Vector4 GetLightmapST(LightmapType lt)
		{
			Vector4 result;
			this.GetLightmapST_Injected(lt, out result);
			return result;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000105A3 File Offset: 0x0000E7A3
		[NativeName("SetLightmapST")]
		private void SetLightmapST(Vector4 st, LightmapType lt)
		{
			this.SetLightmapST_Injected(ref st, lt);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x000105B0 File Offset: 0x0000E7B0
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x000105C9 File Offset: 0x0000E7C9
		public int lightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(LightmapType.StaticLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, LightmapType.StaticLightmap);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000105D8 File Offset: 0x0000E7D8
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x000105F1 File Offset: 0x0000E7F1
		public int realtimeLightmapIndex
		{
			get
			{
				return this.GetLightmapIndex(LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapIndex(value, LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00010600 File Offset: 0x0000E800
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00010619 File Offset: 0x0000E819
		public Vector4 lightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(LightmapType.StaticLightmap);
			}
			set
			{
				this.SetStaticLightmapST(value);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00010624 File Offset: 0x0000E824
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0001063D File Offset: 0x0000E83D
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				return this.GetLightmapST(LightmapType.DynamicLightmap);
			}
			set
			{
				this.SetLightmapST(value, LightmapType.DynamicLightmap);
			}
		}

		// Token: 0x06000BF5 RID: 3061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetMaterialCount();

		// Token: 0x06000BF6 RID: 3062
		[NativeName("GetMaterialArray")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Material[] GetSharedMaterialArray();

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0001064C File Offset: 0x0000E84C
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00010664 File Offset: 0x0000E864
		public Material[] materials
		{
			get
			{
				return this.GetMaterialArray();
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00010670 File Offset: 0x0000E870
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00010688 File Offset: 0x0000E888
		public Material material
		{
			get
			{
				return this.GetMaterial();
			}
			set
			{
				this.SetMaterial(value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00010694 File Offset: 0x0000E894
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00010688 File Offset: 0x0000E888
		public Material sharedMaterial
		{
			get
			{
				return this.GetSharedMaterial();
			}
			set
			{
				this.SetMaterial(value);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000106AC File Offset: 0x0000E8AC
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00010664 File Offset: 0x0000E864
		public Material[] sharedMaterials
		{
			get
			{
				return this.GetSharedMaterialArray();
			}
			set
			{
				this.SetMaterialArray(value);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public void GetMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopyMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00010704 File Offset: 0x0000E904
		public void GetSharedMaterials(List<Material> m)
		{
			bool flag = m == null;
			if (flag)
			{
				throw new ArgumentNullException("The result material list cannot be null.", "m");
			}
			NoAllocHelpers.EnsureListElemCount<Material>(m, this.GetMaterialCount());
			this.CopySharedMaterialArray(NoAllocHelpers.ExtractArrayFromListT<Material>(m));
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00010744 File Offset: 0x0000E944
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
			this.GetClosestReflectionProbesInternal(result);
		}

		// Token: 0x06000C03 RID: 3075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x06000C04 RID: 3076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_bounds_Injected(ref Bounds value);

		// Token: 0x06000C05 RID: 3077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_localBounds_Injected(out Bounds ret);

		// Token: 0x06000C06 RID: 3078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_localBounds_Injected(ref Bounds value);

		// Token: 0x06000C07 RID: 3079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetStaticLightmapST_Injected(ref Vector4 st);

		// Token: 0x06000C08 RID: 3080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_worldToLocalMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000C09 RID: 3081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_localToWorldMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x06000C0A RID: 3082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetLightmapST_Injected(LightmapType lt, out Vector4 ret);

		// Token: 0x06000C0B RID: 3083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetLightmapST_Injected(ref Vector4 st, LightmapType lt);
	}
}
