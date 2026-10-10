using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" /> для создания сообщения, отвечающего на вызов для создания экземпляра удаленного объекта.</summary>
	// Token: 0x02000615 RID: 1557
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.ConstructionResponse" /> из массива заголовков удаленного взаимодействия и сообщения запроса.</summary>
		/// <param name="h">Массив заголовков удаленного взаимодействия, содержащих пары "ключ-значение". Этот массив используется для инициализации полей <see cref="T:System.Runtime.Remoting.Messaging.ConstructionResponse" /> для заголовков, принадлежащих пространству имен "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
		/// <param name="mcm">Сообщение запроса, составляющее вызов конструктора удаленного объекта.</param>
		// Token: 0x06003AD0 RID: 15056 RVA: 0x000CE297 File Offset: 0x000CC497
		public ConstructionResponse(Header[] h, IMethodCallMessage mcm) : base(h, mcm)
		{
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x000CE2A1 File Offset: 0x000CC4A1
		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) : base(resultObject, null, callCtx, msg)
		{
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x000CE2AD File Offset: 0x000CC4AD
		internal ConstructionResponse(Exception e, IMethodCallMessage msg) : base(e, msg)
		{
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x000CE2B7 File Offset: 0x000CC4B7
		internal ConstructionResponse(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x000CE2C1 File Offset: 0x000CC4C1
		public override IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				return base.Properties;
			}
		}
	}
}
