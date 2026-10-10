using System;
using System.Collections;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000107 RID: 263
	public class RemoveIfEmptyAttribute : RemoveIfAttribute
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x00013797 File Offset: 0x00011997
		public RemoveIfEmptyAttribute() : base(RemoveIfEmptyAttribute.RemoveIfEmptyCondition.Instance)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x000137A4 File Offset: 0x000119A4
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x000137AC File Offset: 0x000119AC
		private new Type Condition { get; set; }

		// Token: 0x020001FA RID: 506
		private class RemoveIfEmptyCondition : ICondition
		{
			// Token: 0x06000E89 RID: 3721 RVA: 0x00022870 File Offset: 0x00020A70
			public bool SatisfiedBy(object value)
			{
				return value == null || RemoveIfEmptyAttribute.RemoveIfEmptyCondition.IsEmptyString(value) || RemoveIfEmptyAttribute.RemoveIfEmptyCondition.IsEmptyGuid(value) || RemoveIfEmptyAttribute.RemoveIfEmptyCondition.IsEmptyCollection(value);
			}

			// Token: 0x06000E8A RID: 3722 RVA: 0x0002288D File Offset: 0x00020A8D
			private static bool IsEmptyString(object value)
			{
				return value is string && ((string)value).Length == 0;
			}

			// Token: 0x06000E8B RID: 3723 RVA: 0x000228A7 File Offset: 0x00020AA7
			private static bool IsEmptyGuid(object value)
			{
				return value is Guid && (Guid)value == Guid.Empty;
			}

			// Token: 0x06000E8C RID: 3724 RVA: 0x000228C3 File Offset: 0x00020AC3
			private static bool IsEmptyCollection(object value)
			{
				return value is IEnumerable && !((IEnumerable)value).GetEnumerator().MoveNext();
			}

			// Token: 0x040003BC RID: 956
			public static readonly RemoveIfEmptyAttribute.RemoveIfEmptyCondition Instance = new RemoveIfEmptyAttribute.RemoveIfEmptyCondition();
		}
	}
}
