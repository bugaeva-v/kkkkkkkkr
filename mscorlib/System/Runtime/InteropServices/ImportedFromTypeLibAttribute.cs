using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает, что определенные в сборке типы были исходно определены в библиотеке типов.</summary>
	// Token: 0x020006F1 RID: 1777
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class ImportedFromTypeLibAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ImportedFromTypeLibAttribute" /> с именем файла исходной библиотеки типов.</summary>
		/// <param name="tlbFile">Местоположение файла исходной библиотеки типов.</param>
		// Token: 0x06004076 RID: 16502 RVA: 0x000E1014 File Offset: 0x000DF214
		public ImportedFromTypeLibAttribute(string tlbFile)
		{
			this._val = tlbFile;
		}

		/// <summary>Возвращает местоположение файла исходной библиотеки типов.</summary>
		/// <returns>Имя файла исходной библиотеки типов.</returns>
		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x000E1023 File Offset: 0x000DF223
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A3E RID: 10814
		internal string _val;
	}
}
