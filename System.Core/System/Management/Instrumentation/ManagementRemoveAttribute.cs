using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementRemoveAttribute указывает на то, что метод очищает экземпляр управляемого объекта.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000387 RID: 903
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementRemoveAttribute : ManagementMemberAttribute
	{
		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает объект, помеченный атрибутом ManagementRemove.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" /> будет выводить значение, указывающее тип вывода, который возвращает объект, помеченный атрибутом Remove.
		///       </returns>
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00003A59 File Offset: 0x00001C59
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
