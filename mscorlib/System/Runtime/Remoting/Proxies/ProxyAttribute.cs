using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Runtime.Remoting.Proxies
{
	/// <summary>Указывает, что для типа объекта требуется настраиваемый прокси.</summary>
	// Token: 0x0200057E RID: 1406
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class)]
	public class ProxyAttribute : Attribute, IContextAttribute
	{
		/// <summary>Создает или неинициализированный <see cref="T:System.MarshalByRefObject" />, или прозрачный прокси, в зависимости от того, может ли существовать в текущем контексте заданный тип.</summary>
		/// <param name="serverType">Тип объекта создаваемого экземпляра.</param>
		/// <returns>Неинициализированный <see cref="T:System.MarshalByRefObject" /> или прозрачный прокси.</returns>
		// Token: 0x06003717 RID: 14103 RVA: 0x000C6D5C File Offset: 0x000C4F5C
		public virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			return (MarshalByRefObject)new RemotingProxy(serverType, ChannelServices.CrossContextUrl, null).GetTransparentProxy();
		}

		/// <summary>Создает экземпляр удаленного прокси для удаленного объекта, описанного заданным <see cref="T:System.Runtime.Remoting.ObjRef" /> и расположенного на сервере.</summary>
		/// <param name="objRef">Ссылка на удаленный объект, для которого создается прокси.</param>
		/// <param name="serverType">Тип сервера, на который помещается удаленный объект.</param>
		/// <param name="serverObject">Серверный объект.</param>
		/// <param name="serverContext">Контекст, в который помещается серверный объект.</param>
		/// <returns>Новый экземпляр удаленного прокси для удаленного объекта, описанного заданным <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		// Token: 0x06003718 RID: 14104 RVA: 0x000C6D74 File Offset: 0x000C4F74
		public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
		{
			return RemotingServices.GetRealProxy(RemotingServices.GetProxyForRemoteObject(objRef, serverType));
		}

		/// <summary>Получает свойства для нового контекста.</summary>
		/// <param name="msg">Сообщение, для которого требуется извлечь контекст.</param>
		// Token: 0x06003719 RID: 14105 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[SecurityCritical]
		[ComVisible(true)]
		public void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
		}

		/// <summary>Проверяет заданный контекст.</summary>
		/// <param name="ctx">Контекст для проверки.</param>
		/// <param name="msg">Сообщение для удаленного вызова.</param>
		/// <returns>Указанный контекст.</returns>
		// Token: 0x0600371A RID: 14106 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(true)]
		[SecurityCritical]
		public bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			return true;
		}
	}
}
