using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>При применении к параметру массива в компоненте среды выполнения Windows указывает, что содержимое массива, передаваемое этому параметру, используется только для вывода. Вызывающая сторона не гарантирует, что содержимое инициализируется, и вызванный метод не должен считывать содержимое.</summary>
	// Token: 0x02000786 RID: 1926
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
	public sealed class WriteOnlyArrayAttribute : Attribute
	{
	}
}
