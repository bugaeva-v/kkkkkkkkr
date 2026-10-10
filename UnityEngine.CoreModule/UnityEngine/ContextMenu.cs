using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001F3 RID: 499
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ContextMenu : Attribute
	{
		// Token: 0x0600166A RID: 5738 RVA: 0x00023F5F File Offset: 0x0002215F
		public ContextMenu(string itemName) : this(itemName, false)
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00023F6B File Offset: 0x0002216B
		public ContextMenu(string itemName, bool isValidateFunction) : this(itemName, isValidateFunction, 1000000)
		{
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00023F7C File Offset: 0x0002217C
		public ContextMenu(string itemName, bool isValidateFunction, int priority)
		{
			this.menuItem = itemName;
			this.validate = isValidateFunction;
			this.priority = priority;
		}

		// Token: 0x040007D8 RID: 2008
		public readonly string menuItem;

		// Token: 0x040007D9 RID: 2009
		public readonly bool validate;

		// Token: 0x040007DA RID: 2010
		public readonly int priority;
	}
}
