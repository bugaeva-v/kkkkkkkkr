using System;
using UnityEngine.Scripting;

namespace UnityEngine.Serialization
{
	// Token: 0x020002CF RID: 719
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x000308D0 File Offset: 0x0002EAD0
		public FormerlySerializedAsAttribute(string oldName)
		{
			this.m_oldName = oldName;
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x000308E4 File Offset: 0x0002EAE4
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x040009B6 RID: 2486
		private string m_oldName;
	}
}
