using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementProbe указывает, что свойство или поле представляет свойство WMI с доступом только на чтение.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000385 RID: 901
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementProbeAttribute : ManagementMemberAttribute
	{
		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает свойство, помеченное атрибутом ManagementProbe.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Type" /> значение, которое указывает тип вывода, который возвращает свойство, помеченное атрибутом ManagementProbe.
		///       </returns>
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00003A59 File Offset: 0x00001C59
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
