using System;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	// Token: 0x02000035 RID: 53
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class VisibilityAttribute : PropertyAttribute
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002A3C File Offset: 0x00000C3C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002A44 File Offset: 0x00000C44
		public string PropertyName { get; private set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002A4D File Offset: 0x00000C4D
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002A55 File Offset: 0x00000C55
		public object Value { get; private set; }

		// Token: 0x060000D7 RID: 215 RVA: 0x00002A5E File Offset: 0x00000C5E
		public VisibilityAttribute(string propertyName, object value)
		{
			this.PropertyName = propertyName;
			this.Value = value;
		}
	}
}
