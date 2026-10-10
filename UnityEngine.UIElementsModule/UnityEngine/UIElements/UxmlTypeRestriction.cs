using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002F0 RID: 752
	public abstract class UxmlTypeRestriction : IEquatable<UxmlTypeRestriction>
	{
		// Token: 0x060018EF RID: 6383 RVA: 0x00065D2C File Offset: 0x00063F2C
		public virtual bool Equals(UxmlTypeRestriction other)
		{
			return this == other;
		}
	}
}
