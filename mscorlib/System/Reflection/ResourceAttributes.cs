using System;

namespace System.Reflection
{
	/// <summary>Задает атрибуты для ресурса манифеста.</summary>
	// Token: 0x020008BF RID: 2239
	[Flags]
	public enum ResourceAttributes
	{
		/// <summary>Маска, используемая для извлечения открытых ресурсов манифеста.</summary>
		// Token: 0x04002F29 RID: 12073
		Public = 1,
		/// <summary>Маска, используемая для извлечения закрытых ресурсов манифеста.</summary>
		// Token: 0x04002F2A RID: 12074
		Private = 2
	}
}
