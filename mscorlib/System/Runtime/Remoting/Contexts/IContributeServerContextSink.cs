using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Предоставляет приемник перехвата на границе контекста на серверной стороне вызова удаленного взаимодействия.</summary>
	// Token: 0x0200059B RID: 1435
	[ComVisible(true)]
	public interface IContributeServerContextSink
	{
		/// <summary>Берет первый приемник в сформированной цепочке приемников и помещает его приемник сообщения в качестве первого звена уже сформированной цепочки.</summary>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников.</returns>
		// Token: 0x060037DD RID: 14301
		IMessageSink GetServerContextSink(IMessageSink nextSink);
	}
}
