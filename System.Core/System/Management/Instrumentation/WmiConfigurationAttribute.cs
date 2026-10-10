using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут WmiConfiguration указывает, что сборка содержит код, который реализует поставщик WMI с использованием модели расширений поставщика WMI.NET.
	///          Атрибут принимает параметры, которые обеспечивают конфигурацию высокого уровня для реализованного поставщика WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000389 RID: 905
	[AttributeUsage(AttributeTargets.Assembly)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class WmiConfigurationAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Management.WmiConfigurationAttribute" /> класс, который определяет пространство имен WMI, в котором поставщик WMI будет предоставлять классы.
		///       </summary>
		/// <param name="scope">
		///           Пространство имен WMI, в котором поставщик будет предоставлять классы.
		///            Например, «root\MyProviderNamespace».
		///         </param>
		// Token: 0x06001B22 RID: 6946 RVA: 0x00003A59 File Offset: 0x00001C59
		public WmiConfigurationAttribute(string scope)
		{
		}

		/// <summary>
		///         Возвращает или задает группу размещения для поставщика WMI.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.String" /> значение, указывающее группу размещения для поставщика WMI.
		///       </returns>
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x00003A59 File Offset: 0x00001C59
		public string HostingGroup
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
		///         Возвращает или задает модель размещения для поставщика WMI.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Management.Instrumentation.ManagementHostingModel" /> значение, указывающее модель размещения поставщика WMI.
		///       </returns>
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0005A25C File Offset: 0x0005845C
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x00003A59 File Offset: 0x00001C59
		public ManagementHostingModel HostingModel
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return ManagementHostingModel.Decoupled;
			}
			set
			{
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, может ли поставщик WMI олицетворять вызывающий объект.
		///          Если значение равно false, поставщик не может олицетворять, а если значение равно true, поставщик может олицетворять.
		///       </summary>
		/// <returns>
		///         Логическое значение, указывающее, является ли поставщик может или не может олицетворять вызывающий объект.
		///          Если значение равно false, поставщик не может олицетворять, а если значение равно true, поставщик может олицетворять.
		///       </returns>
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0005A278 File Offset: 0x00058478
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x00003A59 File Offset: 0x00001C59
		public bool IdentifyLevel
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
		///         Возвращает или задает строку языка определения дескрипторов безопасности (SDDL), которая указывает дескриптор безопасности для пространства имен, в котором поставщик предоставляет управляющие объекты.
		///       </summary>
		/// <returns>
		///         Строки SDDL, представляющий дескриптор безопасности для пространства имен, в котором поставщик предоставляет управляющие объекты.
		///       </returns>
		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x00003A59 File Offset: 0x00001C59
		public string NamespaceSecurity
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
		///         Возвращает или задает пространство имен WMI, в котором поставщик WMI предоставляет классы.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.String" /> значение, указывающее пространство имен, в котором поставщик WMI предоставляет классы.
		///       </returns>
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0005A05A File Offset: 0x0005825A
		public string Scope
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает или задает дескриптор безопасности для поставщика WMI.
		///          Дополнительные сведения см. в разделе сведения о свойстве SecurityDescriptor в разделе «__Win32Provider» в библиотеке MSDN online по http://www.msdn.com.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.String" /> значение, содержащее дескриптор безопасности для поставщика WMI.
		///       </returns>
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x00003A59 File Offset: 0x00001C59
		public string SecurityRestriction
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
