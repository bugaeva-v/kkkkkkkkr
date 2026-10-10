using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Указывает, что реализующий приемник сообщений будет предоставлен динамически регистрируемыми свойствами.</summary>
	// Token: 0x0200059C RID: 1436
	[ComVisible(true)]
	public interface IDynamicMessageSink
	{
		/// <summary>Указывает на возврат вызова.</summary>
		/// <param name="replyMsg">Ответное сообщение.</param>
		/// <param name="bCliSide">Имеет значение <see langword="true" />, если метод вызван на клиентской стороне, и <see langword="false" />, если вызван на серверной стороне.</param>
		/// <param name="bAsync">Имеет значение <see langword="true" />, если вызов является асинхронным, и <see langword="false" />, если это синхронный вызов.</param>
		// Token: 0x060037DE RID: 14302
		void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

		/// <summary>Указывает на запуск вызова.</summary>
		/// <param name="reqMsg">Сообщение запроса.</param>
		/// <param name="bCliSide">Имеет значение <see langword="true" />, если метод вызван на клиентской стороне, и <see langword="false" />, если вызван на серверной стороне.</param>
		/// <param name="bAsync">Имеет значение <see langword="true" />, если вызов является асинхронным, и <see langword="false" />, если это синхронный вызов.</param>
		// Token: 0x060037DF RID: 14303
		void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
	}
}
