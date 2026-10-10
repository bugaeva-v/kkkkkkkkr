using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementReferenceAttribute помечает элемент класса, свойство или параметр метода в качестве ссылки на другой объект или класс управления.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000386 RID: 902
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementReferenceAttribute : Attribute
	{
		/// <summary>
		///         Возвращает или задает имя типа, на который указывает ссылка.
		///       </summary>
		/// <returns>
		///         Строка, содержащая имя типа, на который указывает ссылка.
		///       </returns>
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00003A59 File Offset: 0x00001C59
		public string Type
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
