using System;

namespace System
{
	/// <summary>Указывает, что метод может быть вызван с переменным числом аргументов. Этот класс не наследуется.</summary>
	// Token: 0x0200016C RID: 364
	[AttributeUsage(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
	public sealed class ParamArrayAttribute : Attribute
	{
	}
}
