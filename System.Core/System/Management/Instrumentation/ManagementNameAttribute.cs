using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementName используется для переопределения имен, предоставляемых через класс WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000384 RID: 900
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementNameAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.ManagementNameAttribute" /> класс, который содержит значение <see cref="P:System.Management.ManagementNameAttribute.Name" /> Свойства класса.
		///       </summary>
		/// <param name="name">
		///           Понятное имя для объекта.
		///         </param>
		// Token: 0x06001B14 RID: 6932 RVA: 0x00003A59 File Offset: 0x00001C59
		public ManagementNameAttribute(string name)
		{
		}

		/// <summary>
		///         Возвращает или задает понятное имя объекта.
		///          Этот объект может быть параметра метода или свойства, отмеченные ManagementProbe, ManagementKey или ManagementConfiguration атрибуты.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.String" /> значение, указывающее, понятное пользователям имя для объекта.
		///       </returns>
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Name
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}
	}
}
