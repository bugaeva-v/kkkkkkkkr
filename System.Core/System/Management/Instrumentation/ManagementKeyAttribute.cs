using System;
using System.Security.Permissions;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementKey определяет ключевые свойства класса WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000383 RID: 899
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementKeyAttribute : ManagementMemberAttribute
	{
	}
}
