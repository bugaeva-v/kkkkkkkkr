using System;

namespace Beebyte.Obfuscator
{
	// Token: 0x02000049 RID: 73
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00012933 File Offset: 0x00010B33
		private RenameAttribute()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001293B File Offset: 0x00010B3B
		public RenameAttribute(string target)
		{
			this.target = target;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001294A File Offset: 0x00010B4A
		public string GetTarget()
		{
			return this.target;
		}

		// Token: 0x040001B6 RID: 438
		private readonly string target;
	}
}
