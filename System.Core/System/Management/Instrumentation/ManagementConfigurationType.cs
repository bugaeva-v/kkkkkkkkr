using System;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Представляет возможное поведение фиксации свойства чтения и записи.
	///          Используется в качестве значения параметра атрибута <see cref="T:System.Management.Instrumentation.ManagementConfigurationAttribute" />.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x0200037E RID: 894
	public enum ManagementConfigurationType
	{
		/// <summary>
		///         Установленные значения вступают в силу только после вызова метода Commit.
		///       </summary>
		// Token: 0x04000D05 RID: 3333
		Apply,
		/// <summary>
		///         Установленные значения вступают в силу немедленно.
		///       </summary>
		// Token: 0x04000D06 RID: 3334
		OnCommit
	}
}
