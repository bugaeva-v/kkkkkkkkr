using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Указывает определяемый пользователем тег, который помещается в поля типов, определяемых пользователем, которые передаются в качестве полезных данных <see cref="T:System.Diagnostics.Tracing.EventSource" /> посредством атрибута <see cref="T:System.Diagnostics.Tracing.EventFieldAttribute" />.</summary>
	// Token: 0x020009F3 RID: 2547
	[Flags]
	public enum EventFieldTags
	{
		/// <summary>Не указывает тег и равняется нулю.</summary>
		// Token: 0x04003826 RID: 14374
		None = 0
	}
}
