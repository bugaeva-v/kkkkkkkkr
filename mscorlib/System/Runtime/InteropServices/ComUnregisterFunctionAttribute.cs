using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет метод, вызываемый при удалении регистрации сборки, используемой из COM. Это позволяет в процессе удаления регистрации выполнять код, написанный пользователем.</summary>
	// Token: 0x020006EF RID: 1775
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComUnregisterFunctionAttribute : Attribute
	{
	}
}
