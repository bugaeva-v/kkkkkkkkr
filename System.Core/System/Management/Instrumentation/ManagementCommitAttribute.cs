using System;
using System.Security.Permissions;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementCommit указывает метод, который вызывается, если необходимо обновить набор свойств чтения и записи в рамках одной атомарной операции.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x0200037C RID: 892
	[AttributeUsage(AttributeTargets.Method)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementCommitAttribute : ManagementMemberAttribute
	{
	}
}
