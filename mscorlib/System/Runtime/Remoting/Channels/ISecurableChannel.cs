using System;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Канал <see cref="T:System.Runtime.Remoting.Channels.ISecurableChannel" /> содержит одно свойство, <see cref="P:System.Runtime.Remoting.Channels.ISecurableChannel.IsSecured" />, которое возвращает или задает логическое значение, позволяющее определить, является ли текущий канал безопасным.</summary>
	// Token: 0x020005BE RID: 1470
	public interface ISecurableChannel
	{
		/// <summary>Возвращает или задает логическое значение, позволяющее определить, является ли текущий канал безопасным.</summary>
		/// <returns>Логическое значение, позволяющее определить, является ли текущий канал безопасным.</returns>
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600388C RID: 14476
		// (set) Token: 0x0600388D RID: 14477
		bool IsSecured { get; set; }
	}
}
