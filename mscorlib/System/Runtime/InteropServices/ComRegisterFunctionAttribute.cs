using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Задает метод, вызываемый при регистрации сборки для использования из COM. Это позволяет выполнять код, написанный пользователем, в процессе регистрации.</summary>
	// Token: 0x020006EE RID: 1774
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComRegisterFunctionAttribute : Attribute
	{
	}
}
