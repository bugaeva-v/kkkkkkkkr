using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Предоставляет приемник перехвата для объекта на границе контекста на серверной стороне вызова удаленного взаимодействия.</summary>
	// Token: 0x0200059A RID: 1434
	[ComVisible(true)]
	public interface IContributeObjectSink
	{
		/// <summary>Добавляет приемник сообщения предоставленного объекта сервера в качестве первого звена заданной цепочки приемников.</summary>
		/// <param name="obj">Серверный объект, предоставляющий приемник сообщений, который должен быть помещен в качестве первого звена заданной цепочки приемников.</param>
		/// <param name="nextSink">Сформированная на данный момент цепочка приемников.</param>
		/// <returns>Составная цепочка приемников.</returns>
		// Token: 0x060037DC RID: 14300
		IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
	}
}
