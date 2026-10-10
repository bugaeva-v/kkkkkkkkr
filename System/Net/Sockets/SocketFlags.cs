using System;

namespace System.Net.Sockets
{
	/// <summary>Указывает поведение сокета при отправке и получении.</summary>
	// Token: 0x020007B3 RID: 1971
	[Flags]
	public enum SocketFlags
	{
		/// <summary>Не использовать флаги для этого вызова.</summary>
		// Token: 0x04002564 RID: 9572
		None = 0,
		/// <summary>Обработка внешних данных.</summary>
		// Token: 0x04002565 RID: 9573
		OutOfBand = 1,
		/// <summary>Обзор входящего сообщения.</summary>
		// Token: 0x04002566 RID: 9574
		Peek = 2,
		/// <summary>Отправка без использования таблиц маршрутизации.</summary>
		// Token: 0x04002567 RID: 9575
		DontRoute = 4,
		/// <summary>Указывает стандартное значение для числа структур WSABUF, используемых для отправки и получения данных. Это значение не используется и не поддерживается в .NET Framework 4.5.</summary>
		// Token: 0x04002568 RID: 9576
		MaxIOVectorLength = 16,
		/// <summary>Сообщение усечено, так как оно слишком велико для помещения в указанный буфер.</summary>
		// Token: 0x04002569 RID: 9577
		Truncated = 256,
		/// <summary>Указывает на то, что данные элемента управления не поместились во внутренний буфер объемом 64 КБ и были усечены.</summary>
		// Token: 0x0400256A RID: 9578
		ControlDataTruncated = 512,
		/// <summary>Указывает на пакет широковещательной рассылки.</summary>
		// Token: 0x0400256B RID: 9579
		Broadcast = 1024,
		/// <summary>Указывает на пакет многоадресной рассылки.</summary>
		// Token: 0x0400256C RID: 9580
		Multicast = 2048,
		/// <summary>Отправка или передача части сообщения.</summary>
		// Token: 0x0400256D RID: 9581
		Partial = 32768
	}
}
