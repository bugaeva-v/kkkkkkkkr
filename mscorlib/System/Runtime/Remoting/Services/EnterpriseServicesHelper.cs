using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace System.Runtime.Remoting.Services
{
	/// <summary>Предоставляет API, необходимые для связи и работы с неуправляемыми классами вне <see cref="T:System.AppDomain" />. Этот класс не наследуется.</summary>
	// Token: 0x0200057B RID: 1403
	[ComVisible(true)]
	public sealed class EnterpriseServicesHelper
	{
		/// <summary>Создает <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> из заданного <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="ctorMsg">Вызов конструирования в объект, из которого возвращается новый экземпляр <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</param>
		/// <param name="retObj">
		///   <see cref="T:System.Runtime.Remoting.ObjRef" />, представляющая объект, созданный с помощью вызова конструирования в <paramref name="ctorMsg" />.</param>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />, возвращенное из вызова конструирования, заданного в параметре <paramref name="ctorMsg" />.</returns>
		// Token: 0x06003708 RID: 14088 RVA: 0x000C6A6D File Offset: 0x000C4C6D
		[ComVisible(true)]
		public static IConstructionReturnMessage CreateConstructionReturnMessage(IConstructionCallMessage ctorMsg, MarshalByRefObject retObj)
		{
			return new ConstructionResponse(retObj, null, ctorMsg);
		}

		/// <summary>Переключает COM Callable Wrapper (CCW) между двумя экземплярами одного класса.</summary>
		/// <param name="oldcp">Прокси, который представляет старый экземпляр класса, на который ссылается COM.</param>
		/// <param name="newcp">Прокси, который представляет новый экземпляр класса, на который ссылается COM.</param>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x06003709 RID: 14089 RVA: 0x000472C8 File Offset: 0x000454C8
		[MonoTODO]
		public static void SwitchWrappers(RealProxy oldcp, RealProxy newcp)
		{
			throw new NotSupportedException();
		}

		/// <summary>Заключает заданный COM-интерфейс <see langword="IUnknown" /> в Runtime Callable Wrapper (RCW).</summary>
		/// <param name="punk">Указатель на заключаемый в оболочку COM-интерфейс <see langword="IUnknown" />.</param>
		/// <returns>RCW, в которую заключается заданный <see langword="IUnknown" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий объект не имеет разрешение UnmanagedCode.</exception>
		// Token: 0x0600370A RID: 14090 RVA: 0x000472C8 File Offset: 0x000454C8
		[MonoTODO]
		public static object WrapIUnknownWithComObject(IntPtr punk)
		{
			throw new NotSupportedException();
		}
	}
}
