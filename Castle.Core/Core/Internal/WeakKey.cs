using System;

namespace Castle.Core.Internal
{
	// Token: 0x020000EE RID: 238
	internal sealed class WeakKey : WeakReference
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x00012571 File Offset: 0x00010771
		public WeakKey(object target, int hashCode) : base(target)
		{
			this.hashCode = hashCode;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00012581 File Offset: 0x00010781
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00012589 File Offset: 0x00010789
		public override object Target
		{
			get
			{
				return base.Target;
			}
			set
			{
				throw new NotSupportedException("Dictionary keys are read-only.");
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00012595 File Offset: 0x00010795
		public override int GetHashCode()
		{
			return this.hashCode;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001259D File Offset: 0x0001079D
		public override bool Equals(object other)
		{
			return WeakKeyComparer<object>.Default.Equals(this, other);
		}

		// Token: 0x04000183 RID: 387
		private readonly int hashCode;
	}
}
