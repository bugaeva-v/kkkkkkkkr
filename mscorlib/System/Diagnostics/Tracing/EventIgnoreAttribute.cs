using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Указывает, что при записи типа события с помощью метода <see cref="M:System.Diagnostics.Tracing.EventSource.Write``1(System.String,System.Diagnostics.Tracing.EventSourceOptions@,``0@)" /> свойство должно игнорироваться.</summary>
	// Token: 0x020009F4 RID: 2548
	[AttributeUsage(AttributeTargets.Property)]
	public class EventIgnoreAttribute : Attribute
	{
	}
}
