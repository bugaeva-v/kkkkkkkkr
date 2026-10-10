using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementEntity указывает, что класс предоставляет сведения об управлении, полученные от поставщика WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000380 RID: 896
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementEntityAttribute : Attribute
	{
		/// <summary>
		///         Возвращает или задает значение, указывающее, представляет ли класс в поставщике реализован класс WMI внешних к текущей сборке.
		///       </summary>
		/// <returns>
		///         Логическое значение, равное true, если класс представляет внешний класс WMI и false в противном случае.
		///       </returns>
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0005A224 File Offset: 0x00058424
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00003A59 File Offset: 0x00001C59
		public bool External
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
			}
		}

		/// <summary>
		///         Возвращает или задает имя класса WMI.
		///       </summary>
		/// <returns>
		///         Строка, содержащая имя класса WMI.
		///       </returns>
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x00003A59 File Offset: 0x00001C59
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

		/// <summary>
		///         Указывает, представляет ли связанный класс singleton-классом WMI.
		///       </summary>
		/// <returns>
		///         Логическое значение, равное true, если класс представляет singleton-класс WMI и false в противном случае.
		///       </returns>
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0005A240 File Offset: 0x00058440
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x00003A59 File Offset: 0x00001C59
		public bool Singleton
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
			set
			{
			}
		}
	}
}
