using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Задает флаги, которые изменяют режим работы поставщиков служб шифрования.</summary>
	// Token: 0x02000485 RID: 1157
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum CspProviderFlags
	{
		/// <summary>Не указывать никаких параметров.</summary>
		// Token: 0x04002146 RID: 8518
		NoFlags = 0,
		/// <summary>Использовать сведения о ключе из хранилища ключей компьютера.</summary>
		// Token: 0x04002147 RID: 8519
		UseMachineKeyStore = 1,
		/// <summary>Использовать сведения о ключе из контейнера ключа по умолчанию.</summary>
		// Token: 0x04002148 RID: 8520
		UseDefaultKeyContainer = 2,
		/// <summary>Использовать сведения о ключе, которые невозможно экспортировать.</summary>
		// Token: 0x04002149 RID: 8521
		UseNonExportableKey = 4,
		/// <summary>Использовать сведения о ключе из текущего ключа.</summary>
		// Token: 0x0400214A RID: 8522
		UseExistingKey = 8,
		/// <summary>Разрешить экспорт ключа для архивации или восстановления.</summary>
		// Token: 0x0400214B RID: 8523
		UseArchivableKey = 16,
		/// <summary>Предупреждать пользователя с помощью диалогового окна или иным способом о том, что для выполнения определенных действий предпринимается попытка воспользоваться ключом.  Этот флаг несовместим с флагом <see cref="F:System.Security.Cryptography.CspProviderFlags.NoPrompt" />.</summary>
		// Token: 0x0400214C RID: 8524
		UseUserProtectedKey = 32,
		/// <summary>Поставщик служб шифрования не должен отображать пользовательский интерфейс для данного контекста.</summary>
		// Token: 0x0400214D RID: 8525
		NoPrompt = 64,
		/// <summary>Создать временный ключ, который высвобождается при закрытии соответствующего объекта RSA. Не используйте этот флаг, если ключ должен быть независим от объекта RSA.</summary>
		// Token: 0x0400214E RID: 8526
		CreateEphemeralKey = 128
	}
}
