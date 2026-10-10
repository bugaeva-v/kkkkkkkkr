using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет набор контекстов выполнения, в которых объект класса будет доступен для запросов, создающих экземпляры.</summary>
	// Token: 0x0200074D RID: 1869
	[Flags]
	public enum RegistrationClassContext
	{
		/// <summary>Отключает активации AAA (активируется как активатор) только для этой активации.</summary>
		// Token: 0x04002BDF RID: 11231
		DisableActivateAsActivator = 32768,
		/// <summary>Включает активации AAA (активируется как активатор) только для этой активации.</summary>
		// Token: 0x04002BE0 RID: 11232
		EnableActivateAsActivator = 65536,
		/// <summary>Разрешает загрузку кода из службы каталогов или Интернета.</summary>
		// Token: 0x04002BE1 RID: 11233
		EnableCodeDownload = 8192,
		/// <summary>Эту активацию следует начинать с контекста по умолчанию текущего апартмента.</summary>
		// Token: 0x04002BE2 RID: 11234
		FromDefaultContext = 131072,
		/// <summary>Код, управляющий объектами этого класса, является внутрипроцессным обработчиком.</summary>
		// Token: 0x04002BE3 RID: 11235
		InProcessHandler = 2,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BE4 RID: 11236
		InProcessHandler16 = 32,
		/// <summary>Код, создающий объекты этого класса и управляющий ими, представляет собой DLL, выполняемую в том же процессе, что и вызывающий объект функции, задающий контекст класса.</summary>
		// Token: 0x04002BE5 RID: 11237
		InProcessServer = 1,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BE6 RID: 11238
		InProcessServer16 = 8,
		/// <summary>EXE-код, создающий объекты этого класса и управляющий ими, выполняется на том же компьютере, но загружается в отдельное пространство процесса.</summary>
		// Token: 0x04002BE7 RID: 11239
		LocalServer = 4,
		/// <summary>Запрещает загрузку кода из службы каталогов или Интернета.</summary>
		// Token: 0x04002BE8 RID: 11240
		NoCodeDownload = 1024,
		/// <summary>Определяет, заканчивается ли активация неудачей при использовании настраиваемого маршалинга.</summary>
		// Token: 0x04002BE9 RID: 11241
		NoCustomMarshal = 4096,
		/// <summary>Переопределяет ведение журнала отказов.</summary>
		// Token: 0x04002BEA RID: 11242
		NoFailureLog = 16384,
		/// <summary>Контекст удаленного компьютера.</summary>
		// Token: 0x04002BEB RID: 11243
		RemoteServer = 16,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BEC RID: 11244
		Reserved1 = 64,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BED RID: 11245
		Reserved2 = 128,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BEE RID: 11246
		Reserved3 = 256,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BEF RID: 11247
		Reserved4 = 512,
		/// <summary>Не используется.</summary>
		// Token: 0x04002BF0 RID: 11248
		Reserved5 = 2048
	}
}
