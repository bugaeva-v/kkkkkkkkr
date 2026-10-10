using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000D1 RID: 209
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AssertionConditionAttribute : Attribute
	{
		// Token: 0x06000379 RID: 889 RVA: 0x00005EAB File Offset: 0x000040AB
		public AssertionConditionAttribute(AssertionConditionType conditionType)
		{
			this.ConditionType = conditionType;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00005EBC File Offset: 0x000040BC
		public AssertionConditionType ConditionType { get; }
	}
}
