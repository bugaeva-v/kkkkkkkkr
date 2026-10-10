using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F8 RID: 504
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[UsedByNativeCode]
	public class HelpURLAttribute : Attribute
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x00023F9B File Offset: 0x0002219B
		public HelpURLAttribute(string url)
		{
			this.m_Url = url;
			this.m_DispatchingFieldName = "";
			this.m_Dispatcher = false;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00023FBE File Offset: 0x000221BE
		internal HelpURLAttribute(string defaultURL, string dispatchingFieldName)
		{
			this.m_Url = defaultURL;
			this.m_DispatchingFieldName = dispatchingFieldName;
			this.m_Dispatcher = !string.IsNullOrEmpty(dispatchingFieldName);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00023FE5 File Offset: 0x000221E5
		public string URL
		{
			get
			{
				return this.m_Url;
			}
		}

		// Token: 0x040007DB RID: 2011
		internal readonly string m_Url;

		// Token: 0x040007DC RID: 2012
		internal readonly bool m_Dispatcher;

		// Token: 0x040007DD RID: 2013
		internal readonly string m_DispatchingFieldName;
	}
}
