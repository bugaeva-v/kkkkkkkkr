using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Помечает приемник как приемник форматера клиента, который сериализует сообщения в поток.</summary>
	// Token: 0x020005BB RID: 1467
	[ComVisible(true)]
	public interface IClientFormatterSink : IMessageSink, IClientChannelSink, IChannelSinkBase
	{
	}
}
