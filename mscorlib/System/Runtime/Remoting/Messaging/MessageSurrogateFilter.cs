using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Определяет, должен ли класс <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> игнорировать конкретное свойство <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> при создании <see cref="T:System.Runtime.Remoting.ObjRef" /> для класса <see cref="T:System.MarshalByRefObject" />.</summary>
	/// <param name="key">Ключ к конкретному свойству сообщения удаленного взаимодействия.</param>
	/// <param name="value">Значение конкретного свойства сообщения удаленного взаимодействия.</param>
	/// <returns>Значение true, если класс <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> должен игнорировать конкретное свойство <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> при создании <see cref="T:System.Runtime.Remoting.ObjRef" /> для класса <see cref="T:System.MarshalByRefObject" />.</returns>
	// Token: 0x02000624 RID: 1572
	// (Invoke) Token: 0x06003B17 RID: 15127
	[ComVisible(true)]
	public delegate bool MessageSurrogateFilter(string key, object value);
}
