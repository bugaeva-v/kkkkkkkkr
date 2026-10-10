using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает, что информация о классе или интерфейсе была потеряна при импортировании из библиотеки типов в сборку.</summary>
	// Token: 0x020006F5 RID: 1781
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComConversionLossAttribute : Attribute
	{
	}
}
