using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Указывает статус обработки сообщения сервером.</summary>
	// Token: 0x020005C8 RID: 1480
	[ComVisible(true)]
	[Serializable]
	public enum ServerProcessing
	{
		/// <summary>Сервер обрабатывает сообщение асинхронно.</summary>
		// Token: 0x040025EB RID: 9707
		Complete,
		/// <summary>Сообщение было отослано, и ответ не может быть передан.</summary>
		// Token: 0x040025EC RID: 9708
		OneWay,
		/// <summary>Вызов отослан асинхронно, что указывает, что ответные данные должны содержаться в приемнике стека для дальнейшей обработки.</summary>
		// Token: 0x040025ED RID: 9709
		Async
	}
}
