using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementConfiguration указывает, что свойство или поле представляет свойство WMI с доступом на чтение и запись.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x0200037D RID: 893
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementConfigurationAttribute : ManagementMemberAttribute
	{
		/// <summary>
		///         Возвращает или задает режим свойство, которое указывает, как можно быстрее применения изменений к нему или при вызове метода commit.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Management.Instrumentation.ManagementConfigurationType" /> указывающее, использует ли свойство WMI <see cref="F:System.Management.Instrumentation.ManagementConfigurationType.Apply" /> или <see cref="F:System.Management.Instrumentation.ManagementConfigurationType.OnCommit" /> режиме.
		///       </returns>
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0005A208 File Offset: 0x00058408
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00003A59 File Offset: 0x00001C59
		public ManagementConfigurationType Mode
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return ManagementConfigurationType.Apply;
			}
			set
			{
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает свойство, помеченное атрибутом ManagementConfiguration.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Type" /> возвращает значение, представляющее тип выходных данных, свойство, помеченное атрибутом ManagementConfiguration.
		///       </returns>
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00003A59 File Offset: 0x00001C59
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
