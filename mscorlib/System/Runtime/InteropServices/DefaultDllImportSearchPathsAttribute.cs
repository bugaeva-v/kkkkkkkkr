using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает пути, используемые для поиска DLL, предоставляющих вызываемые для платформы функции.</summary>
	// Token: 0x02000705 RID: 1797
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute" /> с указанием путей для поиска целевых объектов вызовов неуправляемого кода.</summary>
		/// <param name="paths">Побитовое сочетание значений перечисления, указывающих пути, по которым функция LoadLibraryEx выполняет поиск во время вызовов неуправляемого кода.</param>
		// Token: 0x0600409C RID: 16540 RVA: 0x000E123C File Offset: 0x000DF43C
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			this._paths = paths;
		}

		/// <summary>Возвращает побитовое сочетание значений перечисления, указывающих пути, по которым функция LoadLibraryEx выполняет поиск во время вызовов неуправляемого кода.</summary>
		/// <returns>Битовая комбинация значений перечисления, определяющих пути поиска для вызовов платформы.</returns>
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x000E124B File Offset: 0x000DF44B
		public DllImportSearchPath Paths
		{
			get
			{
				return this._paths;
			}
		}

		// Token: 0x04002AD0 RID: 10960
		internal DllImportSearchPath _paths;
	}
}
