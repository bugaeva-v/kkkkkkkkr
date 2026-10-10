using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Позволяет получить полный путь исходного файла, содержащего вызывающий объект. Это путь к файлу во время компиляции.</summary>
	// Token: 0x020007DF RID: 2015
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class CallerFilePathAttribute : Attribute
	{
	}
}
