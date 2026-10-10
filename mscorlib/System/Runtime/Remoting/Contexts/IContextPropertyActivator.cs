using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Указывает, что реализующее свойство заинтересовано в участии в активации и могло не предоставить приемник сообщений.</summary>
	// Token: 0x02000596 RID: 1430
	[ComVisible(true)]
	public interface IContextPropertyActivator
	{
		/// <summary>Вызывается в каждом клиентском контекстном свойстве, имеющем данный интерфейс, перед тем, как запрос на конструирование покидает клиента.</summary>
		/// <param name="msg">Объект <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</param>
		// Token: 0x060037D4 RID: 14292
		void CollectFromClientContext(IConstructionCallMessage msg);

		/// <summary>Вызывается в каждом серверном контекстном свойстве, имеющим данный интерфейс, перед тем, как ответ конструирования отправляется от сервера клиенту.</summary>
		/// <param name="msg">Объект <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />.</param>
		// Token: 0x060037D5 RID: 14293
		void CollectFromServerContext(IConstructionReturnMessage msg);

		/// <summary>Вызывается в каждом клиентском контекстном свойстве, имеющем данный интерфейс, когда запрос на конструирование возвращается клиенту от сервера.</summary>
		/// <param name="msg">Объект <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</param>
		/// <returns>Значение <see langword="true" /> в случае успешного выполнения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060037D6 RID: 14294
		bool DeliverClientContextToServerContext(IConstructionCallMessage msg);

		/// <summary>Вызывается в каждом клиентском контекстном свойстве, имеющем данный интерфейс, когда запрос на конструирование возвращается клиенту от сервера.</summary>
		/// <param name="msg">Объект <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />.</param>
		/// <returns>Значение <see langword="true" /> в случае успешного выполнения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060037D7 RID: 14295
		bool DeliverServerContextToClientContext(IConstructionReturnMessage msg);

		/// <summary>Указывает, разрешается ли активировать тип объекта, заданный параметром <paramref name="msg" />.</summary>
		/// <param name="msg">Объект <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</param>
		/// <returns>Логическое значение, указывающее возможность активации запрашиваемого типа.</returns>
		// Token: 0x060037D8 RID: 14296
		bool IsOKToActivate(IConstructionCallMessage msg);
	}
}
