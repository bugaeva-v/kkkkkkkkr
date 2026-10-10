using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001E9 RID: 489
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class ResourceRequest : AsyncOperation
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x000237B8 File Offset: 0x000219B8
		protected virtual Object GetResult()
		{
			return Resources.Load(this.m_Path, this.m_Type);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000237DC File Offset: 0x000219DC
		public Object asset
		{
			get
			{
				return this.GetResult();
			}
		}

		// Token: 0x040007CA RID: 1994
		internal string m_Path;

		// Token: 0x040007CB RID: 1995
		internal Type m_Type;
	}
}
