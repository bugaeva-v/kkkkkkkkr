using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет функциональные возможности для стека приемников каналов клиента, который должен вызываться при декодировании асинхронного ответа.</summary>
	// Token: 0x020005BA RID: 1466
	[ComVisible(true)]
	public interface IClientChannelSinkStack : IClientResponseChannelSinkStack
	{
		/// <summary>Выводит сведения, связанные со всеми приемниками: от стека приемников до указанного приемника включительно.</summary>
		/// <param name="sink">Приемник, удаляемый и возвращаемый из стека приемников.</param>
		/// <returns>Сведения, созданные на стороне запроса и связанные с указанным приемником.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003887 RID: 14471
		object Pop(IClientChannelSink sink);

		/// <summary>Переносит указанный приемник и сведения, связанные с ним, в стек приемников.</summary>
		/// <param name="sink">Приемник, который необходимо поместить в стек приемников.</param>
		/// <param name="state">Сведения, созданные на стороне запроса и требуемые на стороне ответа.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003888 RID: 14472
		void Push(IClientChannelSink sink, object state);
	}
}
