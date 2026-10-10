using System;
using System.Diagnostics;

namespace UnityEngine
{
	// Token: 0x020001E8 RID: 488
	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class IconAttribute : Attribute
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x0002379D File Offset: 0x0002199D
		public string path
		{
			get
			{
				return this.m_IconPath;
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002059 File Offset: 0x00000259
		private IconAttribute()
		{
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000237A5 File Offset: 0x000219A5
		public IconAttribute(string path)
		{
			this.m_IconPath = path;
		}

		// Token: 0x040007C9 RID: 1993
		private string m_IconPath;
	}
}
