using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Содержит стек приемников каналов клиента, который должен вызываться при декодировании асинхронного ответа.</summary>
	// Token: 0x020005AB RID: 1451
	[ComVisible(true)]
	public class ClientChannelSinkStack : IClientChannelSinkStack, IClientResponseChannelSinkStack
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.ClientChannelSinkStack" /> со значениями по умолчанию.</summary>
		// Token: 0x06003849 RID: 14409 RVA: 0x0000259F File Offset: 0x0000079F
		public ClientChannelSinkStack()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.ClientChannelSinkStack" /> с указанным приемником ответа.</summary>
		/// <param name="replySink">Приемник <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" />, который может использоваться текущим стеком для ответа на сообщения.</param>
		// Token: 0x0600384A RID: 14410 RVA: 0x000CA1CC File Offset: 0x000C83CC
		public ClientChannelSinkStack(IMessageSink replySink)
		{
			this._replySink = replySink;
		}

		/// <summary>Запрашивает асинхронную обработку вызова метода на приемники в текущем стеке приемников.</summary>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <param name="stream">Поток, возвращающийся из транспортного приемника.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст.</exception>
		// Token: 0x0600384B RID: 14411 RVA: 0x000CA1DC File Offset: 0x000C83DC
		[SecurityCritical]
		public void AsyncProcessResponse(ITransportHeaders headers, Stream stream)
		{
			if (this._sinkStack == null)
			{
				throw new RemotingException("The current sink stack is empty");
			}
			ChanelSinkStackEntry sinkStack = this._sinkStack;
			this._sinkStack = this._sinkStack.Next;
			((IClientChannelSink)sinkStack.Sink).AsyncProcessResponse(this, sinkStack.State, headers, stream);
		}

		/// <summary>Отправляет указанное исключение в приемник ответов.</summary>
		/// <param name="e">Исключение, отправляемое на сервер.</param>
		// Token: 0x0600384C RID: 14412 RVA: 0x000CA22D File Offset: 0x000C842D
		[SecurityCritical]
		public void DispatchException(Exception e)
		{
			this.DispatchReplyMessage(new ReturnMessage(e, null));
		}

		/// <summary>Отправляет указанный ответ в приемник ответов.</summary>
		/// <param name="msg">Отправляемое сообщение <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		// Token: 0x0600384D RID: 14413 RVA: 0x000CA23C File Offset: 0x000C843C
		[SecurityCritical]
		public void DispatchReplyMessage(IMessage msg)
		{
			if (this._replySink != null)
			{
				this._replySink.SyncProcessMessage(msg);
			}
		}

		/// <summary>Выводит сведения, связанные со всеми приемниками: от стека приемников до указанного приемника включительно.</summary>
		/// <param name="sink">Приемник, удаляемый и возвращаемый из стека приемников.</param>
		/// <returns>Сведения, созданные на стороне запроса и связанные с указанным приемником.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст, или указанный приемник не был передан в текущий приемник.</exception>
		// Token: 0x0600384E RID: 14414 RVA: 0x000CA254 File Offset: 0x000C8454
		[SecurityCritical]
		public object Pop(IClientChannelSink sink)
		{
			while (this._sinkStack != null)
			{
				ChanelSinkStackEntry sinkStack = this._sinkStack;
				this._sinkStack = this._sinkStack.Next;
				if (sinkStack.Sink == sink)
				{
					return sinkStack.State;
				}
			}
			throw new RemotingException("The current sink stack is empty, or the specified sink was never pushed onto the current stack");
		}

		/// <summary>Переносит указанный приемник и сведения, связанные с ним, в стек приемников.</summary>
		/// <param name="sink">Приемник, который необходимо поместить в стек приемников.</param>
		/// <param name="state">Сведения, созданные на стороне запроса и требуемые на стороне ответа.</param>
		// Token: 0x0600384F RID: 14415 RVA: 0x000CA29D File Offset: 0x000C849D
		[SecurityCritical]
		public void Push(IClientChannelSink sink, object state)
		{
			this._sinkStack = new ChanelSinkStackEntry(sink, state, this._sinkStack);
		}

		// Token: 0x040025DB RID: 9691
		private IMessageSink _replySink;

		// Token: 0x040025DC RID: 9692
		private ChanelSinkStackEntry _sinkStack;
	}
}
