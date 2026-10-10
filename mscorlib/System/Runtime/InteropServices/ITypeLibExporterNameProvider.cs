using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет управление регистром имен при экспортировании в библиотеку типов.</summary>
	// Token: 0x02000742 RID: 1858
	[Guid("fa1f3615-acb9-486d-9eac-1bef87e36b09")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ITypeLibExporterNameProvider
	{
		/// <summary>Возвращает список имен для управления регистром.</summary>
		/// <returns>Массив строк, каждый элемент которого содержит имя типа, для которого требуется управление регистром.</returns>
		// Token: 0x06004142 RID: 16706
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)]
		string[] GetNames();
	}
}
