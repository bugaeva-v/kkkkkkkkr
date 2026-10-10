using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F0 RID: 496
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[RequiredByNativeCode]
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x00023E82 File Offset: 0x00022082
		public RequireComponent(Type requiredComponent)
		{
			this.m_Type0 = requiredComponent;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00023E93 File Offset: 0x00022093
		public RequireComponent(Type requiredComponent, Type requiredComponent2)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00023EAB File Offset: 0x000220AB
		public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3)
		{
			this.m_Type0 = requiredComponent;
			this.m_Type1 = requiredComponent2;
			this.m_Type2 = requiredComponent3;
		}

		// Token: 0x040007D0 RID: 2000
		public Type m_Type0;

		// Token: 0x040007D1 RID: 2001
		public Type m_Type1;

		// Token: 0x040007D2 RID: 2002
		public Type m_Type2;
	}
}
