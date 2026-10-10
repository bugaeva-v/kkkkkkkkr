using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Указывает на то, что реализующее свойство будет зарегистрировано во время выполнения с помощью метода <see cref="M:System.Runtime.Remoting.Contexts.Context.RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty,System.ContextBoundObject,System.Runtime.Remoting.Contexts.Context)" />.</summary>
	// Token: 0x02000598 RID: 1432
	[ComVisible(true)]
	public interface IContributeDynamicSink
	{
		/// <summary>Возвращает приемник сообщений, который будет уведомляться о событиях запуска и завершения сообщений через интерфейс <see cref="T:System.Runtime.Remoting.Contexts.IDynamicMessageSink" />.</summary>
		/// <returns>Динамический приемник, предоставляющий доступ к интерфейсу <see cref="T:System.Runtime.Remoting.Contexts.IDynamicMessageSink" />.</returns>
		// Token: 0x060037DA RID: 14298
		IDynamicMessageSink GetDynamicSink();
	}
}
