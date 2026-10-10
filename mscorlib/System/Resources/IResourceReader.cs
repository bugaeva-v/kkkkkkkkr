using System;
using System.Collections;

namespace System.Resources
{
	/// <summary>Предоставляет основные функциональные возможности для чтения данных из файлов ресурсов.</summary>
	// Token: 0x02000859 RID: 2137
	public interface IResourceReader : IEnumerable, IDisposable
	{
		/// <summary>Закрывает устройство чтения файлов ресурсов после освобождения всех связанных с ним ресурсов.</summary>
		// Token: 0x06004734 RID: 18228
		void Close();

		/// <summary>Возвращает перечислитель словаря ресурсов данного средства чтения.</summary>
		/// <returns>Перечислитель словаря для ресурсов данного устройства чтения.</returns>
		// Token: 0x06004735 RID: 18229
		IDictionaryEnumerator GetEnumerator();
	}
}
