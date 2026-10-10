using System;

namespace System.IO.Pipes
{
	/// <summary>
	///         Задает режим передачи канала.
	///       </summary>
	// Token: 0x02000351 RID: 849
	public enum PipeTransmissionMode
	{
		/// <summary>
		///         Указывает, что данные в канале передаются и считываются как поток байтов.
		///       </summary>
		// Token: 0x04000C68 RID: 3176
		Byte,
		/// <summary>
		///         Указывает, что данные в канале передаются и считываются как поток сообщений.
		///       </summary>
		// Token: 0x04000C69 RID: 3177
		Message
	}
}
