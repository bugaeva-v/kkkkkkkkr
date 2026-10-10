using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000133 RID: 307
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/LightmapData.h")]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class LightmapData
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0000E82C File Offset: 0x0000CA2C
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0000E844 File Offset: 0x0000CA44
		[Obsolete("Use lightmapColor property (UnityUpgradable) -> lightmapColor", false)]
		public Texture2D lightmapLight
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0000E850 File Offset: 0x0000CA50
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0000E844 File Offset: 0x0000CA44
		public Texture2D lightmapColor
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0000E868 File Offset: 0x0000CA68
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x0000E880 File Offset: 0x0000CA80
		public Texture2D lightmapDir
		{
			get
			{
				return this.m_Dir;
			}
			set
			{
				this.m_Dir = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0000E88C File Offset: 0x0000CA8C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x0000E8A4 File Offset: 0x0000CAA4
		public Texture2D shadowMask
		{
			get
			{
				return this.m_ShadowMask;
			}
			set
			{
				this.m_ShadowMask = value;
			}
		}

		// Token: 0x040003DA RID: 986
		internal Texture2D m_Light;

		// Token: 0x040003DB RID: 987
		internal Texture2D m_Dir;

		// Token: 0x040003DC RID: 988
		internal Texture2D m_ShadowMask;
	}
}
