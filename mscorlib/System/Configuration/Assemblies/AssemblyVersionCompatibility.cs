using System;

namespace System.Configuration.Assemblies
{
	/// <summary>Определяет различные типы совместимости версий сборки. Это перечисление не поддерживается платформой .NET Framework SDK версии 1.0.</summary>
	// Token: 0x02000A0D RID: 2573
	public enum AssemblyVersionCompatibility
	{
		/// <summary>Сборка не может выполняться одновременно с другими своими версиями, если они выполняются на одном компьютере.</summary>
		// Token: 0x0400385E RID: 14430
		SameMachine = 1,
		/// <summary>Сборка не может выполняться одновременно с другими своими версиями, если они выполняются в одном процессе.</summary>
		// Token: 0x0400385F RID: 14431
		SameProcess,
		/// <summary>Сборка не может выполняться одновременно с другими своими версиями, если они выполняются в одном домене приложения.</summary>
		// Token: 0x04003860 RID: 14432
		SameDomain
	}
}
