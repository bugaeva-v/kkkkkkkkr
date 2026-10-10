using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200011C RID: 284
	[NativeHeader("Runtime/Graphics/LightingSettings.h")]
	[PreventReadOnlyInstanceModification]
	public sealed class LightingSettings : Object
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x00004563 File Offset: 0x00002763
		[RequiredByNativeCode]
		internal void LightingSettingsDontStripMe()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000B81A File Offset: 0x00009A1A
		public LightingSettings()
		{
			LightingSettings.Internal_Create(this);
		}

		// Token: 0x06000797 RID: 1943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] LightingSettings self);

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000798 RID: 1944
		// (set) Token: 0x06000799 RID: 1945
		[NativeName("EnableBakedLightmaps")]
		public extern bool bakedGI { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600079A RID: 1946
		// (set) Token: 0x0600079B RID: 1947
		[NativeName("EnableRealtimeLightmaps")]
		public extern bool realtimeGI { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600079C RID: 1948
		// (set) Token: 0x0600079D RID: 1949
		[NativeName("RealtimeEnvironmentLighting")]
		public extern bool realtimeEnvironmentLighting { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
