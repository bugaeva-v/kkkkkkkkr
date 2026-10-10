using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>При применении к параметру-массиву в компоненте среды выполнения Windows указывает, что содержимое массива, передаваемого в этом параметре, используется только в качестве входных данных. Вызывающий объект ожидает, что массив не изменится вызовом.</summary>
	// Token: 0x02000785 RID: 1925
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
	public sealed class ReadOnlyArrayAttribute : Attribute
	{
	}
}
