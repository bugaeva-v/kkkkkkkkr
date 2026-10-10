using System;

namespace UnityEngine.Rendering.RendererUtils
{
	// Token: 0x0200042E RID: 1070
	internal struct RendererListParams
	{
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x0003EF96 File Offset: 0x0003D196
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x0003EF9E File Offset: 0x0003D19E
		public bool isValid { readonly get; private set; }

		// Token: 0x06002545 RID: 9541 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		internal static RendererListParams Create(in RendererListDesc desc)
		{
			RendererListParams rendererListParams = default(RendererListParams);
			RendererListDesc rendererListDesc = desc;
			bool flag = !rendererListDesc.IsValid();
			RendererListParams result;
			if (flag)
			{
				result = rendererListParams;
			}
			else
			{
				SortingSettings sortingSettings = new SortingSettings(desc.camera)
				{
					criteria = desc.sortingCriteria
				};
				DrawingSettings drawingSettings = new DrawingSettings(RendererListParams.s_EmptyName, sortingSettings)
				{
					perObjectData = desc.rendererConfiguration
				};
				bool flag2 = desc.passName != ShaderTagId.none;
				if (flag2)
				{
					Debug.Assert(desc.passNames == null);
					drawingSettings.SetShaderPassName(0, desc.passName);
				}
				else
				{
					for (int i = 0; i < desc.passNames.Length; i++)
					{
						drawingSettings.SetShaderPassName(i, desc.passNames[i]);
					}
				}
				bool flag3 = desc.overrideMaterial != null;
				if (flag3)
				{
					drawingSettings.overrideMaterial = desc.overrideMaterial;
					drawingSettings.overrideMaterialPassIndex = desc.overrideMaterialPassIndex;
				}
				FilteringSettings filteringSettings = new FilteringSettings(new RenderQueueRange?(desc.renderQueueRange), desc.layerMask, uint.MaxValue, 0)
				{
					excludeMotionVectorObjects = desc.excludeObjectMotionVectors
				};
				rendererListParams.isValid = true;
				rendererListParams.cullingResult = desc.cullingResult;
				rendererListParams.drawSettings = drawingSettings;
				rendererListParams.filteringSettings = filteringSettings;
				rendererListParams.stateBlock = desc.stateBlock;
				result = rendererListParams;
			}
			return result;
		}

		// Token: 0x04000DE6 RID: 3558
		private static readonly ShaderTagId s_EmptyName = new ShaderTagId("");

		// Token: 0x04000DE7 RID: 3559
		public static readonly RendererListParams nullRendererList = default(RendererListParams);

		// Token: 0x04000DE9 RID: 3561
		internal CullingResults cullingResult;

		// Token: 0x04000DEA RID: 3562
		internal DrawingSettings drawSettings;

		// Token: 0x04000DEB RID: 3563
		internal FilteringSettings filteringSettings;

		// Token: 0x04000DEC RID: 3564
		internal RenderStateBlock? stateBlock;
	}
}
