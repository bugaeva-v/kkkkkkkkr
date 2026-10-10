using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Предоставляет приемник перехвата на границе контекста на клиентской стороне вызова удаленного взаимодействия.</summary>
	// Token: 0x02000597 RID: 1431
	[ComVisible(true)]
	public interface IContributeClientContextSink
	{
		/// <summary>Берет первый приемник в сформированной цепочке приемников и помещает его приемник сообщения в качестве первого звена уже сформированной цепочки.</summary>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников.</returns>
		// Token: 0x060037D9 RID: 14297
		IMessageSink GetClientContextSink(IMessageSink nextSink);
	}
}
