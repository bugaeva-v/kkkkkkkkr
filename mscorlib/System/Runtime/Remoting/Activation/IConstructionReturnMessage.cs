using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Определяет сообщение <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" />, возвращаемое после попытки активировать удаленный объект.</summary>
	// Token: 0x020005D2 RID: 1490
	[ComVisible(true)]
	public interface IConstructionReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage
	{
	}
}
