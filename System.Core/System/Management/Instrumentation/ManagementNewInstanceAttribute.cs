using System;
using System.Security.Permissions;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Базовый класс для атрибутов управления, у которых есть только функции времени выполнения и нет представления схемы.
	///          Классы атрибутов управления ManagementBindAttribute, ManagementCreateAttribute и ManagementEnumeratorAttribute являются производными от этого класса.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x0200037A RID: 890
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public abstract class ManagementNewInstanceAttribute : ManagementMemberAttribute
	{
	}
}
