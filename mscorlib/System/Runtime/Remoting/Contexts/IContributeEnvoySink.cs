using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Предоставляет представительский приемник сообщения на клиентской стороне.</summary>
	// Token: 0x02000599 RID: 1433
	[ComVisible(true)]
	public interface IContributeEnvoySink
	{
		/// <summary>Берет первый приемник в сформированной цепочке приемников и помещает его приемник сообщения в качестве первого звена уже сформированной цепочки.</summary>
		/// <param name="obj">Серверный объект, для которого создается цепочка.</param>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников.</returns>
		// Token: 0x060037DB RID: 14299
		IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
	}
}
