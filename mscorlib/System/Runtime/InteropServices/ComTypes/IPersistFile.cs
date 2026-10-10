using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IPersistFile" /> с функциональными возможностями из <see langword="IPersist" />.</summary>
	// Token: 0x020007AB RID: 1963
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010b-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IPersistFile
	{
		/// <summary>Возвращает идентификатор класса CLSID для объекта.</summary>
		/// <param name="pClassID">При возвращении данного метода содержит ссылку на идентификатор CLSID. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004535 RID: 17717
		void GetClassID(out Guid pClassID);

		/// <summary>Проверяет наличие изменений в объекте с момента его последнего сохранения в текущем файле.</summary>
		/// <returns>Значение <see langword="S_OK" />, если файл был изменен с момента последнего сохранения; значение <see langword="S_FALSE" /> — если файл не был изменен.</returns>
		// Token: 0x06004536 RID: 17718
		[PreserveSig]
		int IsDirty();

		/// <summary>Открывает указанный файл и инициализирует объект из содержимого файла.</summary>
		/// <param name="pszFileName">Строка, оканчивающаяся нулем и содержащая абсолютный путь к файлу, который требуется открыть.</param>
		/// <param name="dwMode">Набор значений из перечисления <see langword="STGM" />, показывающих режим доступа, используемый для открытия <paramref name="pszFileName" />.</param>
		// Token: 0x06004537 RID: 17719
		void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, int dwMode);

		/// <summary>Сохраняет копию объекта в заданном файле.</summary>
		/// <param name="pszFileName">Строка, оканчивающаяся нулем и содержащая абсолютный путь к файлу, в котором требуется сохранить объект.</param>
		/// <param name="fRemember">Значение <see langword="true" />, чтобы использовать параметр <paramref name="pszFileName" /> в качестве выполняемого файла; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06004538 RID: 17720
		void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);

		/// <summary>Сообщает объекту, что он может выполнять запись в файл.</summary>
		/// <param name="pszFileName">Абсолютный путь к файлу, в котором ранее был сохранен объект.</param>
		// Token: 0x06004539 RID: 17721
		void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

		/// <summary>Извлекает либо абсолютный путь к текущему выполняемому файлу объекта, либо, если выполняемый файл отсутствует, выдаваемый по умолчанию запрос имени файла объекта.</summary>
		/// <param name="ppszFileName">При возвращении данного метода содержит адрес указателя на оканчивающуюся нулем строку, содержащую путь для текущего файла или используемый по умолчанию запрос имени файла (например, *.txt). Этот параметр передается неинициализированным.</param>
		// Token: 0x0600453A RID: 17722
		void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
	}
}
