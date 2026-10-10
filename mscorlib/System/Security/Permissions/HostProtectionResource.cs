using System;

namespace System.Security.Permissions
{
	/// <summary>Определяет категории функциональных возможностей для узла, которые могут быть потенциально опасны, если они вызываются методом или классом.</summary>
	// Token: 0x0200042A RID: 1066
	[Flags]
	public enum HostProtectionResource
	{
		/// <summary>Предоставляет все ресурсы узла.</summary>
		// Token: 0x04001FD3 RID: 8147
		All = 511,
		/// <summary>Может создавать или уничтожать другие процессы.</summary>
		// Token: 0x04001FD4 RID: 8148
		ExternalProcessMgmt = 4,
		/// <summary>Создает потоки или управляет потоками, не являющимися его собственными, и которые могут быть вредны для узла.</summary>
		// Token: 0x04001FD5 RID: 8149
		ExternalThreading = 16,
		/// <summary>Может быть причиной утечки ресурсов при прерывании, если они не защищены безопасными дескрипторами или другими средствами, обеспечивающими освобождение ресурсов.</summary>
		// Token: 0x04001FD6 RID: 8150
		MayLeakOnAbort = 256,
		/// <summary>Не предоставляет ресурсы узла.</summary>
		// Token: 0x04001FD7 RID: 8151
		None = 0,
		/// <summary>Предоставляет инфраструктуру безопасности.</summary>
		// Token: 0x04001FD8 RID: 8152
		SecurityInfrastructure = 64,
		/// <summary>Может привести к выходу из текущего процесса, прервав серверный процесс.</summary>
		// Token: 0x04001FD9 RID: 8153
		SelfAffectingProcessMgmt = 8,
		/// <summary>Управляет потоками таким образом, что воздействует только на код пользователя.</summary>
		// Token: 0x04001FDA RID: 8154
		SelfAffectingThreading = 32,
		/// <summary>Предоставляет состояние, которое может быть совместно использовано несколькими потоками.</summary>
		// Token: 0x04001FDB RID: 8155
		SharedState = 2,
		/// <summary>Обеспечивает синхронизацию.</summary>
		// Token: 0x04001FDC RID: 8156
		Synchronization = 1,
		/// <summary>Предоставляет пользовательский интерфейс.</summary>
		// Token: 0x04001FDD RID: 8157
		UI = 128
	}
}
