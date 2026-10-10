using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000137 RID: 311
	[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
	[UsedByNativeCode]
	public class HDROutputSettings
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		internal HDROutputSettings()
		{
			this.m_DisplayIndex = 0;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
		internal HDROutputSettings(int displayIndex)
		{
			this.m_DisplayIndex = displayIndex;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		public static HDROutputSettings main
		{
			get
			{
				return HDROutputSettings._mainDisplay;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		public bool active
		{
			get
			{
				return HDROutputSettings.GetActive(this.m_DisplayIndex);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0000EBFC File Offset: 0x0000CDFC
		public bool available
		{
			get
			{
				return HDROutputSettings.GetAvailable(this.m_DisplayIndex);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0000EC39 File Offset: 0x0000CE39
		public bool automaticHDRTonemapping
		{
			get
			{
				return HDROutputSettings.GetAutomaticHDRTonemapping(this.m_DisplayIndex);
			}
			set
			{
				HDROutputSettings.SetAutomaticHDRTonemapping(this.m_DisplayIndex, value);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public ColorGamut displayColorGamut
		{
			get
			{
				return HDROutputSettings.GetDisplayColorGamut(this.m_DisplayIndex);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public RenderTextureFormat format
		{
			get
			{
				return GraphicsFormatUtility.GetRenderTextureFormat(HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0000EC90 File Offset: 0x0000CE90
		public GraphicsFormat graphicsFormat
		{
			get
			{
				return HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000ECCD File Offset: 0x0000CECD
		public float paperWhiteNits
		{
			get
			{
				return HDROutputSettings.GetPaperWhiteNits(this.m_DisplayIndex);
			}
			set
			{
				HDROutputSettings.SetPaperWhiteNits(this.m_DisplayIndex, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		public int maxFullFrameToneMapLuminance
		{
			get
			{
				return HDROutputSettings.GetMaxFullFrameToneMapLuminance(this.m_DisplayIndex);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public int maxToneMapLuminance
		{
			get
			{
				return HDROutputSettings.GetMaxToneMapLuminance(this.m_DisplayIndex);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0000ED20 File Offset: 0x0000CF20
		public int minToneMapLuminance
		{
			get
			{
				return HDROutputSettings.GetMinToneMapLuminance(this.m_DisplayIndex);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0000ED40 File Offset: 0x0000CF40
		public bool HDRModeChangeRequested
		{
			get
			{
				return HDROutputSettings.GetHDRModeChangeRequested(this.m_DisplayIndex);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000ED5D File Offset: 0x0000CF5D
		public void RequestHDRModeChange(bool enabled)
		{
			HDROutputSettings.RequestHDRModeChangeInternal(this.m_DisplayIndex, enabled);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000ED70 File Offset: 0x0000CF70
		[Obsolete("SetPaperWhiteInNits is deprecated, please use paperWhiteNits instead.")]
		public static void SetPaperWhiteInNits(float paperWhite)
		{
			int displayIndex = 0;
			bool available = HDROutputSettings.GetAvailable(displayIndex);
			if (available)
			{
				HDROutputSettings.SetPaperWhiteNits(displayIndex, paperWhite);
			}
		}

		// Token: 0x060009D6 RID: 2518
		[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetActive(int displayIndex);

		// Token: 0x060009D7 RID: 2519
		[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetAvailable(int displayIndex);

		// Token: 0x060009D8 RID: 2520
		[FreeFunction("HDROutputSettingsBindings::GetAutomaticHDRTonemapping", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetAutomaticHDRTonemapping(int displayIndex);

		// Token: 0x060009D9 RID: 2521
		[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetAutomaticHDRTonemapping(int displayIndex, bool scripted);

		// Token: 0x060009DA RID: 2522
		[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ColorGamut GetDisplayColorGamut(int displayIndex);

		// Token: 0x060009DB RID: 2523
		[FreeFunction("HDROutputSettingsBindings::GetGraphicsFormat", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GraphicsFormat GetGraphicsFormat(int displayIndex);

		// Token: 0x060009DC RID: 2524
		[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float GetPaperWhiteNits(int displayIndex);

		// Token: 0x060009DD RID: 2525
		[FreeFunction("HDROutputSettingsBindings::SetPaperWhiteNits", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetPaperWhiteNits(int displayIndex, float paperWhite);

		// Token: 0x060009DE RID: 2526
		[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxFullFrameToneMapLuminance(int displayIndex);

		// Token: 0x060009DF RID: 2527
		[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxToneMapLuminance(int displayIndex);

		// Token: 0x060009E0 RID: 2528
		[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMinToneMapLuminance(int displayIndex);

		// Token: 0x060009E1 RID: 2529
		[FreeFunction("HDROutputSettingsBindings::GetHDRModeChangeRequested", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetHDRModeChangeRequested(int displayIndex);

		// Token: 0x060009E2 RID: 2530
		[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = false, ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RequestHDRModeChangeInternal(int displayIndex, bool enabled);

		// Token: 0x040003E2 RID: 994
		private int m_DisplayIndex;

		// Token: 0x040003E3 RID: 995
		public static HDROutputSettings[] displays = new HDROutputSettings[]
		{
			new HDROutputSettings()
		};

		// Token: 0x040003E4 RID: 996
		private static HDROutputSettings _mainDisplay = HDROutputSettings.displays[0];
	}
}
