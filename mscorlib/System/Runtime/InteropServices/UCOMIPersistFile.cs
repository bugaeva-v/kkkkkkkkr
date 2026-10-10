using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IPersistFile" />.</summary>
	// Token: 0x0200075D RID: 1885
	[Obsolete]
	[Guid("0000010b-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIPersistFile
	{
		/// <summary>Возвращает идентификатор класса CLSID для объекта.</summary>
		/// <param name="pClassID">При успешном возвращении — ссылка на идентификатор CLSID.</param>
		// Token: 0x0600427E RID: 17022
		void GetClassID(out Guid pClassID);

		/// <summary>Проверяет наличие изменений в объекте с момента его последнего сохранения в текущем файле.</summary>
		/// <returns>Значение <see langword="S_OK" />, если файл был изменен с момента последнего сохранения; значение <see langword="S_FALSE" /> — если файл не был изменен.</returns>
		// Token: 0x0600427F RID: 17023
		[PreserveSig]
		int IsDirty();

		/// <summary>Открывает указанный файл и инициализирует объект из содержимого файла.</summary>
		/// <param name="pszFileName">Строка, оканчивающаяся нулем и содержащая абсолютный путь к файлу, который требуется открыть.</param>
		/// <param name="dwMode">Набор значений из перечисления <see langword="STGM" />, показывающих режим доступа, используемый для открытия <paramref name="pszFileName" />.</param>
		// Token: 0x06004280 RID: 17024
		void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, int dwMode);

		/// <summary>Сохраняет копию объекта в заданном файле.</summary>
		/// <param name="pszFileName">Строка, оканчивающаяся нулем и содержащая абсолютный путь к файлу, в котором требуется сохранить объект.</param>
		/// <param name="fRemember">Показывает, будет ли <paramref name="pszFileName" /> использоваться в качестве текущего рабочего файла.</param>
		// Token: 0x06004281 RID: 17025
		void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);

		/// <summary>Сообщает объекту, что он может выполнять запись в файл.</summary>
		/// <param name="pszFileName">Абсолютный путь к файлу, в котором ранее был сохранен объект.</param>
		// Token: 0x06004282 RID: 17026
		void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);

		/// <summary>Возвращает абсолютный путь к текущему выполняемому файлу объекта или, если выполняемый файл отсутствует, выдаваемый по умолчанию запрос имени файла объекта.</summary>
		/// <param name="ppszFileName">Адрес указателя на строку, заканчивающуюся нулем и содержащую путь для текущего файла, или выдаваемый по умолчанию запрос имени файла (например *.txt).</param>
		// Token: 0x06004283 RID: 17027
		void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
	}
}
