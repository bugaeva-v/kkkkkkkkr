using System;

namespace System.Configuration.Internal
{
	/// <summary>Определяет интерфейс, используемый платформой .NET Framework, для поддержки записей конфигурации, создающих ошибки.</summary>
	// Token: 0x0200007B RID: 123
	public interface IConfigErrorInfo
	{
		/// <summary>Возвращает строку, определяющую имя файла, связанного со сведениями о конфигурации.</summary>
		/// <returns>Строка, определяющая имя файла.</returns>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000427 RID: 1063
		string Filename { get; }

		/// <summary>Возвращает целочисленное значение, определяющее количество строк, связанных со сведениями о конфигурации.</summary>
		/// <returns>Целочисленное значение, определяющее количество строк.</returns>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000428 RID: 1064
		int LineNumber { get; }
	}
}
