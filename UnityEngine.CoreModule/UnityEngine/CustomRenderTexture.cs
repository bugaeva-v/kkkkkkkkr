using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001AD RID: 429
	[NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
	[UsedByNativeCode]
	public sealed class CustomRenderTexture : RenderTexture
	{
		// Token: 0x06001296 RID: 4758
		[FreeFunction(Name = "CustomRenderTextureScripting::Create")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateCustomRenderTexture([Writable] CustomRenderTexture rt);

		// Token: 0x06001297 RID: 4759
		[NativeName("TriggerUpdate")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void TriggerUpdate(int count);

		// Token: 0x06001298 RID: 4760 RVA: 0x0001915F File Offset: 0x0001735F
		public void Update(int count)
		{
			CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
			this.TriggerUpdate(count);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00019172 File Offset: 0x00017372
		public void Update()
		{
			this.Update(1);
		}

		// Token: 0x0600129A RID: 4762
		[NativeName("TriggerInitialization")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void TriggerInitialization();

		// Token: 0x0600129B RID: 4763 RVA: 0x0001917D File Offset: 0x0001737D
		public void Initialize()
		{
			this.TriggerInitialization();
			CustomRenderTextureManager.InvokeTriggerInitialize(this);
		}

		// Token: 0x0600129C RID: 4764
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ClearUpdateZones();

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600129D RID: 4765
		// (set) Token: 0x0600129E RID: 4766
		public extern Material material { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600129F RID: 4767
		// (set) Token: 0x060012A0 RID: 4768
		public extern Material initializationMaterial { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060012A1 RID: 4769
		// (set) Token: 0x060012A2 RID: 4770
		public extern Texture initializationTexture { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060012A3 RID: 4771
		[FreeFunction(Name = "CustomRenderTextureScripting::GetUpdateZonesInternal", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void GetUpdateZonesInternal([NotNull("ArgumentNullException")] object updateZones);

		// Token: 0x060012A4 RID: 4772 RVA: 0x0001918E File Offset: 0x0001738E
		public void GetUpdateZones(List<CustomRenderTextureUpdateZone> updateZones)
		{
			this.GetUpdateZonesInternal(updateZones);
		}

		// Token: 0x060012A5 RID: 4773
		[FreeFunction(Name = "CustomRenderTextureScripting::SetUpdateZonesInternal", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetUpdateZonesInternal([Unmarshalled] CustomRenderTextureUpdateZone[] updateZones);

		// Token: 0x060012A6 RID: 4774
		[FreeFunction(Name = "CustomRenderTextureScripting::GetDoubleBufferRenderTexture", HasExplicitThis = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern RenderTexture GetDoubleBufferRenderTexture();

		// Token: 0x060012A7 RID: 4775
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EnsureDoubleBufferConsistency();

		// Token: 0x060012A8 RID: 4776 RVA: 0x0001919C File Offset: 0x0001739C
		public void SetUpdateZones(CustomRenderTextureUpdateZone[] updateZones)
		{
			bool flag = updateZones == null;
			if (flag)
			{
				throw new ArgumentNullException("updateZones");
			}
			this.SetUpdateZonesInternal(updateZones);
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060012A9 RID: 4777
		// (set) Token: 0x060012AA RID: 4778
		public extern CustomRenderTextureInitializationSource initializationSource { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x000191C8 File Offset: 0x000173C8
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x000191DE File Offset: 0x000173DE
		public Color initializationColor
		{
			get
			{
				Color result;
				this.get_initializationColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_initializationColor_Injected(ref value);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060012AD RID: 4781
		// (set) Token: 0x060012AE RID: 4782
		public extern CustomRenderTextureUpdateMode updateMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060012AF RID: 4783
		// (set) Token: 0x060012B0 RID: 4784
		public extern CustomRenderTextureUpdateMode initializationMode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060012B1 RID: 4785
		// (set) Token: 0x060012B2 RID: 4786
		public extern CustomRenderTextureUpdateZoneSpace updateZoneSpace { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060012B3 RID: 4787
		// (set) Token: 0x060012B4 RID: 4788
		public extern int shaderPass { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060012B5 RID: 4789
		// (set) Token: 0x060012B6 RID: 4790
		public extern uint cubemapFaceMask { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060012B7 RID: 4791
		// (set) Token: 0x060012B8 RID: 4792
		public extern bool doubleBuffered { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060012B9 RID: 4793
		// (set) Token: 0x060012BA RID: 4794
		public extern bool wrapUpdateZones { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060012BB RID: 4795
		// (set) Token: 0x060012BC RID: 4796
		public extern float updatePeriod { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060012BD RID: 4797 RVA: 0x000191E8 File Offset: 0x000173E8
		public CustomRenderTexture(int width, int height, RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite) : this(width, height, RenderTexture.GetCompatibleFormat(format, readWrite))
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000191FC File Offset: 0x000173FC
		[ExcludeFromDocs]
		public CustomRenderTexture(int width, int height, RenderTextureFormat format) : this(width, height, format, RenderTextureReadWrite.Default)
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0001920A File Offset: 0x0001740A
		[ExcludeFromDocs]
		public CustomRenderTexture(int width, int height) : this(width, height, SystemInfo.GetGraphicsFormat(DefaultFormat.LDR))
		{
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0001921C File Offset: 0x0001741C
		[ExcludeFromDocs]
		public CustomRenderTexture(int width, int height, [DefaultValue("DefaultFormat.LDR")] DefaultFormat defaultFormat) : this(width, height, RenderTexture.GetDefaultColorFormat(defaultFormat))
		{
			bool flag = defaultFormat == DefaultFormat.DepthStencil || defaultFormat == DefaultFormat.Shadow;
			if (flag)
			{
				base.depthStencilFormat = SystemInfo.GetGraphicsFormat(defaultFormat);
			}
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00019258 File Offset: 0x00017458
		[ExcludeFromDocs]
		public CustomRenderTexture(int width, int height, GraphicsFormat format)
		{
			bool flag = format != GraphicsFormat.None && !base.ValidateFormat(format, FormatUsage.Render);
			if (!flag)
			{
				CustomRenderTexture.Internal_CreateCustomRenderTexture(this);
				this.width = width;
				this.height = height;
				base.graphicsFormat = format;
				base.SetSRGBReadWrite(GraphicsFormatUtility.IsSRGBFormat(format));
			}
		}

		// Token: 0x060012C2 RID: 4802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_initializationColor_Injected(out Color ret);

		// Token: 0x060012C3 RID: 4803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_initializationColor_Injected(ref Color value);
	}
}
