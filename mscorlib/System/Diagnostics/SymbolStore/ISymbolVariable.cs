using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет переменную в хранилище символов.</summary>
	// Token: 0x020009DD RID: 2525
	[ComVisible(true)]
	public interface ISymbolVariable
	{
		/// <summary>Возвращает первый адрес переменной.</summary>
		/// <returns>Первый адрес переменной.</returns>
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06005A6F RID: 23151
		int AddressField1 { get; }

		/// <summary>Возвращает второй адрес переменной.</summary>
		/// <returns>Второй адрес переменной.</returns>
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06005A70 RID: 23152
		int AddressField2 { get; }

		/// <summary>Возвращает третий адрес переменной.</summary>
		/// <returns>Третий адрес переменной.</returns>
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06005A71 RID: 23153
		int AddressField3 { get; }

		/// <summary>Возвращает значение <see cref="T:System.Diagnostics.SymbolStore.SymAddressKind" />, описывающее тип адреса.</summary>
		/// <returns>Тип адреса. Одно из значений перечисления <see cref="T:System.Diagnostics.SymbolStore.SymAddressKind" />.</returns>
		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06005A72 RID: 23154
		SymAddressKind AddressKind { get; }

		/// <summary>Возвращает атрибуты переменной.</summary>
		/// <returns>Атрибуты переменной.</returns>
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06005A73 RID: 23155
		object Attributes { get; }

		/// <summary>Возвращает конечное смещение переменной в области этой переменной.</summary>
		/// <returns>Конечное смещение переменной.</returns>
		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06005A74 RID: 23156
		int EndOffset { get; }

		/// <summary>Возвращает имя переменной.</summary>
		/// <returns>Имя переменной.</returns>
		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06005A75 RID: 23157
		string Name { get; }

		/// <summary>Возвращает начальное смещение переменной в области этой переменной.</summary>
		/// <returns>Начальное смещение переменной.</returns>
		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06005A76 RID: 23158
		int StartOffset { get; }

		/// <summary>Возвращает подпись переменной.</summary>
		/// <returns>Подпись переменной в виде непрозрачного большого двоичного объекта.</returns>
		// Token: 0x06005A77 RID: 23159
		byte[] GetSignature();
	}
}
