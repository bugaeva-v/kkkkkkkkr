using System;

namespace UnityEngine.Rendering.RendererUtils
{
	// Token: 0x0200042D RID: 1069
	public struct RendererListDesc
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x0003EE87 File Offset: 0x0003D087
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x0003EE8F File Offset: 0x0003D08F
		internal CullingResults cullingResult { readonly get; private set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x0003EE98 File Offset: 0x0003D098
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x0003EEA0 File Offset: 0x0003D0A0
		internal Camera camera { readonly get; set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x0003EEA9 File Offset: 0x0003D0A9
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x0003EEB1 File Offset: 0x0003D0B1
		internal ShaderTagId passName { readonly get; private set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x0003EEBA File Offset: 0x0003D0BA
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x0003EEC2 File Offset: 0x0003D0C2
		internal ShaderTagId[] passNames { readonly get; private set; }

		// Token: 0x06002540 RID: 9536 RVA: 0x0003EECB File Offset: 0x0003D0CB
		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera)
		{
			this = default(RendererListDesc);
			this.passName = passName;
			this.passNames = null;
			this.cullingResult = cullingResult;
			this.camera = camera;
			this.layerMask = -1;
			this.overrideMaterialPassIndex = 0;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0003EF03 File Offset: 0x0003D103
		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera)
		{
			this = default(RendererListDesc);
			this.passNames = passNames;
			this.passName = ShaderTagId.none;
			this.cullingResult = cullingResult;
			this.camera = camera;
			this.layerMask = -1;
			this.overrideMaterialPassIndex = 0;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0003EF40 File Offset: 0x0003D140
		public bool IsValid()
		{
			bool flag = this.camera == null || (this.passName == ShaderTagId.none && (this.passNames == null || this.passNames.Length == 0));
			return !flag;
		}

		// Token: 0x04000DDA RID: 3546
		public SortingCriteria sortingCriteria;

		// Token: 0x04000DDB RID: 3547
		public PerObjectData rendererConfiguration;

		// Token: 0x04000DDC RID: 3548
		public RenderQueueRange renderQueueRange;

		// Token: 0x04000DDD RID: 3549
		public RenderStateBlock? stateBlock;

		// Token: 0x04000DDE RID: 3550
		public Material overrideMaterial;

		// Token: 0x04000DDF RID: 3551
		public bool excludeObjectMotionVectors;

		// Token: 0x04000DE0 RID: 3552
		public int layerMask;

		// Token: 0x04000DE1 RID: 3553
		public int overrideMaterialPassIndex;
	}
}
