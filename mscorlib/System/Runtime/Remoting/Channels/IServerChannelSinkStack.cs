using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает функционирование стека для стека приемников каналов сервера.</summary>
	// Token: 0x020005C1 RID: 1473
	[ComVisible(true)]
	public interface IServerChannelSinkStack : IServerResponseChannelSinkStack
	{
		/// <summary>Выводит сведения, связанные со всеми приемниками: от стека приемников до указанного приемника включительно.</summary>
		/// <param name="sink">Приемник, удаляемый и возвращаемый из стека приемников.</param>
		/// <returns>Сведения, созданные на стороне запроса и связанные с указанным приемником.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003896 RID: 14486
		object Pop(IServerChannelSink sink);

		/// <summary>Переносит указанный приемник и сведения, связанные с ним, в стек приемников.</summary>
		/// <param name="sink">Приемник, который необходимо поместить в стек приемников.</param>
		/// <param name="state">Сведения, созданные на стороне запроса и требуемые на стороне ответа.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003897 RID: 14487
		void Push(IServerChannelSink sink, object state);

		/// <summary>Предоставляет обратный вызов делегата для обработки обратного вызова после того, как сообщение было асинхронно отправлено.</summary>
		/// <param name="ar">Статус и состояние асинхронной операции для удаленного объекта.</param>
		// Token: 0x06003898 RID: 14488
		void ServerCallback(IAsyncResult ar);

		/// <summary>Сохраняет приемник сообщений и связанное с ним состояние для последующей асинхронной обработки.</summary>
		/// <param name="sink">Приемник канала сервера.</param>
		/// <param name="state">Состояние, связанное с параметром <paramref name="sink" />.</param>
		// Token: 0x06003899 RID: 14489
		void Store(IServerChannelSink sink, object state);

		/// <summary>Сохраняет приемник сообщения и связанное состояние, а затем распределяет сообщение асинхронно с помощью только что сохраненного приемника и других сохраненных приемников.</summary>
		/// <param name="sink">Приемник канала сервера.</param>
		/// <param name="state">Состояние, связанное с параметром <paramref name="sink" />.</param>
		// Token: 0x0600389A RID: 14490
		void StoreAndDispatch(IServerChannelSink sink, object state);
	}
}
