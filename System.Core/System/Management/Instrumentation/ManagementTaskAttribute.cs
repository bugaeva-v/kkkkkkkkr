using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementTask указывает, что целевой метод реализует метод WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000388 RID: 904
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementTaskAttribute : ManagementMemberAttribute
	{
		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает метод, помеченный атрибутом ManagementTask.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Type" /> значение, которое указывает тип вывода, который возвращает метод, помеченный атрибутом ManagementTask.
		///       </returns>
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00003A59 File Offset: 0x00001C59
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
