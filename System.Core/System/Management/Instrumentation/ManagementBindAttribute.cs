using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementBind указывает, что метод используется для возврата экземпляра класса WMI, связанного с определенным значением ключа.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000379 RID: 889
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementBindAttribute : ManagementNewInstanceAttribute
	{
		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает метод, помеченный атрибутом ManagementEnumerator.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Type" /> значение, указывающее тип вывода, метод помечен атрибутом <see cref="ManagementBind" /> будет выводить атрибут.
		///       </returns>
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x00003A59 File Offset: 0x00001C59
		public Type Schema
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
			}
		}
	}
}
