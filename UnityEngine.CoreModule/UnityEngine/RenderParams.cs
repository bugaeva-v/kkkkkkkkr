using System;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200013A RID: 314
	public struct RenderParams
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x0000F020 File Offset: 0x0000D220
		public RenderParams(Material mat)
		{
			this.layer = 0;
			this.renderingLayerMask = GraphicsSettings.defaultRenderingLayerMask;
			this.rendererPriority = 0;
			this.worldBounds = new Bounds(Vector3.zero, Vector3.zero);
			this.camera = null;
			this.motionVectorMode = MotionVectorGenerationMode.Camera;
			this.reflectionProbeUsage = ReflectionProbeUsage.Off;
			this.material = mat;
			this.matProps = null;
			this.shadowCastingMode = ShadowCastingMode.Off;
			this.receiveShadows = false;
			this.lightProbeUsage = LightProbeUsage.Off;
			this.lightProbeProxyVolume = null;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		public int layer { readonly get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0000F0B9 File Offset: 0x0000D2B9
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x0000F0C1 File Offset: 0x0000D2C1
		public uint renderingLayerMask { readonly get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0000F0CA File Offset: 0x0000D2CA
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0000F0D2 File Offset: 0x0000D2D2
		public int rendererPriority { readonly get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0000F0DB File Offset: 0x0000D2DB
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0000F0E3 File Offset: 0x0000D2E3
		public Bounds worldBounds { readonly get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public Camera camera { readonly get; set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0000F0FD File Offset: 0x0000D2FD
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000F105 File Offset: 0x0000D305
		public MotionVectorGenerationMode motionVectorMode { readonly get; set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0000F10E File Offset: 0x0000D30E
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000F116 File Offset: 0x0000D316
		public ReflectionProbeUsage reflectionProbeUsage { readonly get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0000F11F File Offset: 0x0000D31F
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0000F127 File Offset: 0x0000D327
		public Material material { readonly get; set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0000F130 File Offset: 0x0000D330
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0000F138 File Offset: 0x0000D338
		public MaterialPropertyBlock matProps { readonly get; set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0000F141 File Offset: 0x0000D341
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0000F149 File Offset: 0x0000D349
		public ShadowCastingMode shadowCastingMode { readonly get; set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0000F152 File Offset: 0x0000D352
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0000F15A File Offset: 0x0000D35A
		public bool receiveShadows { readonly get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0000F163 File Offset: 0x0000D363
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0000F16B File Offset: 0x0000D36B
		public LightProbeUsage lightProbeUsage { readonly get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0000F174 File Offset: 0x0000D374
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0000F17C File Offset: 0x0000D37C
		public LightProbeProxyVolume lightProbeProxyVolume { readonly get; set; }
	}
}
