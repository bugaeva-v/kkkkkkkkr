using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Этот класс использует платформа расширений поставщика WMI.NET.
	///          Это базовый класс для всех управляющих атрибутов, которые могут применяться к элементам.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x0200037B RID: 891
	[AttributeUsage(AttributeTargets.All)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public abstract class ManagementMemberAttribute : Attribute
	{
		/// <summary>
		///         Возвращает или задает имя элемента управления.
		///       </summary>
		/// <returns>
		///         Возвращает строку, которая представляет имя элемента управления.
		///       </returns>
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x00003A59 File Offset: 0x00001C59
		public string Name
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
