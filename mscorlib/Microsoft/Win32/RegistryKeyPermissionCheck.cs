using System;

namespace Microsoft.Win32
{
	/// <summary>Определяет, выполняются ли проверки безопасности при открытии разделов реестра и доступе к соответствующим парам "имя-значение".</summary>
	// Token: 0x020000A5 RID: 165
	public enum RegistryKeyPermissionCheck
	{
		/// <summary>Раздел реестра наследует режим родительского раздела. Проверки безопасности выполняются при попытке доступа к вложенным разделам или значениям, если родительский раздел не был открыт в режиме <see cref="F:Microsoft.Win32.RegistryKeyPermissionCheck.ReadSubTree" /> или <see cref="F:Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree" />.</summary>
		// Token: 0x04000F6B RID: 3947
		Default,
		/// <summary>Никакие проверки безопасности не выполняются при доступе к вложенным разделам или значениям. Проверка безопасности выполняется при попытке открыть текущий раздел, если родительский раздел был открыт с помощью поля <see cref="F:Microsoft.Win32.RegistryKeyPermissionCheck.ReadSubTree" /> или <see cref="F:Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree" />.</summary>
		// Token: 0x04000F6C RID: 3948
		ReadSubTree,
		/// <summary>Никакие проверки безопасности не выполняются при доступе к вложенным разделам или значениям. Проверка безопасности выполняется при попытке открыть текущий раздел, если родительский раздел был открыт с помощью поля <see cref="F:Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree" />.</summary>
		// Token: 0x04000F6D RID: 3949
		ReadWriteSubTree
	}
}
