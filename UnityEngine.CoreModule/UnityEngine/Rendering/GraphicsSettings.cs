using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020003E3 RID: 995
	[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
	[StaticAccessor("GetGraphicsSettings()", StaticAccessorType.Dot)]
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x06001FAA RID: 8106 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		private GraphicsSettings()
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001FAB RID: 8107
		// (set) Token: 0x06001FAC RID: 8108
		public static extern TransparencySortMode transparencySortMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00033E68 File Offset: 0x00032068
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00033E7D File Offset: 0x0003207D
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 result;
				GraphicsSettings.get_transparencySortAxis_Injected(out result);
				return result;
			}
			set
			{
				GraphicsSettings.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001FAF RID: 8111
		// (set) Token: 0x06001FB0 RID: 8112
		public static extern bool realtimeDirectRectangularAreaLights { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001FB1 RID: 8113
		// (set) Token: 0x06001FB2 RID: 8114
		public static extern bool lightsUseLinearIntensity { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001FB3 RID: 8115
		// (set) Token: 0x06001FB4 RID: 8116
		public static extern bool lightsUseColorTemperature { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001FB5 RID: 8117
		// (set) Token: 0x06001FB6 RID: 8118
		public static extern uint defaultRenderingLayerMask { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001FB7 RID: 8119
		// (set) Token: 0x06001FB8 RID: 8120
		public static extern bool useScriptableRenderPipelineBatching { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001FB9 RID: 8121
		// (set) Token: 0x06001FBA RID: 8122
		public static extern bool logWhenShaderIsCompiled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001FBB RID: 8123
		// (set) Token: 0x06001FBC RID: 8124
		public static extern bool disableBuiltinCustomRenderTextureUpdate { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001FBD RID: 8125
		public static extern VideoShadersIncludeMode videoShadersIncludeMode { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06001FBE RID: 8126
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash);

		// Token: 0x06001FBF RID: 8127 RVA: 0x00033E88 File Offset: 0x00032088
		public static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			return GraphicsSettings.HasShaderDefine(Graphics.activeTier, defineHash);
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001FC0 RID: 8128
		[NativeName("CurrentRenderPipeline")]
		private static extern ScriptableObject INTERNAL_currentRenderPipeline { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00033EA8 File Offset: 0x000320A8
		public static RenderPipelineAsset currentRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_currentRenderPipeline as RenderPipelineAsset;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00033EC4 File Offset: 0x000320C4
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00033EDB File Offset: 0x000320DB
		public static RenderPipelineAsset renderPipelineAsset
		{
			get
			{
				return GraphicsSettings.defaultRenderPipeline;
			}
			set
			{
				GraphicsSettings.defaultRenderPipeline = value;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001FC4 RID: 8132
		// (set) Token: 0x06001FC5 RID: 8133
		[NativeName("DefaultRenderPipeline")]
		private static extern ScriptableObject INTERNAL_defaultRenderPipeline { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00033EE8 File Offset: 0x000320E8
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00033F04 File Offset: 0x00032104
		public static RenderPipelineAsset defaultRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_defaultRenderPipeline as RenderPipelineAsset;
			}
			set
			{
				GraphicsSettings.INTERNAL_defaultRenderPipeline = value;
			}
		}

		// Token: 0x06001FC8 RID: 8136
		[NativeName("GetAllConfiguredRenderPipelinesForScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ScriptableObject[] GetAllConfiguredRenderPipelines();

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00033F10 File Offset: 0x00032110
		public static RenderPipelineAsset[] allConfiguredRenderPipelines
		{
			get
			{
				return GraphicsSettings.GetAllConfiguredRenderPipelines().Cast<RenderPipelineAsset>().ToArray<RenderPipelineAsset>();
			}
		}

		// Token: 0x06001FCA RID: 8138
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Object GetGraphicsSettings();

		// Token: 0x06001FCB RID: 8139
		[NativeName("SetShaderModeScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x06001FCC RID: 8140
		[NativeName("GetShaderModeScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern BuiltinShaderMode GetShaderMode(BuiltinShaderType type);

		// Token: 0x06001FCD RID: 8141
		[NativeName("SetCustomShaderScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCustomShader(BuiltinShaderType type, Shader shader);

		// Token: 0x06001FCE RID: 8142
		[NativeName("GetCustomShaderScript")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Shader GetCustomShader(BuiltinShaderType type);

		// Token: 0x06001FCF RID: 8143 RVA: 0x00033F31 File Offset: 0x00032131
		public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
		{
			GraphicsSettings.RegisterRenderPipeline(typeof(T).FullName, settings);
		}

		// Token: 0x06001FD0 RID: 8144
		[NativeName("RegisterRenderPipelineSettings")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterRenderPipeline(string renderpipelineName, Object settings);

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00033F4A File Offset: 0x0003214A
		public static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
		{
			GraphicsSettings.UnregisterRenderPipeline(typeof(T).FullName);
		}

		// Token: 0x06001FD2 RID: 8146
		[NativeName("UnregisterRenderPipelineSettings")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnregisterRenderPipeline(string renderpipelineName);

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00033F64 File Offset: 0x00032164
		public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
		{
			return GraphicsSettings.GetSettingsForRenderPipeline(typeof(T).FullName) as RenderPipelineGlobalSettings;
		}

		// Token: 0x06001FD4 RID: 8148
		[NativeName("GetSettingsForRenderPipeline")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object GetSettingsForRenderPipeline(string renderpipelineName);

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001FD5 RID: 8149
		// (set) Token: 0x06001FD6 RID: 8150
		public static extern bool cameraRelativeLightCulling { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001FD7 RID: 8151
		// (set) Token: 0x06001FD8 RID: 8152
		public static extern bool cameraRelativeShadowCulling { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001FD9 RID: 8153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_transparencySortAxis_Injected(out Vector3 ret);

		// Token: 0x06001FDA RID: 8154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_transparencySortAxis_Injected(ref Vector3 value);
	}
}
