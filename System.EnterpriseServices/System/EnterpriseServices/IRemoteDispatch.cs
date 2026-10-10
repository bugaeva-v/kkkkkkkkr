using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Реализуется классом <see cref="T:System.EnterpriseServices.ServicedComponent" />, чтобы определить, установлено ли для атрибута класса <see cref="T:System.EnterpriseServices.AutoCompleteAttribute" /> значение <see langword="true" /> или <see langword="false" /> для удаленного вызова методов.</summary>
	// Token: 0x02000025 RID: 37
	[Guid("6619a740-8154-43be-a186-0319578e02db")]
	public interface IRemoteDispatch
	{
		/// <summary>Гарантирует, что в контексте COM+ для класса <see cref="T:System.EnterpriseServices.ServicedComponent" /> для флага завершения объекта устанавливается значение <see langword="true" /> после вызова удаленного метода.</summary>
		/// <param name="s">Строка, преобразуемая в объект запроса, который реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		/// <returns>Строка, преобразованная из объекта запроса, реализующего интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" />.</returns>
		// Token: 0x06000079 RID: 121
		[AutoComplete]
		string RemoteDispatchAutoDone(string s);

		/// <summary>Не гарантирует, что в контексте COM+ для объекта класса <see cref="T:System.EnterpriseServices.ServicedComponent" /> для бита завершения устанавливается значение <see langword="true" /> после вызова удаленного метода.</summary>
		/// <param name="s">Строка, преобразуемая в объект запроса, который реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		/// <returns>Строка, преобразованная из объекта запроса, реализующего интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" />.</returns>
		// Token: 0x0600007A RID: 122
		[AutoComplete(false)]
		string RemoteDispatchNotAutoDone(string s);
	}
}
