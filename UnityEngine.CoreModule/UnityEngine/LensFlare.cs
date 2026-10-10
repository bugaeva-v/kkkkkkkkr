using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000153 RID: 339
	[NativeHeader("Runtime/Camera/Flare.h")]
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E29 RID: 3625
		// (set) Token: 0x06000E2A RID: 3626
		public extern float brightness { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E2B RID: 3627
		// (set) Token: 0x06000E2C RID: 3628
		public extern float fadeSpeed { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00012BA4 File Offset: 0x00010DA4
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00012BBA File Offset: 0x00010DBA
		public Color color
		{
			get
			{
				Color result;
				this.get_color_Injected(out result);
				return result;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E2F RID: 3631
		// (set) Token: 0x06000E30 RID: 3632
		public extern Flare flare { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06000E32 RID: 3634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x06000E33 RID: 3635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void set_color_Injected(ref Color value);
	}
}
