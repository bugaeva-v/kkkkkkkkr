using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит стек приемников каналов сервера.</summary>
	// Token: 0x020005C5 RID: 1477
	[ComVisible(true)]
	public class ServerChannelSinkStack : IServerChannelSinkStack, IServerResponseChannelSinkStack
	{
		/// <summary>Возвращает поток <see cref="T:System.IO.Stream" />, на котором упорядочивается указанное сообщение.</summary>
		/// <param name="msg">Сообщение, упорядочиваемое на запрошенном потоке.</param>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <returns>Поток <see cref="T:System.IO.Stream" />, на котором упорядочивается указанное сообщение.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Стек приемников пуст.</exception>
		// Token: 0x060038A1 RID: 14497 RVA: 0x000CA74D File Offset: 0x000C894D
		[SecurityCritical]
		public Stream GetResponseStream(IMessage msg, ITransportHeaders headers)
		{
			if (this._sinkStack == null)
			{
				throw new RemotingException("The sink stack is empty");
			}
			return ((IServerChannelSink)this._sinkStack.Sink).GetResponseStream(this, this._sinkStack.State, msg, headers);
		}

		/// <summary>Выводит сведения, связанные со всеми приемниками: от стека приемников до указанного приемника включительно.</summary>
		/// <param name="sink">Приемник, удаляемый и возвращаемый из стека приемников.</param>
		/// <returns>Сведения, созданные на стороне запроса и связанные с указанным приемником.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст, или указанный приемник не был передан в текущий приемник.</exception>
		// Token: 0x060038A2 RID: 14498 RVA: 0x000CA788 File Offset: 0x000C8988
		[SecurityCritical]
		public object Pop(IServerChannelSink sink)
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
		// Token: 0x060038A3 RID: 14499 RVA: 0x000CA7D1 File Offset: 0x000C89D1
		[SecurityCritical]
		public void Push(IServerChannelSink sink, object state)
		{
			this._sinkStack = new ChanelSinkStackEntry(sink, state, this._sinkStack);
		}

		/// <summary>Предоставляет делегата <see cref="T:System.AsyncCallback" />, для обработки обратного вызова после того, как сообщение было асинхронно отправлено.</summary>
		/// <param name="ar">Статус и состояние асинхронной операции для удаленного объекта.</param>
		// Token: 0x060038A4 RID: 14500 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		[MonoTODO]
		public void ServerCallback(IAsyncResult ar)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сохраняет приемник сообщений и связанное с ним состояние для последующей асинхронной обработки.</summary>
		/// <param name="sink">Приемник канала сервера.</param>
		/// <param name="state">Состояние, связанное с параметром <paramref name="sink" />.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст.  
		///
		/// или - 
		/// Указанный приемник не проталкивался в текущий стек.</exception>
		// Token: 0x060038A5 RID: 14501 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		[MonoTODO]
		public void Store(IServerChannelSink sink, object state)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сохраняет приемник сообщения и связанное состояние, а затем распределяет сообщение асинхронно с помощью только что сохраненного приемника и других сохраненных приемников.</summary>
		/// <param name="sink">Приемник канала сервера.</param>
		/// <param name="state">Состояние, связанное с параметром <paramref name="sink" />.</param>
		// Token: 0x060038A6 RID: 14502 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		[SecurityCritical]
		public void StoreAndDispatch(IServerChannelSink sink, object state)
		{
			throw new NotImplementedException();
		}

		/// <summary>Запрашивает асинхронную обработку вызова метода на приемники в текущем стеке приемников.</summary>
		/// <param name="msg">Сообщение, упорядочиваемое на запрошенном потоке.</param>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <param name="stream">Поток возвращается из транспортного приемника.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст.</exception>
		// Token: 0x060038A7 RID: 14503 RVA: 0x000CA7E8 File Offset: 0x000C89E8
		[SecurityCritical]
		public void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream)
		{
			if (this._sinkStack == null)
			{
				throw new RemotingException("The current sink stack is empty");
			}
			ChanelSinkStackEntry sinkStack = this._sinkStack;
			this._sinkStack = this._sinkStack.Next;
			((IServerChannelSink)sinkStack.Sink).AsyncProcessResponse(this, sinkStack.State, msg, headers, stream);
		}

		// Token: 0x040025E9 RID: 9705
		private ChanelSinkStackEntry _sinkStack;
	}
}
