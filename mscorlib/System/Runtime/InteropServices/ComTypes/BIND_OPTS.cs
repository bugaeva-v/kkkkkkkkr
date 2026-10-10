using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Сохраняет параметры, используемые при операции привязки моникера.</summary>
	// Token: 0x0200079E RID: 1950
	public struct BIND_OPTS
	{
		/// <summary>Задает размер структуры <see langword="BIND_OPTS" /> в байтах.</summary>
		// Token: 0x04002C43 RID: 11331
		public int cbStruct;

		/// <summary>Управляет элементами операций привязки моникера.</summary>
		// Token: 0x04002C44 RID: 11332
		public int grfFlags;

		/// <summary>Представляет флаги, которые должны использоваться при открытии файла, содержащего объект, определенный моникером.</summary>
		// Token: 0x04002C45 RID: 11333
		public int grfMode;

		/// <summary>Показывает время (значение в миллисекундах, возвращенное функцией <see langword="GetTickCount" />), заданное вызывающим объектом для завершения операции привязки.</summary>
		// Token: 0x04002C46 RID: 11334
		public int dwTickCountDeadline;
	}
}
