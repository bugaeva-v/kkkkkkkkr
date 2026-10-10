using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.BIND_OPTS" />.</summary>
	// Token: 0x02000739 RID: 1849
	[Obsolete]
	public struct BIND_OPTS
	{
		/// <summary>Задает размер структуры <see langword="BIND_OPTS" /> в байтах.</summary>
		// Token: 0x04002BAF RID: 11183
		public int cbStruct;

		/// <summary>Управляет элементами операций привязки моникера.</summary>
		// Token: 0x04002BB0 RID: 11184
		public int grfFlags;

		/// <summary>Флаги, которые должны использоваться при открытии файла, содержащего объект, определенный моникером.</summary>
		// Token: 0x04002BB1 RID: 11185
		public int grfMode;

		/// <summary>Показывает время (значение в миллисекундах, возвращенное функцией <see langword="GetTickCount" />), заданное вызывающим объектом для завершения операции привязки.</summary>
		// Token: 0x04002BB2 RID: 11186
		public int dwTickCountDeadline;
	}
}
